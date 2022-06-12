﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;
using Microsoft.VisualBasic;

namespace ChapeauUI
{
    public partial class BillUI : Form
    {
        private BillService billService;
        private Bill bill;
        private PopUpUI confirmBox;
        private Reservation reservation;
        private Staff staff;
        private PaymentMethod paymentMethod;
        private double totalPrice;
        private double tip;
        private double remainingAmount;
        private double change;

        public BillUI(Reservation reservation, Staff staff)
        {
            InitializeComponent();
            this.reservation = reservation;
            this.staff = staff;
            ShowHeader();
            MakeBill();
        }

        public void ShowHeader()
        {
             headerLabel.Text = $"bill table {reservation.TableId}";
             headerLabel.Text = headerLabel.Text.ToUpper();
        }
        private void MakeBill()
        {
            billService = new BillService();
            bill = billService.MakeBill(reservation.ReservationId);
            totalPrice = bill.TotalPriceInclVAT;
            labelExVAT.Text = bill.TotalPriceExclVAT.ToString("€ 0.00");
            labelVAT.Text = bill.TotalVAT.ToString("€ 0.00");
            labelInVAT.Text = bill.TotalPriceInclVAT.ToString("€ 0.00");
            FillGrid(billGrid);
        }
        private void buttonTip_Click(object sender, EventArgs e)
        {
          
            confirmBox = new PopUpUI("Do you want to add a tip?", DialogResult.None);
            confirmBox.ShowDialog();
            tip = confirmBox.InputDouble();
            labelTip.Text = tip.ToString("€ 0.00");
            totalPrice = bill.TotalPriceInclVAT + tip;
            labelInVAT.Text = totalPrice.ToString("€ 0.00");   
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowBill()
        {
            billPanel.Hide();
            payPanel.Hide();
            FillCompleteBill();
            LogBill();
            completeBill.Show();
        }
        private void FillCompleteBill()
        {
            labelBillExVAT.Text = bill.TotalPriceExclVAT.ToString("€ 0.00");
            labelBillTotal.Text = bill.TotalPriceInclVAT.ToString("€ 0.00");
            labelTip.Text = tip.ToString("€ 0.00");
            labelVAT.Text = bill.TotalVAT.ToString("€ 0.00");
            labelTabelNr.Text = reservation.TableId.ToString();
            labelWaiterName.Text = staff.firstName.ToString();
            labelDate.Text = DateTime.Now.ToString("dd/MM/yy HH:mm");
            
            labelReservation.Text = $"#{reservation.ReservationId}";
            labelBillVAT.Text = bill.TotalVAT.ToString("€ 0.00");
            labelBillTip.Text = tip.ToString("€ 0.00");
            labelChange.Text = change.ToString("€ 0.00");

            if (paymentMethod == PaymentMethod.CASHANDCARD)
                labelPaymentMethod.Text = "CASH AND CARD";
            else labelPaymentMethod.Text = paymentMethod.ToString();


            FillGrid(gridCompleteBill);
        }
        private void FillGrid(DataGridView grid)
        {
            grid.ColumnCount = 3;
            grid.Columns[0].Name = "MENU ITEMS";
            grid.Columns[0].Width = 450;
            grid.Columns[1].Name = "QTY";
            grid.Columns[1].Width = 80;
            grid.Columns[2].Name = "PRICE";
            grid.Columns[2].Width = 120;
            for (int i = 0; i < bill.MenuItems.Count; i++)
            {
                grid.Rows.Add
                    (bill.MenuItems[i].MenuItem.ProductName,
                    bill.MenuItems[i].Amount,
                    bill.MenuItems[i].MenuItem.Price.ToString("€ 0.00"));
            };
        }

        private void buttonBackToBill_Click(object sender, EventArgs e)
        {
            payPanel.Hide();
            billPanel.Show();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            billPanel.Hide();
            payPanel.Show();
            remainingAmount = totalPrice;
            labelRemaining.Text = remainingAmount.ToString("€ 0.00");
        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
            Pay(PaymentMethod.CASH);
        }
        private void buttonPin_Click(object sender, EventArgs e)
        {
            Pay(PaymentMethod.CARD);
        }

        private void Pay(PaymentMethod method)
        {
            double amount = remainingAmount;
            try
            {
                if (amountInput.Text != "")
                {
                    amount = double.Parse(amountInput.Text.Replace('.', ','));
                }
                confirmBox = new PopUpUI($"Do you want to pay €{amount:0.00} with {method}?");
                confirmBox.ShowDialog();
                if (confirmBox.DialogResult == DialogResult.Yes)
                {
                    remainingAmount -= amount;

                    SetPayment(method);

                    if (remainingAmount == 0)
                    {
                        confirmBox = new PopUpUI($"Payment completed!", DialogResult.OK);
                        confirmBox.ShowDialog();
                        ShowBill();
                    }
                    else if (remainingAmount < 0 && method == PaymentMethod.CASH)
                    {
                        change = remainingAmount * -1;
                        confirmBox = new PopUpUI($"Payment completed!\nChange:\n€{change:0.00}", DialogResult.OK);
                        confirmBox.ShowDialog();
                        ShowBill();
                    }
                    else if(remainingAmount < 0 && method == PaymentMethod.CARD)
                    {
                        confirmBox = new PopUpUI($"Payment too high", DialogResult.OK);
                        confirmBox.ShowDialog();
                        remainingAmount += amount;
                    }

                    labelRemaining.Text = remainingAmount.ToString("€ 0.00");
                }
            }
            catch
            {
                confirmBox = new PopUpUI("Please enter a number", DialogResult.OK);
                confirmBox.ShowDialog();
            }
        }
        private void SetPayment(PaymentMethod method)
        {
            if (paymentMethod == PaymentMethod.NotSelected)
                paymentMethod = method;

            else paymentMethod = PaymentMethod.CASHANDCARD;
        }

        private void LogBill()
        {
            bill = new Bill()
            {
                Table = new Table()
                {
                    TableID = reservation.TableId,
                    WaiterID = staff.Staff_ID,
                },
                Tip = tip,
                IsPaid = true,
                Date = DateTime.Now,
                Comments = commentBox.Text,
                PaymentMethod = paymentMethod,
            };
            billService.AddBill(bill);
            billService.FinishReservarion(reservation.ReservationId);
        }
        private void backToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

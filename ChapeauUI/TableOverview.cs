﻿using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class TableOverview : Form
    {
        private int selectedTable;
        private MenuChoice menuChoice;
        private Staff loggedInStaffMember;
        public TableOverview(Staff loggedInStaffMember)
        {
            this.loggedInStaffMember = loggedInStaffMember;
            InitializeComponent();
            hideAllPanels();
            startMenuPnl.Show();
        }

        private void checkTimeSinceOrderPlaced()
        {
            OrderService orderService = new OrderService();
            List<Order> lastOrders = orderService.GetLastOrders();
            for(int i = 0; i < 10; i++)
            {

            }
        }
        private void hideAllPanels()
        {
            startMenuPnl.Hide();
            TableOverviewPnl.Hide();
            makeReservationPnl.Hide();
            notificationPnl.Hide();
            markReservationPresentPnl.Hide();
        }
        private void tableWasSelected(int tableNr)
        {
            if (menuChoice == MenuChoice.TakeOrder)
            {
                ReservationService reservationService = new ReservationService();
                OrderUI orderUI = new OrderUI(reservationService.GetPresentReservationByTable(tableNr));
                this.Hide();
                orderUI.Show();
            }
            else if (menuChoice == MenuChoice.ShowBill)
            {

            }
            else if (menuChoice == MenuChoice.MakeReservation)
            {
                hideAllPanels();
                makeReservationPnl.Show();
                selectedTable = tableNr;
            }
        }

        private void takeOrderBtn_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            menuChoice = MenuChoice.TakeOrder;
            TableOverviewPnl.Show();
        }
        private void showBillBtn_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            menuChoice = MenuChoice.ShowBill;
            TableOverviewPnl.Show();
        }

        private void makeReservationBtn_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            menuChoice = MenuChoice.MakeReservation;
            TableOverviewPnl.Show();
        }

        private void notificationsBtn_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            notificationPnl.Show();
            OrderService orderService = new OrderService();
            List<Order> readyOrders = orderService.GetOrdersForWaiterToDeliver(loggedInStaffMember.Staff_ID);
            ordersReadyGridView.Rows.Clear();
            ordersReadyGridView.ColumnCount = 2;
            ordersReadyGridView.Columns[0].Name = "Order ID";
            ordersReadyGridView.Columns[1].Name = "Table ID";
            foreach (Order order in readyOrders)
            {
                ordersReadyGridView.Rows.Add(order.OrderId, order.TableId);
            }
        }

        private void tableOneButton_Click(object sender, EventArgs e)
        {
            tableWasSelected(1);
        }

        private void tableTwoButton_Click(object sender, EventArgs e)
        {
            tableWasSelected(2);
        }

        private void tableThreeButton_Click(object sender, EventArgs e)
        {
            tableWasSelected(3);
        }

        private void tableFourButton_Click(object sender, EventArgs e)
        {
            tableWasSelected(4);
        }

        private void tableFiveButton_Click(object sender, EventArgs e)
        {
            tableWasSelected(5);
        }

        private void tableSixButton_Click(object sender, EventArgs e)
        {
            tableWasSelected(6);
        }

        private void tableSevenButton_Click(object sender, EventArgs e)
        {
            tableWasSelected(7);
        }

        private void tableEightButton_Click(object sender, EventArgs e)
        {
            tableWasSelected(8);
        }

        private void tableNineButton_Click(object sender, EventArgs e)
        {
            tableWasSelected(9);
        }

        private void tableTenButton_Click(object sender, EventArgs e)
        {
            tableWasSelected(10);
        }

        private void confirmReservationBtn_Click(object sender, EventArgs e)
        {
            ReservationService reservationService = new ReservationService();
            string customerName = reservationNameTextBox.Text;
            DateTime reservationTime = reservationDateTimePicker.Value;
            string comments = reservationCommentsTextBox.Text;
            int phoneNumber = int.Parse(reservationPhonenumberTextBox.Text);
            string emailAdress = reservationEmailTextBox.Text;
            reservationService.AddNewReservation(customerName, false, reservationTime, selectedTable, comments, phoneNumber, emailAdress);
            hideAllPanels();
            startMenuPnl.Show();
        }

        private void markReservationPresentBtn_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            markReservationPresentPnl.Show();
            ReservationService reservationService = new ReservationService();
            List<Reservation> reservations = reservationService.GetAllNonPresentReservationsOrderedByTable();
            reservationOverviewDataGrid.ColumnCount = 2;
            reservationOverviewDataGrid.Columns[0].Name = "Reservation ID";
            reservationOverviewDataGrid.Columns[1].Name = "Reservation time";
            foreach (Reservation reservation in reservations)
            {
                reservationOverviewDataGrid.Rows.Add(reservation.TableId, reservation.ReservationTime);
            }
        }

        private void reservationOverviewDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}

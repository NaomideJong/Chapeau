using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class KitchenAndBarOverview : Form
    {
        public KitchenAndBarOverview()
        {
            InitializeComponent();
            kitchenListView.Hide();
            labelKitchen.Hide();
            finishedFoodButton.Hide();
            barListView.Hide();
            labelBar.Hide();
            finishedDrinkButton.Hide();
        }
        public void Kitchen()
        {
            OrderService orderService = new OrderService();
            OrderItem orderItem = new OrderItem();
            List<OrderItem> ordersFoodList = orderService.GetActiveFoodOrders();

            kitchenListView.Clear();
            kitchenListView.View = View.Details;
            kitchenListView.FullRowSelect = true;
            kitchenListView.Columns.Add("Order ID", 100);
            kitchenListView.Columns.Add("MenuItem ID", 100);
            kitchenListView.Columns.Add("Order", 500); //productname
            kitchenListView.Columns.Add("Amount of order", 100);
            kitchenListView.Columns.Add("Description", 200);
            kitchenListView.Columns.Add("Comments", 200);
            kitchenListView.Columns.Add("Time of ordering", 200);
            foreach (OrderItem order in ordersFoodList)
            {
                ListViewItem li = new ListViewItem(order.Order.OrderId.ToString());
                li.SubItems.Add(order.MenuItem.MenuItemId.ToString());
                li.SubItems.Add(order.MenuItem.ProductName);
                li.SubItems.Add(order.Amount.ToString());
                li.SubItems.Add(order.MenuItem.Description);
                li.SubItems.Add(order.Order.Comments);
                li.SubItems.Add(order.Order.TimePlaced.ToString());
                kitchenListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                kitchenListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
                kitchenListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
                kitchenListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
                kitchenListView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
                kitchenListView.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.ColumnContent);
                kitchenListView.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.HeaderSize);

                kitchenListView.Items.Add(li);
            }

            ColorListView(kitchenListView);

        }

        private void kitchenListView_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void ColorListView(ListView listview)
        {
            for (int i = 0; i < listview.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listview.Items[i].BackColor = Color.LightBlue;
                }
            }
        }
        private void finishedFoodButton_Click(object sender, EventArgs e)
        {
            try
            {
                OrderItem order = new OrderItem()
                {
                    Order = new Order()
                    {
                        IsFinished = true,
                        OrderId = int.Parse(kitchenListView.SelectedItems[0].SubItems[0].Text),
                    },
                    MenuItem = new MenuItem()
                    {
                        MenuItemId = int.Parse(kitchenListView.SelectedItems[0].SubItems[1].Text),
                        ProductName = kitchenListView.SelectedItems[0].SubItems[2].Text
                    }
                };

                OrderService orderService = new OrderService();
                orderService.GetUpdateStateIsFinished(order);
                MessageBox.Show($"Order {order.Order.OrderId}: {order.MenuItem.ProductName} has been succesfully finished\n" + "Notice has been sent to the waiter");
            } 

            catch
            {
                MessageBox.Show("Please make sure to select an order to complete");
            }
        }

        private void KitchenOverview_Load(object sender, EventArgs e)
        {

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 30000;//30 seconds
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();

            System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 30000;//30 seconds
            timer2.Tick += new System.EventHandler(timer2_Tick);
            timer2.Start();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Kitchen();

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            InlogForm loginPage = new InlogForm();
            loginPage.ShowDialog();
            this.Close();
        }

        private void barListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Bar();
        }
        private void Bar()
        {
            //do whatever you want 
            OrderService orderService = new OrderService();
            OrderItem orderItem = new OrderItem();
            List<OrderItem> ordersDrinkList = orderService.GetActiveDrinkOrders();


            barListView.Clear();
            barListView.View = View.Details;
            barListView.FullRowSelect = true;
            barListView.Columns.Add("Order ID", 100);
            barListView.Columns.Add("Menuitem ID", 100);
            barListView.Columns.Add("Order", 500); //productname
            barListView.Columns.Add("Amount of order", 100);
            barListView.Columns.Add("Description", 200);
            barListView.Columns.Add("Comments", 200);
            barListView.Columns.Add("Time of ordering", 200);
            foreach (OrderItem order in ordersDrinkList)
            {
                ListViewItem li = new ListViewItem(order.Order.OrderId.ToString());
                li.SubItems.Add(order.MenuItem.MenuItemId.ToString());
                li.SubItems.Add(order.MenuItem.ProductName);
                li.SubItems.Add(order.Amount.ToString());
                li.SubItems.Add(order.MenuItem.Description);
                li.SubItems.Add(order.Order.Comments);
                li.SubItems.Add(order.Order.TimePlaced.ToString());
                barListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                barListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
                barListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
                barListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
                barListView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
                barListView.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.ColumnContent);
                barListView.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.HeaderSize);
                barListView.Items.Add(li);
            }
            ColorListView(barListView);

        }
 

        private void finishedDrinkButton_Click(object sender, EventArgs e)
        {
            try 
            { 
            OrderItem order = new OrderItem()
            {
                Order = new Order()
                {
                    IsFinished = true,
                    OrderId = int.Parse(barListView.SelectedItems[0].SubItems[0].Text),
                },
                MenuItem = new MenuItem()
                {
                    MenuItemId = int.Parse(barListView.SelectedItems[0].SubItems[1].Text),
                    ProductName = barListView.SelectedItems[0].SubItems[2].Text
                }
            };

            OrderService orderService = new OrderService();
            orderService.GetUpdateStateIsFinished(order);
            MessageBox.Show($"Order {order.Order.OrderId}: {order.MenuItem.ProductName} has been succesfully finished\n" + "Notice has been sent to the waiter");
            }
            catch
            {
                MessageBox.Show("Please select an order!");
            }
        }

        private void radioButtonKitchen_CheckedChanged(object sender, EventArgs e)
        {

            kitchenListView.Show();
            labelKitchen.Show();
            finishedFoodButton.Show();
            barListView.Hide();
            labelBar.Hide();
            finishedDrinkButton.Hide();
            Kitchen();
        }

        private void radioButtonBar_CheckedChanged(object sender, EventArgs e)
        {

            kitchenListView.Hide();
            labelKitchen.Hide();
            finishedFoodButton.Hide();
            barListView.Show();
            labelBar.Show();
            finishedDrinkButton.Show();
            Bar();
        }
    }
        
    
}

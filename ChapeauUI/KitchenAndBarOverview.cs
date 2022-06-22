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
        private Staff BartenderOrChef;
        private List<Order> orderFoodOrDrinkList;
        private SortingType sortingType;
        private OrderService orderService;

        public KitchenAndBarOverview(StaffJob staffJob)
        {
            InitializeComponent();
            BartenderOrChef = new Staff();
            BartenderOrChef.StaffJob = staffJob;
            if (BartenderOrChef.StaffJob == StaffJob.Chef)
            {
                labelKitchenOrBar.Text = "Kitchen";
                sortButtonByAlcoholic.Hide();
            }
            else
            {
                labelKitchenOrBar.Text = "Bar";
                titleSelectThreeCourseMeal.Hide();
                comboBoxThreeCourseMeal.Hide();
                SelectAllMenuItemType.Hide();

            }
            progressBarUpdate.Value = 100;
            buttonGetThisOrder.Hide();

            //ProgressBar();
            listViewComments.Show();
            comboBoxThreeCourseMeal.Items.Add(MenuItemType.Starter);
            comboBoxThreeCourseMeal.Items.Add(MenuItemType.MainCourse);
            comboBoxThreeCourseMeal.Items.Add(MenuItemType.Desserts);
            orderService = new OrderService();
            sortingType = new SortingType();
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (progressBarUpdate.Value < 100)
                progressBarUpdate.Value += 1;
            else
            {
                listViewComments.Items.Clear();
                progressBarUpdate.Value = 0;

                if (sortingType == SortingType.duration)
                    sortButtonDuration_Click(sender, e);
                else if (sortingType == SortingType.orderName)
                    sortButtonOrder_Click(sender, e);
                else if (sortingType == SortingType.amount)
                    sortButtonAmount_Click(sender, e);
                else if (sortingType == SortingType.table)
                    sortButtonTable_Click(sender, e);
                else if (sortingType == SortingType.alcoholic)
                    sortButtonByAlcoholic_Click(sender, e);
                else if (sortingType == SortingType.orderID)
                    sortButtonOrderID_Click(sender, e);
                else
                {
                    if (BartenderOrChef.StaffJob == StaffJob.Chef)
                    {
                        labelKitchenOrBar.Text = "Kitchen";
                        orderFoodOrDrinkList = orderService.GetActiveFoodOrders();
                    }
                    else if (BartenderOrChef.StaffJob == StaffJob.Bartender)
                    {
                        labelKitchenOrBar.Text = "Bar";
                        comboBoxThreeCourseMeal.Hide();
                        titleSelectThreeCourseMeal.Hide();
                        SelectAllMenuItemType.Hide();
                        orderFoodOrDrinkList = orderService.GetActiveDrinkOrders();
                    }
                    FillListview(orderFoodOrDrinkList);
                }
            }
        }

        private void KitchenOverview_Load(object sender, EventArgs e)
        {
            progressBarUpdate.Show();
            Timer timer = new Timer();
            timer.Interval = 300;
            timer.Tick += new System.EventHandler(timerProgress_Tick);
            timer.Start();
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kitchenOrBarListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewComments.BeginUpdate();
            listViewComments.Clear();
            listViewComments.View = View.Details;
            listViewComments.FullRowSelect = true;
            listViewComments.Columns.Add("Order ID", 100);
            listViewComments.Columns.Add("Menuitem ID", 100);
            listViewComments.Columns.Add("Comments", 500);
            for (int i = 0; i < kitchenOrBarListView.SelectedItems.Count; i++)
            {
                int correctOrderIndex = orderFoodOrDrinkList.FindIndex(x => x.OrderId == Convert.ToInt32(kitchenOrBarListView.SelectedItems[i].SubItems[0].Text));
                ListViewItem li = new ListViewItem(kitchenOrBarListView.SelectedItems[i].SubItems[0].Text);
                li.SubItems.Add(kitchenOrBarListView.SelectedItems[i].SubItems[1].Text);
                li.SubItems.Add(orderFoodOrDrinkList[correctOrderIndex].Comments);
                listViewComments.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewComments.Items.Add(li);
            }
            ColorListView(listViewComments);
            listViewComments.EndUpdate();
        }
        private void FillListview(List<Order> ordersList)
        {
            kitchenOrBarListView.BeginUpdate();
            kitchenOrBarListView.Clear();
            kitchenOrBarListView.View = View.Details;
            kitchenOrBarListView.FullRowSelect = true;
            kitchenOrBarListView.Columns.Add("Order ID", 100);
            kitchenOrBarListView.Columns.Add("MenuItem ID", 100);
            kitchenOrBarListView.Columns.Add("Order", 100); //productname
            kitchenOrBarListView.Columns.Add("Amount of order", 100);
            kitchenOrBarListView.Columns.Add("Table", 200);
            kitchenOrBarListView.Columns.Add("Duration of Order (hh:mm)", 200);
            kitchenOrBarListView.Columns.Add("Time of ordering", 200);
            if (BartenderOrChef.StaffJob == StaffJob.Chef)
            {
                kitchenOrBarListView.Columns.Add("ThreeCourseMeal", 200);
            }
            else
                kitchenOrBarListView.Columns.Add("Alcoholic", 100);
            foreach (Order order in ordersList)
            {
                TimeSpan timeOfOrder = DateTime.Now - order.TimePlaced;

                for (int i = 0; i < order.OrderItems.Count; i++)
                {
                    ListViewItem li = new ListViewItem(order.OrderId.ToString());
                    li.SubItems.Add(order.OrderItems[i].MenuItem.MenuItemId.ToString());
                    li.SubItems.Add(order.OrderItems[i].MenuItem.ProductName);
                    li.SubItems.Add(order.OrderItems[i].Amount.ToString());
                    li.SubItems.Add(order.TableId.ToString());
                    li.SubItems.Add(timeOfOrder.ToString(@"hh\:mm"));
                    li.SubItems.Add(order.TimePlaced.ToString());
                    if (BartenderOrChef.StaffJob == StaffJob.Chef)
                        li.SubItems.Add(order.OrderItems[i].MenuItem.MenuItemType.ToString());
                    else
                        li.SubItems.Add(order.OrderItems[i].IsAlcoholic.ToString());
                    li.Tag = order;

                    kitchenOrBarListView.Items.Add(li);
                }
                kitchenOrBarListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                kitchenOrBarListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
                ColorListView(kitchenOrBarListView);
            }
            kitchenOrBarListView.EndUpdate();
        }
        private void ColorListView(ListView listview)
        {
            for (int i = 0; i < listview.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listview.Items[i].BackColor = Color.FromArgb(224, 188, 188);
                }
            }
        }
        private void finishedOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (kitchenOrBarListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an order!");
                    return;
                }
                for (int i = 0; i < kitchenOrBarListView.SelectedItems.Count; i++)
                {
                    Order order = (Order)kitchenOrBarListView.SelectedItems[i].Tag;
                    foreach(OrderItem orderItem in order.OrderItems)
                    {
                        orderItem.Status = Status.Ready;
                    }
                    orderService.GetUpdateStateIsFinished((Order)kitchenOrBarListView.SelectedItems[i].Tag);
                    MessageBox.Show($"Order {order.OrderId}: {order.OrderItems[0].MenuItem.ProductName} has been succesfully finished\n" + "Notice has been sent to the waiter");
                }
                progressBarUpdate.Value = 100;
                progressBarUpdate.Show();
                UpdateListView();
            }
            catch
            {
                MessageBox.Show("Please make sure to select an order to complete");
            }
        }
        private void UpdateListView()
        {
            if(BartenderOrChef.StaffJob == StaffJob.Chef)
            {
                orderFoodOrDrinkList = orderService.GetActiveFoodOrders();
            }
            else
            {
                orderFoodOrDrinkList = orderService.GetActiveDrinkOrders();
            }
            FillListview(orderFoodOrDrinkList);
        }
        private void sortButtonOrder_Click(object sender, EventArgs e)
        {
            sortingType = SortingType.orderName;
            
            if (radioButtonSortForwards.Checked)
            {
                foreach (Order order in orderFoodOrDrinkList)
                {
                    order.OrderItems = order.OrderItems.OrderBy(x => x.MenuItem.ProductName).ToList();
                }
                orderFoodOrDrinkList = orderFoodOrDrinkList.OrderBy(x => x.OrderItems[0].MenuItem.ProductName).ToList();
            }
            else if (radioButtonSortBackwards.Checked)
            {
                foreach (Order order in orderFoodOrDrinkList)
                {
                    order.OrderItems = order.OrderItems.OrderByDescending(x => x.MenuItem.ProductName).ToList();
                }
                orderFoodOrDrinkList = orderFoodOrDrinkList.OrderByDescending(x => x.OrderItems[0].MenuItem.ProductName).ToList();
            }
            FillListview(orderFoodOrDrinkList);
        }

        private void sortButtonAmount_Click(object sender, EventArgs e)
        {
            sortingType = SortingType.amount;
            if (radioButtonSortForwards.Checked)
            {
                foreach (Order order in orderFoodOrDrinkList)
                {
                    order.OrderItems = order.OrderItems.OrderBy(x => x.Amount).ToList();
                }
                orderFoodOrDrinkList = orderFoodOrDrinkList.OrderBy(x => x.OrderItems[0].Amount).ToList();

            }
            else if (radioButtonSortBackwards.Checked)
            {
                foreach (Order order in orderFoodOrDrinkList)
                {
                    order.OrderItems = order.OrderItems.OrderByDescending(x => x.Amount).ToList();
                }
                orderFoodOrDrinkList = orderFoodOrDrinkList.OrderByDescending(x => x.OrderItems[0].Amount).ToList();

            }
            FillListview(orderFoodOrDrinkList);
        }



        private void sortButtonTable_Click(object sender, EventArgs e)
        {
            sortingType = SortingType.table;
            if (radioButtonSortForwards.Checked)
            {
                orderFoodOrDrinkList = orderFoodOrDrinkList.OrderBy(x => x.TableId).ToList();
            }
            else if (radioButtonSortBackwards.Checked)
            {
                orderFoodOrDrinkList = orderFoodOrDrinkList.OrderByDescending(x => x.TableId).ToList();
            }
            FillListview(orderFoodOrDrinkList);
        }
        private void sortButtonDuration_Click(object sender, EventArgs e)
        {
            sortingType = SortingType.duration;
            if (radioButtonSortForwards.Checked)
            {
                orderFoodOrDrinkList = orderFoodOrDrinkList.OrderBy(x => x.TimePlaced).ToList();
            }
            else if (radioButtonSortBackwards.Checked)
            {
                orderFoodOrDrinkList = orderFoodOrDrinkList.OrderByDescending(x => x.TimePlaced).ToList();
            }
            FillListview(orderFoodOrDrinkList);
        }
        private void sortButtonByAlcoholic_Click(object sender, EventArgs e)
        {
            sortingType = SortingType.alcoholic;
            if (radioButtonSortForwards.Checked)
            {
                foreach (Order order in orderFoodOrDrinkList)
                {
                    order.OrderItems = order.OrderItems.OrderBy(x => x.IsAlcoholic).ToList();
                }
                orderFoodOrDrinkList = orderFoodOrDrinkList.OrderBy(x => x.OrderItems[0].IsAlcoholic).ToList();

            }
            else if (radioButtonSortBackwards.Checked)
            {
                foreach (Order order in orderFoodOrDrinkList)
                {
                    order.OrderItems = order.OrderItems.OrderByDescending(x => x.IsAlcoholic).ToList();
                }
                orderFoodOrDrinkList = orderFoodOrDrinkList.OrderByDescending(x => x.OrderItems[0].IsAlcoholic).ToList();
            }
            FillListview(orderFoodOrDrinkList);
        }

        private void sortButtonOrderID_Click(object sender, EventArgs e)
        {
            sortingType = SortingType.orderID;
            if (radioButtonSortForwards.Checked)
            {
                orderFoodOrDrinkList = orderFoodOrDrinkList.OrderBy(x => x.OrderId).ToList();
            }
            else if (radioButtonSortBackwards.Checked)
            {

                orderFoodOrDrinkList = orderFoodOrDrinkList.OrderByDescending(x => x.OrderId).ToList();
            }
            FillListview(orderFoodOrDrinkList);
        }

        private void SelectAllOnOrderID_Click(object sender, EventArgs e)
        {
            kitchenOrBarListView.SelectedItems.Clear();
            foreach (ListViewItem li in kitchenOrBarListView.Items)
            {
                if (li.SubItems[0].Text == textBoxOrderId.Text)
                {
                    li.Selected = true;
                }
            }
        }

        private void SelectAllMenuItemType_Click(object sender, EventArgs e)
        {
            kitchenOrBarListView.SelectedItems.Clear();
            foreach (ListViewItem li in kitchenOrBarListView.Items)
            {
                if (li.SubItems[7].Text == comboBoxThreeCourseMeal.Text)
                {
                    li.Selected = true;
                }
            }
        }

        private void buttonGetThisOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewComments.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an order!");
                    return;
                }
                for (int i = 0; i < listViewComments.SelectedItems.Count; i++)
                {
                    Order order = (Order)listViewComments.SelectedItems[i].Tag;
                    foreach(OrderItem orderItem in order.OrderItems)
                    {
                        orderItem.Status = Status.NotReady;
                    }
                    orderService.GetUpdateStateIsFinished(order);
                    MessageBox.Show($"Order {order.OrderId}: {order.OrderItems[0].MenuItem.ProductName} has been succesfully retrieved");
                }
                progressBarUpdate.Value = 100;
                buttonGetThisOrder.Hide();
            }
            catch
            {
                MessageBox.Show("Please make sure to select an order to retrieve");
            }
            kitchenOrBarListView_SelectedIndexChanged(sender, e);
        }

        private void buttonGetOrderBack_Click(object sender, EventArgs e)
        {

            buttonGetThisOrder.Show();
            listViewComments.BeginUpdate();
            listViewComments.Clear();
            listViewComments.View = View.Details;
            listViewComments.FullRowSelect = true;
            listViewComments.Columns.Add("Order ID", 100);
            listViewComments.Columns.Add("MenuItem ID", 100);
            listViewComments.Columns.Add("Product Name", 100);
            listViewComments.Columns.Add("Table", 200);
            listViewComments.Columns.Add("Status", 200);

            List<Order> ordersList;// kijk in deze for

            if (BartenderOrChef.StaffJob == StaffJob.Chef)
            {
                ordersList = orderService.GetFoodOrdersFromStatusDelivered();
            }
            else
            {
                ordersList = orderService.GetDrinkOrdersFromStatusDelivered();
            }
            foreach (Order order in ordersList)
            {
                for (int i = 0; i < order.OrderItems.Count; i++)
                {
                    ListViewItem li = new ListViewItem(order.OrderId.ToString());
                    li.SubItems.Add(order.OrderItems[i].MenuItem.MenuItemId.ToString());
                    li.SubItems.Add(order.OrderItems[i].MenuItem.ProductName);
                    li.SubItems.Add(order.TableId.ToString());
                    li.SubItems.Add(order.OrderItems[i].Status.ToString());

                    li.Tag = order;

                    listViewComments.Items.Add(li);
                }
                listViewComments.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewComments.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewComments.EndUpdate();
                ColorListView(listViewComments);
            }
            listViewComments.EndUpdate();
        }
    }
}
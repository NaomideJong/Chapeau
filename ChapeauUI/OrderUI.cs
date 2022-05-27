using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;

namespace ChapeauUI
{
    public partial class OrderUI : Form
    {
        private List<MenuItem> menuList;
        private ThreeCourseMeal threeCourseMeal;
        private bool selectLunchMenu;
        public OrderUI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CreateUIComponents();
        }
        private void FillGridView()
        {
            MenuItemService menuItemService = new MenuItemService();
            menuList = menuItemService.GetMenuItems(threeCourseMeal, selectLunchMenu);
            foreach (MenuItem menuItem in menuList)
            {
                Button menuItemButton = new Button()
                {
                    Width = menu.Width - 60,
                    Height = 62,
                    Text = $"{menuItem.MenuItemId}      {menuItem.ProductName}",
                    Font = new Font("Cabin", 14),
                    ForeColor = Color.FromArgb(24, 24, 24),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Transparent,
            };
                if(menuItem.stock != 0)
                menuItemButton.Click += new EventHandler(BtnOrderAdd_Click);
                else
                {
                    menuItemButton.BackColor = Color.LightGray;
                }
                menu.Controls.Add(menuItemButton);
                menuItemButton = new Button()
                {
                    Width = 44,
                    Height = 44,
                    Text = "?",
                    Font = new Font("Cabin", 9),
                    ForeColor = Color.FromArgb(24, 24, 24),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Transparent
                };
                menuItemButton.Click += new EventHandler(BtnOrderAdd_MouseDown);
                menu.Controls.Add(menuItemButton);
            }
        }
        private void CreateUIComponents()
        {
            itemGridView.ColumnCount = 3;
            itemGridView.Columns[0].Name = "Menu Nr";
            itemGridView.Columns[1].Name = "Product Name";
            itemGridView.Columns[2].Name = "amount added";
            itemGridView.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Add",
                Text = "+",
                Name = "btnAddOrderItems",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
            });
            itemGridView.Columns.Add(
                new DataGridViewButtonColumn
                {
                    HeaderText = "Remove",
                    Text = "-",
                    Name = "btnAddOrderItems",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat

                });
        }
        void BtnOrderAdd_Click(Object sender, EventArgs e)
        {
            for (int i = 0; i < menu.Controls.Count; i++)
            {
                if (menu.Controls[i] == sender)
                {
                    if (menuList[i/2].stock <= 0)
                    {
                        menu.Controls[i].BackColor = Color.DarkGray;
                        menu.Controls[i].ForeColor = Color.Red;
                        menu.Controls[i].Text += " OUT OF STOCK";
                        menu.Controls[i].Click -= new EventHandler(BtnOrderAdd_Click);
                        return;
                    }
                    menuList[i / 2].stock--;
                    foreach (DataGridViewRow row in itemGridView.Rows)
                    {
                        if(Convert.ToInt32(row.Cells[0].Value) == menuList[i / 2].MenuItemId)
                        {
                            row.Cells[2].Value = Convert.ToInt32(row.Cells[2].Value) + 1;
                            return;
                        }
                    }
                    itemGridView.Rows.Add(new string[] { menuList[i / 2].MenuItemId.ToString(), menuList[i / 2].ProductName, "1"});
                }
            }
        }
        public void BtnOrderAdd_MouseDown(object sender, EventArgs e)
        {
            for (int i = 0; i < menu.Controls.Count; i++)
            {
                if (menu.Controls[i] == sender)
                {
                    MessageBox.Show(menuList[i / 2].Description);
                }
            }
        }

        private void panelOrders_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(39, 39, 39), 10), 14, 20, 498, 81);
        }

        private void viewOrders_Click(object sender, EventArgs e)
        {
            if (itemAddedOrderPnl.Visible)
            {
                viewOrders.Text = "View orders";
                itemAddedOrderPnl.Hide();
            }
            else
            {
                viewOrders.Text = "Close orders";
                itemAddedOrderPnl.Show();
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            itemGridView.Rows.Clear();
        }

        private void itemGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3)
                {
                    if(menuList[menuList.FindIndex(x => x.MenuItemId == Convert.ToInt32(itemGridView.Rows[e.RowIndex].Cells[0].Value))].stock == 0)
                    {
                        itemGridView.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.Red;
                        return;
                    }
                    itemGridView.Rows[e.RowIndex].Cells[2].Value = Convert.ToInt32(itemGridView.Rows[e.RowIndex].Cells[2].Value) + 1;
                    menuList[menuList.FindIndex(x => x.MenuItemId == Convert.ToInt32(itemGridView.Rows[e.RowIndex].Cells[0].Value))].stock -= 1;
                }
                else if (e.ColumnIndex == 4)
                {
                    itemGridView.Rows[e.RowIndex].Cells[2].Value = Convert.ToInt32(itemGridView.Rows[e.RowIndex].Cells[2].Value) - 1;
                    menuList[menuList.FindIndex(x => x.MenuItemId == Convert.ToInt32(itemGridView.Rows[e.RowIndex].Cells[0].Value))].stock += 1;
                    itemGridView.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.Transparent;
                    if (Convert.ToInt32(itemGridView.Rows[e.RowIndex].Cells[2].Value) == 0)
                    {
                        itemGridView.Rows.Remove(itemGridView.Rows[e.RowIndex]);
                    }
                }
            }
        }
        private void itemAddedOrderPnl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(39, 39, 39), 10), 13, 578, 652, 224);
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if(itemGridView.Rows.Count == 1)
            {
                MessageBox.Show("No items added!");
                return;
            }
            ConfirmOrderUI confirm = new ConfirmOrderUI(MessageBoxButtons.YesNo);
            confirm.ShowDialog();
            DialogResult confirmation = confirm.DialogResult;
            if (confirmation == DialogResult.Yes)
            {
                List<OrderItem> itemsForOrder = new List<OrderItem>();
                for(int i = 0; i < itemGridView.Rows.Count - 1; i++)
                {
                    itemsForOrder.Add(new OrderItem
                    {
                        MenuItemID = Convert.ToInt32(itemGridView.Rows[i].Cells[0].Value),
                        Amount = Convert.ToInt32(itemGridView.Rows[i].Cells[2].Value)
                    });
                    MessageBox.Show($"{itemsForOrder[0].MenuItemID}");
                }
                //temporarily creating new reservation in order to test system, will be removed
                Reservation reservation = new Reservation
                {
                    ReservationId = 202,
                    TableId = 4
                };
                OrderService orderService = new OrderService();
                orderService.CreateCompleteOrder(itemsForOrder, reservation, commentsTextBox.Text);
                itemGridView.Rows.Clear();
            }

        }

        private void buttonLunch_Click(object sender, EventArgs e)
        {
            selectLunchMenu = true;
            labelTitleItems.Text = "LUNCH 11:00 - 16:00";
            PanelChooseMenu.Hide();
        }

        private void buttonDinner_Click(object sender, EventArgs e)
        {
            selectLunchMenu = false;
            labelTitleItems.Text = "DINNER 17:00 - 21:00";
            PanelChooseMenu.Hide();
        }

        private void buttonAppetizer_Click(object sender, EventArgs e)
        {
            threeCourseMeal = ThreeCourseMeal.Appatizer;
            FillGridView();
            panelSelectMenu.Hide();
        }

        private void buttonMainCourse_Click(object sender, EventArgs e)
        {
            threeCourseMeal = ThreeCourseMeal.MainCourse;
            FillGridView();
            panelSelectMenu.Hide();
        }

        private void buttonDesserts_Click(object sender, EventArgs e)
        {
            threeCourseMeal = ThreeCourseMeal.Desserts;
            FillGridView();
            panelSelectMenu.Hide();
        }

        private void buttonDrinks_Click(object sender, EventArgs e)
        {
            threeCourseMeal = ThreeCourseMeal.Drinks;
            FillGridView();
            panelSelectMenu.Hide();
        }
    }
}

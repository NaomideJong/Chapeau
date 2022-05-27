
namespace ChapeauUI
{
    partial class OrderUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelItems = new System.Windows.Forms.Panel();
            this.PanelChooseMenu = new System.Windows.Forms.Panel();
            this.labelTable = new System.Windows.Forms.Label();
            this.buttonDinner = new System.Windows.Forms.Button();
            this.buttonLunch = new System.Windows.Forms.Button();
            this.panelSelectMenu = new System.Windows.Forms.Panel();
            this.labelSelectMenu = new System.Windows.Forms.Label();
            this.buttonDrinks = new System.Windows.Forms.Button();
            this.buttonDesserts = new System.Windows.Forms.Button();
            this.buttonMainCourse = new System.Windows.Forms.Button();
            this.buttonAppetizer = new System.Windows.Forms.Button();
            this.itemAddedOrderPnl = new System.Windows.Forms.Panel();
            this.commentsTextBox = new System.Windows.Forms.RichTextBox();
            this.labelCommentsTitle = new System.Windows.Forms.Label();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.viewOrders = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTitleItems = new System.Windows.Forms.Label();
            this.panelItems.SuspendLayout();
            this.PanelChooseMenu.SuspendLayout();
            this.panelSelectMenu.SuspendLayout();
            this.itemAddedOrderPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelItems
            // 
            this.panelItems.BackgroundImage = global::ChapeauUI.Properties.Resources.achtergrond;
            this.panelItems.Controls.Add(this.PanelChooseMenu);
            this.panelItems.Controls.Add(this.panelSelectMenu);
            this.panelItems.Controls.Add(this.itemAddedOrderPnl);
            this.panelItems.Controls.Add(this.viewOrders);
            this.panelItems.Controls.Add(this.menu);
            this.panelItems.Controls.Add(this.labelTitleItems);
            this.panelItems.Location = new System.Drawing.Point(-2, -2);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(681, 1440);
            this.panelItems.TabIndex = 1;
            this.panelItems.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOrders_Paint);
            // 
            // PanelChooseMenu
            // 
            this.PanelChooseMenu.BackgroundImage = global::ChapeauUI.Properties.Resources.achtergrond;
            this.PanelChooseMenu.Controls.Add(this.labelTable);
            this.PanelChooseMenu.Controls.Add(this.buttonDinner);
            this.PanelChooseMenu.Controls.Add(this.buttonLunch);
            this.PanelChooseMenu.Location = new System.Drawing.Point(1, 0);
            this.PanelChooseMenu.Name = "PanelChooseMenu";
            this.PanelChooseMenu.Size = new System.Drawing.Size(681, 1440);
            this.PanelChooseMenu.TabIndex = 5;
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Font = new System.Drawing.Font("Cabin", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTable.Location = new System.Drawing.Point(32, 55);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(215, 63);
            this.labelTable.TabIndex = 1;
            this.labelTable.Text = "TABLE xx :";
            // 
            // buttonDinner
            // 
            this.buttonDinner.BackColor = System.Drawing.Color.Transparent;
            this.buttonDinner.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonDinner.FlatAppearance.BorderSize = 10;
            this.buttonDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDinner.Font = new System.Drawing.Font("Cabin", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonDinner.Location = new System.Drawing.Point(32, 436);
            this.buttonDinner.Margin = new System.Windows.Forms.Padding(60);
            this.buttonDinner.Name = "buttonDinner";
            this.buttonDinner.Size = new System.Drawing.Size(616, 255);
            this.buttonDinner.TabIndex = 0;
            this.buttonDinner.Text = "DINNER";
            this.buttonDinner.UseVisualStyleBackColor = false;
            this.buttonDinner.Click += new System.EventHandler(this.buttonDinner_Click);
            // 
            // buttonLunch
            // 
            this.buttonLunch.BackColor = System.Drawing.Color.Transparent;
            this.buttonLunch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonLunch.FlatAppearance.BorderSize = 10;
            this.buttonLunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLunch.Font = new System.Drawing.Font("Cabin", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLunch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonLunch.Location = new System.Drawing.Point(31, 151);
            this.buttonLunch.Margin = new System.Windows.Forms.Padding(60);
            this.buttonLunch.Name = "buttonLunch";
            this.buttonLunch.Size = new System.Drawing.Size(616, 255);
            this.buttonLunch.TabIndex = 0;
            this.buttonLunch.Text = "LUNCH";
            this.buttonLunch.UseVisualStyleBackColor = false;
            this.buttonLunch.Click += new System.EventHandler(this.buttonLunch_Click);
            // 
            // panelSelectMenu
            // 
            this.panelSelectMenu.BackgroundImage = global::ChapeauUI.Properties.Resources.achtergrond;
            this.panelSelectMenu.Controls.Add(this.labelSelectMenu);
            this.panelSelectMenu.Controls.Add(this.buttonDrinks);
            this.panelSelectMenu.Controls.Add(this.buttonDesserts);
            this.panelSelectMenu.Controls.Add(this.buttonMainCourse);
            this.panelSelectMenu.Controls.Add(this.buttonAppetizer);
            this.panelSelectMenu.Location = new System.Drawing.Point(2, 3);
            this.panelSelectMenu.Name = "panelSelectMenu";
            this.panelSelectMenu.Size = new System.Drawing.Size(681, 1440);
            this.panelSelectMenu.TabIndex = 6;
            // 
            // labelSelectMenu
            // 
            this.labelSelectMenu.AutoSize = true;
            this.labelSelectMenu.Font = new System.Drawing.Font("Cabin", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectMenu.Location = new System.Drawing.Point(30, 64);
            this.labelSelectMenu.Name = "labelSelectMenu";
            this.labelSelectMenu.Size = new System.Drawing.Size(301, 63);
            this.labelSelectMenu.TabIndex = 3;
            this.labelSelectMenu.Text = "SELECT MENU";
            // 
            // buttonDrinks
            // 
            this.buttonDrinks.BackColor = System.Drawing.Color.Transparent;
            this.buttonDrinks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonDrinks.FlatAppearance.BorderSize = 10;
            this.buttonDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrinks.Font = new System.Drawing.Font("Cabin", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDrinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonDrinks.Location = new System.Drawing.Point(30, 1002);
            this.buttonDrinks.Margin = new System.Windows.Forms.Padding(60);
            this.buttonDrinks.Name = "buttonDrinks";
            this.buttonDrinks.Size = new System.Drawing.Size(616, 255);
            this.buttonDrinks.TabIndex = 2;
            this.buttonDrinks.Text = "DRINKS";
            this.buttonDrinks.UseVisualStyleBackColor = false;
            this.buttonDrinks.Click += new System.EventHandler(this.buttonDrinks_Click);
            // 
            // buttonDesserts
            // 
            this.buttonDesserts.BackColor = System.Drawing.Color.Transparent;
            this.buttonDesserts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonDesserts.FlatAppearance.BorderSize = 10;
            this.buttonDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesserts.Font = new System.Drawing.Font("Cabin", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDesserts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonDesserts.Location = new System.Drawing.Point(30, 713);
            this.buttonDesserts.Margin = new System.Windows.Forms.Padding(60);
            this.buttonDesserts.Name = "buttonDesserts";
            this.buttonDesserts.Size = new System.Drawing.Size(616, 255);
            this.buttonDesserts.TabIndex = 1;
            this.buttonDesserts.Text = "DESSERTS";
            this.buttonDesserts.UseVisualStyleBackColor = false;
            this.buttonDesserts.Click += new System.EventHandler(this.buttonDesserts_Click);
            // 
            // buttonMainCourse
            // 
            this.buttonMainCourse.BackColor = System.Drawing.Color.Transparent;
            this.buttonMainCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonMainCourse.FlatAppearance.BorderSize = 10;
            this.buttonMainCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainCourse.Font = new System.Drawing.Font("Cabin", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMainCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonMainCourse.Location = new System.Drawing.Point(30, 433);
            this.buttonMainCourse.Margin = new System.Windows.Forms.Padding(60);
            this.buttonMainCourse.Name = "buttonMainCourse";
            this.buttonMainCourse.Size = new System.Drawing.Size(616, 255);
            this.buttonMainCourse.TabIndex = 0;
            this.buttonMainCourse.Text = "MAIN COURSE";
            this.buttonMainCourse.UseVisualStyleBackColor = false;
            this.buttonMainCourse.Click += new System.EventHandler(this.buttonMainCourse_Click);
            // 
            // buttonAppetizer
            // 
            this.buttonAppetizer.BackColor = System.Drawing.Color.Transparent;
            this.buttonAppetizer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonAppetizer.FlatAppearance.BorderSize = 10;
            this.buttonAppetizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAppetizer.Font = new System.Drawing.Font("Cabin", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAppetizer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonAppetizer.Location = new System.Drawing.Point(31, 151);
            this.buttonAppetizer.Margin = new System.Windows.Forms.Padding(60);
            this.buttonAppetizer.Name = "buttonAppetizer";
            this.buttonAppetizer.Size = new System.Drawing.Size(616, 255);
            this.buttonAppetizer.TabIndex = 0;
            this.buttonAppetizer.Text = "APPETIZERS";
            this.buttonAppetizer.UseVisualStyleBackColor = false;
            this.buttonAppetizer.Click += new System.EventHandler(this.buttonAppetizer_Click);
            // 
            // itemAddedOrderPnl
            // 
            this.itemAddedOrderPnl.AutoScroll = true;
            this.itemAddedOrderPnl.BackgroundImage = global::ChapeauUI.Properties.Resources.achtergrond;
            this.itemAddedOrderPnl.Controls.Add(this.commentsTextBox);
            this.itemAddedOrderPnl.Controls.Add(this.labelCommentsTitle);
            this.itemAddedOrderPnl.Controls.Add(this.itemGridView);
            this.itemAddedOrderPnl.Controls.Add(this.clearAllButton);
            this.itemAddedOrderPnl.Controls.Add(this.buttonCreateOrder);
            this.itemAddedOrderPnl.Location = new System.Drawing.Point(1, 115);
            this.itemAddedOrderPnl.Name = "itemAddedOrderPnl";
            this.itemAddedOrderPnl.Size = new System.Drawing.Size(678, 940);
            this.itemAddedOrderPnl.TabIndex = 4;
            this.itemAddedOrderPnl.Visible = false;
            this.itemAddedOrderPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.itemAddedOrderPnl_Paint);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.commentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentsTextBox.Location = new System.Drawing.Point(31, 588);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(627, 209);
            this.commentsTextBox.TabIndex = 7;
            this.commentsTextBox.Text = "";
            // 
            // labelCommentsTitle
            // 
            this.labelCommentsTitle.AutoSize = true;
            this.labelCommentsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelCommentsTitle.Font = new System.Drawing.Font("Cabin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCommentsTitle.Location = new System.Drawing.Point(10, 539);
            this.labelCommentsTitle.Name = "labelCommentsTitle";
            this.labelCommentsTitle.Size = new System.Drawing.Size(140, 37);
            this.labelCommentsTitle.TabIndex = 5;
            this.labelCommentsTitle.Text = "Comments:";
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Location = new System.Drawing.Point(-1, 6);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.ReadOnly = true;
            this.itemGridView.RowHeadersWidth = 51;
            this.itemGridView.RowTemplate.Height = 29;
            this.itemGridView.Size = new System.Drawing.Size(679, 532);
            this.itemGridView.TabIndex = 4;
            this.itemGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGridView_CellClick);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(463, 825);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(202, 97);
            this.clearAllButton.TabIndex = 1;
            this.clearAllButton.Text = "Clear all";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(31, 825);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(202, 97);
            this.buttonCreateOrder.TabIndex = 8;
            this.buttonCreateOrder.Text = "Create order";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // viewOrders
            // 
            this.viewOrders.Location = new System.Drawing.Point(540, 5);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Size = new System.Drawing.Size(126, 104);
            this.viewOrders.TabIndex = 3;
            this.viewOrders.Text = "View Orders";
            this.viewOrders.UseVisualStyleBackColor = true;
            this.viewOrders.Click += new System.EventHandler(this.viewOrders_Click);
            // 
            // menu
            // 
            this.menu.BackgroundImage = global::ChapeauUI.Properties.Resources.achtergrond;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu.Location = new System.Drawing.Point(0, 115);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(681, 1440);
            this.menu.TabIndex = 2;
            // 
            // labelTitleItems
            // 
            this.labelTitleItems.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleItems.Font = new System.Drawing.Font("Cabin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitleItems.Location = new System.Drawing.Point(14, 20);
            this.labelTitleItems.Name = "labelTitleItems";
            this.labelTitleItems.Padding = new System.Windows.Forms.Padding(20);
            this.labelTitleItems.Size = new System.Drawing.Size(520, 81);
            this.labelTitleItems.TabIndex = 1;
            this.labelTitleItems.Text = "LUNCH 11:00 - 16:00";
            // 
            // OrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(702, 1055);
            this.Controls.Add(this.panelItems);
            this.Name = "OrderUI";
            this.Text = "OrderUI";
            this.panelItems.ResumeLayout(false);
            this.PanelChooseMenu.ResumeLayout(false);
            this.PanelChooseMenu.PerformLayout();
            this.panelSelectMenu.ResumeLayout(false);
            this.panelSelectMenu.PerformLayout();
            this.itemAddedOrderPnl.ResumeLayout(false);
            this.itemAddedOrderPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Label labelTitleItems;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.Button viewOrders;
        private System.Windows.Forms.Panel itemAddedOrderPnl;
        private System.Windows.Forms.RichTextBox commentsTextBox;
        private System.Windows.Forms.Label labelCommentsTitle;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Panel PanelChooseMenu;
        private System.Windows.Forms.Button buttonLunch;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.Button buttonDinner;
        private System.Windows.Forms.Panel panelSelectMenu;
        private System.Windows.Forms.Label labelSelectMenu;
        private System.Windows.Forms.Button buttonDrinks;
        private System.Windows.Forms.Button buttonDesserts;
        private System.Windows.Forms.Button buttonMainCourse;
        private System.Windows.Forms.Button buttonAppetizer;
    }
}
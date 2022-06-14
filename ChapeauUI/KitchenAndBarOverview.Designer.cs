
namespace ChapeauUI
{
    partial class KitchenAndBarOverview
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
            this.components = new System.ComponentModel.Container();
            this.labelKitchen = new System.Windows.Forms.Label();
            this.kitchenListView = new System.Windows.Forms.ListView();
            this.finishedOrderButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelBar = new System.Windows.Forms.Label();
            this.finishedDrinkButton = new System.Windows.Forms.Button();
            this.labelBottomBar = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelTopBar = new System.Windows.Forms.Label();
            this.sortButtonOrder = new System.Windows.Forms.Button();
            this.sortButtonAmount = new System.Windows.Forms.Button();
            this.sortButtonTable = new System.Windows.Forms.Button();
            this.sortButtonDuration = new System.Windows.Forms.Button();
            this.labelLabelSortBy = new System.Windows.Forms.Label();
            this.radioButtonSortForwards = new System.Windows.Forms.RadioButton();
            this.radioButtonSortBackwards = new System.Windows.Forms.RadioButton();
            this.listViewComments = new System.Windows.Forms.ListView();
            this.progressBarUpdate = new System.Windows.Forms.ProgressBar();
            this.sortButtonByAlcoholic = new System.Windows.Forms.Button();
            this.sortButtonOrderID = new System.Windows.Forms.Button();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.SelectAllOnOrderID = new System.Windows.Forms.Button();
            this.titleOrderIdEnter = new System.Windows.Forms.Label();
            this.titleSelectThreeCourseMeal = new System.Windows.Forms.Label();
            this.comboBoxThreeCourseMeal = new System.Windows.Forms.ComboBox();
            this.SelectAllMenuItemType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKitchen
            // 
            this.labelKitchen.AutoSize = true;
            this.labelKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelKitchen.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKitchen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelKitchen.Location = new System.Drawing.Point(13, 9);
            this.labelKitchen.Name = "labelKitchen";
            this.labelKitchen.Size = new System.Drawing.Size(117, 38);
            this.labelKitchen.TabIndex = 0;
            this.labelKitchen.Text = "Kitchen";
            // 
            // kitchenListView
            // 
            this.kitchenListView.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kitchenListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.kitchenListView.FullRowSelect = true;
            this.kitchenListView.HideSelection = false;
            this.kitchenListView.Location = new System.Drawing.Point(13, 79);
            this.kitchenListView.Name = "kitchenListView";
            this.kitchenListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kitchenListView.Size = new System.Drawing.Size(1500, 750);
            this.kitchenListView.TabIndex = 1;
            this.kitchenListView.UseCompatibleStateImageBehavior = false;
            this.kitchenListView.SelectedIndexChanged += new System.EventHandler(this.kitchenListview_SelectedIndexChanged);
            // 
            // finishedOrderButton
            // 
            this.finishedOrderButton.BackColor = System.Drawing.SystemColors.Control;
            this.finishedOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.finishedOrderButton.FlatAppearance.BorderSize = 4;
            this.finishedOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishedOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.finishedOrderButton.Location = new System.Drawing.Point(1313, 845);
            this.finishedOrderButton.Name = "finishedOrderButton";
            this.finishedOrderButton.Size = new System.Drawing.Size(206, 59);
            this.finishedOrderButton.TabIndex = 2;
            this.finishedOrderButton.Text = "Order is ready to be served\r\n";
            this.finishedOrderButton.UseVisualStyleBackColor = false;
            this.finishedOrderButton.Click += new System.EventHandler(this.finishedOrderButton_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonLogOut.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogOut.Location = new System.Drawing.Point(-13, 955);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(165, 85);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "<BACK";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // labelBar
            // 
            this.labelBar.AutoSize = true;
            this.labelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelBar.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBar.Location = new System.Drawing.Point(12, 9);
            this.labelBar.Name = "labelBar";
            this.labelBar.Size = new System.Drawing.Size(62, 38);
            this.labelBar.TabIndex = 5;
            this.labelBar.Text = "Bar";
            // 
            // finishedDrinkButton
            // 
            this.finishedDrinkButton.Location = new System.Drawing.Point(0, 0);
            this.finishedDrinkButton.Name = "finishedDrinkButton";
            this.finishedDrinkButton.Size = new System.Drawing.Size(75, 23);
            this.finishedDrinkButton.TabIndex = 40;
            // 
            // labelBottomBar
            // 
            this.labelBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelBottomBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelBottomBar.Location = new System.Drawing.Point(124, 959);
            this.labelBottomBar.Name = "labelBottomBar";
            this.labelBottomBar.Size = new System.Drawing.Size(1806, 81);
            this.labelBottomBar.TabIndex = 9;
            this.labelBottomBar.Text = "label1";
            // 
            // labelTopBar
            // 
            this.labelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelTopBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelTopBar.Location = new System.Drawing.Point(-13, -5);
            this.labelTopBar.Name = "labelTopBar";
            this.labelTopBar.Size = new System.Drawing.Size(1931, 81);
            this.labelTopBar.TabIndex = 12;
            this.labelTopBar.Text = "labelHeader";
            // 
            // sortButtonOrder
            // 
            this.sortButtonOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sortButtonOrder.FlatAppearance.BorderSize = 4;
            this.sortButtonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButtonOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sortButtonOrder.Location = new System.Drawing.Point(1558, 243);
            this.sortButtonOrder.Name = "sortButtonOrder";
            this.sortButtonOrder.Size = new System.Drawing.Size(126, 63);
            this.sortButtonOrder.TabIndex = 15;
            this.sortButtonOrder.Text = "Order";
            this.sortButtonOrder.UseVisualStyleBackColor = true;
            this.sortButtonOrder.Click += new System.EventHandler(this.sortButtonOrder_Click);
            // 
            // sortButtonAmount
            // 
            this.sortButtonAmount.BackColor = System.Drawing.SystemColors.Control;
            this.sortButtonAmount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sortButtonAmount.FlatAppearance.BorderSize = 4;
            this.sortButtonAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButtonAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sortButtonAmount.Location = new System.Drawing.Point(1558, 347);
            this.sortButtonAmount.Name = "sortButtonAmount";
            this.sortButtonAmount.Size = new System.Drawing.Size(126, 63);
            this.sortButtonAmount.TabIndex = 16;
            this.sortButtonAmount.Text = "Amount of order";
            this.sortButtonAmount.UseVisualStyleBackColor = false;
            this.sortButtonAmount.Click += new System.EventHandler(this.sortButtonAmount_Click);
            // 
            // sortButtonTable
            // 
            this.sortButtonTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sortButtonTable.FlatAppearance.BorderSize = 4;
            this.sortButtonTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButtonTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sortButtonTable.Location = new System.Drawing.Point(1750, 347);
            this.sortButtonTable.Name = "sortButtonTable";
            this.sortButtonTable.Size = new System.Drawing.Size(126, 63);
            this.sortButtonTable.TabIndex = 19;
            this.sortButtonTable.Text = "Table";
            this.sortButtonTable.UseVisualStyleBackColor = true;
            this.sortButtonTable.Click += new System.EventHandler(this.sortButtonTable_Click);
            // 
            // sortButtonDuration
            // 
            this.sortButtonDuration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sortButtonDuration.FlatAppearance.BorderSize = 4;
            this.sortButtonDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButtonDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sortButtonDuration.Location = new System.Drawing.Point(1750, 450);
            this.sortButtonDuration.Name = "sortButtonDuration";
            this.sortButtonDuration.Size = new System.Drawing.Size(126, 63);
            this.sortButtonDuration.TabIndex = 20;
            this.sortButtonDuration.Text = "Duration of Order";
            this.sortButtonDuration.UseVisualStyleBackColor = true;
            this.sortButtonDuration.Click += new System.EventHandler(this.sortButtonDuration_Click);
            // 
            // labelLabelSortBy
            // 
            this.labelLabelSortBy.AutoSize = true;
            this.labelLabelSortBy.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLabelSortBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelLabelSortBy.Location = new System.Drawing.Point(1558, 153);
            this.labelLabelSortBy.Name = "labelLabelSortBy";
            this.labelLabelSortBy.Size = new System.Drawing.Size(112, 38);
            this.labelLabelSortBy.TabIndex = 22;
            this.labelLabelSortBy.Text = "Sort by\r\n";
            // 
            // radioButtonSortForwards
            // 
            this.radioButtonSortForwards.AutoSize = true;
            this.radioButtonSortForwards.Checked = true;
            this.radioButtonSortForwards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.radioButtonSortForwards.Location = new System.Drawing.Point(1558, 536);
            this.radioButtonSortForwards.Name = "radioButtonSortForwards";
            this.radioButtonSortForwards.Size = new System.Drawing.Size(121, 24);
            this.radioButtonSortForwards.TabIndex = 28;
            this.radioButtonSortForwards.TabStop = true;
            this.radioButtonSortForwards.Text = "Sort forwards";
            this.radioButtonSortForwards.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortBackwards
            // 
            this.radioButtonSortBackwards.AutoSize = true;
            this.radioButtonSortBackwards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.radioButtonSortBackwards.Location = new System.Drawing.Point(1750, 536);
            this.radioButtonSortBackwards.Name = "radioButtonSortBackwards";
            this.radioButtonSortBackwards.Size = new System.Drawing.Size(132, 24);
            this.radioButtonSortBackwards.TabIndex = 29;
            this.radioButtonSortBackwards.Text = "Sort backwards\r\n";
            this.radioButtonSortBackwards.UseVisualStyleBackColor = true;
            // 
            // listViewComments
            // 
            this.listViewComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.listViewComments.HideSelection = false;
            this.listViewComments.Location = new System.Drawing.Point(12, 835);
            this.listViewComments.Name = "listViewComments";
            this.listViewComments.Size = new System.Drawing.Size(1295, 121);
            this.listViewComments.TabIndex = 30;
            this.listViewComments.UseCompatibleStateImageBehavior = false;
            // 
            // progressBarUpdate
            // 
            this.progressBarUpdate.BackColor = System.Drawing.Color.White;
            this.progressBarUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.progressBarUpdate.Location = new System.Drawing.Point(13, 75);
            this.progressBarUpdate.Name = "progressBarUpdate";
            this.progressBarUpdate.Size = new System.Drawing.Size(1500, 10);
            this.progressBarUpdate.TabIndex = 31;
            // 
            // sortButtonByAlcoholic
            // 
            this.sortButtonByAlcoholic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sortButtonByAlcoholic.FlatAppearance.BorderSize = 4;
            this.sortButtonByAlcoholic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButtonByAlcoholic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sortButtonByAlcoholic.Location = new System.Drawing.Point(1558, 450);
            this.sortButtonByAlcoholic.Name = "sortButtonByAlcoholic";
            this.sortButtonByAlcoholic.Size = new System.Drawing.Size(126, 63);
            this.sortButtonByAlcoholic.TabIndex = 32;
            this.sortButtonByAlcoholic.Text = "Alcoholic";
            this.sortButtonByAlcoholic.UseVisualStyleBackColor = true;
            this.sortButtonByAlcoholic.Click += new System.EventHandler(this.sortButtonByAlcoholic_Click);
            // 
            // sortButtonOrderID
            // 
            this.sortButtonOrderID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sortButtonOrderID.FlatAppearance.BorderSize = 4;
            this.sortButtonOrderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButtonOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sortButtonOrderID.Location = new System.Drawing.Point(1750, 243);
            this.sortButtonOrderID.Name = "sortButtonOrderID";
            this.sortButtonOrderID.Size = new System.Drawing.Size(126, 63);
            this.sortButtonOrderID.TabIndex = 33;
            this.sortButtonOrderID.Text = "Order ID";
            this.sortButtonOrderID.UseVisualStyleBackColor = true;
            this.sortButtonOrderID.Click += new System.EventHandler(this.sortButtonOrderID_Click);
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(1558, 610);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(318, 25);
            this.textBoxOrderId.TabIndex = 34;
            // 
            // SelectAllOnOrderID
            // 
            this.SelectAllOnOrderID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SelectAllOnOrderID.FlatAppearance.BorderSize = 4;
            this.SelectAllOnOrderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAllOnOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SelectAllOnOrderID.Location = new System.Drawing.Point(1558, 639);
            this.SelectAllOnOrderID.Name = "SelectAllOnOrderID";
            this.SelectAllOnOrderID.Size = new System.Drawing.Size(318, 49);
            this.SelectAllOnOrderID.TabIndex = 35;
            this.SelectAllOnOrderID.Text = "Select all on basis of order ID";
            this.SelectAllOnOrderID.UseVisualStyleBackColor = true;
            this.SelectAllOnOrderID.Click += new System.EventHandler(this.SelectAllOnOrderID_Click);
            // 
            // titleOrderIdEnter
            // 
            this.titleOrderIdEnter.AutoSize = true;
            this.titleOrderIdEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.titleOrderIdEnter.Location = new System.Drawing.Point(1558, 587);
            this.titleOrderIdEnter.Name = "titleOrderIdEnter";
            this.titleOrderIdEnter.Size = new System.Drawing.Size(107, 20);
            this.titleOrderIdEnter.TabIndex = 36;
            this.titleOrderIdEnter.Text = "Enter OrderID:";
            // 
            // titleSelectThreeCourseMeal
            // 
            this.titleSelectThreeCourseMeal.AutoSize = true;
            this.titleSelectThreeCourseMeal.BackColor = System.Drawing.Color.Transparent;
            this.titleSelectThreeCourseMeal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.titleSelectThreeCourseMeal.Location = new System.Drawing.Point(1558, 703);
            this.titleSelectThreeCourseMeal.Name = "titleSelectThreeCourseMeal";
            this.titleSelectThreeCourseMeal.Size = new System.Drawing.Size(88, 20);
            this.titleSelectThreeCourseMeal.TabIndex = 37;
            this.titleSelectThreeCourseMeal.Text = "Select TCM:";
            // 
            // comboBoxThreeCourseMeal
            // 
            this.comboBoxThreeCourseMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThreeCourseMeal.FormattingEnabled = true;
            this.comboBoxThreeCourseMeal.Location = new System.Drawing.Point(1558, 726);
            this.comboBoxThreeCourseMeal.Name = "comboBoxThreeCourseMeal";
            this.comboBoxThreeCourseMeal.Size = new System.Drawing.Size(318, 28);
            this.comboBoxThreeCourseMeal.TabIndex = 38;
            // 
            // SelectAllMenuItemType
            // 
            this.SelectAllMenuItemType.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SelectAllMenuItemType.FlatAppearance.BorderSize = 4;
            this.SelectAllMenuItemType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAllMenuItemType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SelectAllMenuItemType.Location = new System.Drawing.Point(1558, 760);
            this.SelectAllMenuItemType.Name = "SelectAllMenuItemType";
            this.SelectAllMenuItemType.Size = new System.Drawing.Size(318, 49);
            this.SelectAllMenuItemType.TabIndex = 39;
            this.SelectAllMenuItemType.Text = "Select all with specified type of meal";
            this.SelectAllMenuItemType.UseVisualStyleBackColor = true;
            this.SelectAllMenuItemType.Click += new System.EventHandler(this.button1_Click);
            // 
            // KitchenAndBarOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.winebgdesktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.SelectAllMenuItemType);
            this.Controls.Add(this.comboBoxThreeCourseMeal);
            this.Controls.Add(this.titleSelectThreeCourseMeal);
            this.Controls.Add(this.titleOrderIdEnter);
            this.Controls.Add(this.SelectAllOnOrderID);
            this.Controls.Add(this.textBoxOrderId);
            this.Controls.Add(this.sortButtonOrderID);
            this.Controls.Add(this.sortButtonByAlcoholic);
            this.Controls.Add(this.progressBarUpdate);
            this.Controls.Add(this.listViewComments);
            this.Controls.Add(this.radioButtonSortBackwards);
            this.Controls.Add(this.radioButtonSortForwards);
            this.Controls.Add(this.labelLabelSortBy);
            this.Controls.Add(this.sortButtonDuration);
            this.Controls.Add(this.sortButtonTable);
            this.Controls.Add(this.sortButtonAmount);
            this.Controls.Add(this.sortButtonOrder);
            this.Controls.Add(this.labelKitchen);
            this.Controls.Add(this.labelBar);
            this.Controls.Add(this.labelBottomBar);
            this.Controls.Add(this.finishedDrinkButton);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.finishedOrderButton);
            this.Controls.Add(this.kitchenListView);
            this.Controls.Add(this.labelTopBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "KitchenAndBarOverview";
            this.Text = "KitchenOverview";
            this.Load += new System.EventHandler(this.KitchenOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKitchen;
        private System.Windows.Forms.ListView kitchenListView;
        private System.Windows.Forms.Button finishedOrderButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelBar;
        private System.Windows.Forms.Button finishedDrinkButton;
        private System.Windows.Forms.Label labelBottomBar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelTopBar;
        private System.Windows.Forms.Button sortButtonOrder;
        private System.Windows.Forms.Button sortButtonAmount;
        private System.Windows.Forms.Button sortButtonTable;
        private System.Windows.Forms.Button sortButtonDuration;
        private System.Windows.Forms.Label labelLabelSortBy;
        private System.Windows.Forms.RadioButton radioButtonSortForwards;
        private System.Windows.Forms.RadioButton radioButtonSortBackwards;
        private System.Windows.Forms.ListView listViewComments;
        private System.Windows.Forms.ProgressBar progressBarUpdate;
        private System.Windows.Forms.Button sortButtonByAlcoholic;
        private System.Windows.Forms.Button sortButtonOrderID;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.Button SelectAllOnOrderID;
        private System.Windows.Forms.Label titleOrderIdEnter;
        private System.Windows.Forms.Label titleSelectThreeCourseMeal;
        private System.Windows.Forms.ComboBox comboBoxThreeCourseMeal;
        private System.Windows.Forms.Button SelectAllMenuItemType;
    }
}
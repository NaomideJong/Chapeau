﻿
namespace ChapeauUI
{
    partial class BillUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCash = new System.Windows.Forms.Button();
            this.buttonCard = new System.Windows.Forms.Button();
            this.buttonTip = new System.Windows.Forms.Button();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelExVAT = new System.Windows.Forms.Label();
            this.labelInVAT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Button();
            this.billPanel = new System.Windows.Forms.Panel();
            this.topBarLabel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVAT = new System.Windows.Forms.Label();
            this.billGrid = new System.Windows.Forms.DataGridView();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCash
            // 
            this.buttonCash.BackColor = System.Drawing.Color.Transparent;
            this.buttonCash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonCash.FlatAppearance.BorderSize = 10;
            this.buttonCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonCash.Location = new System.Drawing.Point(23, 1137);
            this.buttonCash.Margin = new System.Windows.Forms.Padding(60);
            this.buttonCash.Name = "buttonCash";
            this.buttonCash.Size = new System.Drawing.Size(297, 99);
            this.buttonCash.TabIndex = 5;
            this.buttonCash.Text = "CASH";
            this.buttonCash.UseVisualStyleBackColor = false;
            this.buttonCash.Click += new System.EventHandler(this.buttonCash_Click);
            // 
            // buttonCard
            // 
            this.buttonCard.BackColor = System.Drawing.Color.Transparent;
            this.buttonCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonCard.FlatAppearance.BorderSize = 10;
            this.buttonCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonCard.Location = new System.Drawing.Point(378, 1137);
            this.buttonCard.Margin = new System.Windows.Forms.Padding(60);
            this.buttonCard.Name = "buttonCard";
            this.buttonCard.Size = new System.Drawing.Size(297, 99);
            this.buttonCard.TabIndex = 6;
            this.buttonCard.Text = "CARD";
            this.buttonCard.UseVisualStyleBackColor = false;
            this.buttonCard.Click += new System.EventHandler(this.buttonCard_Click);
            // 
            // buttonTip
            // 
            this.buttonTip.BackColor = System.Drawing.Color.Transparent;
            this.buttonTip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonTip.FlatAppearance.BorderSize = 10;
            this.buttonTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonTip.Location = new System.Drawing.Point(23, 1041);
            this.buttonTip.Margin = new System.Windows.Forms.Padding(60);
            this.buttonTip.Name = "buttonTip";
            this.buttonTip.Size = new System.Drawing.Size(652, 80);
            this.buttonTip.TabIndex = 7;
            this.buttonTip.Text = "ADD TIP";
            this.buttonTip.UseVisualStyleBackColor = false;
            this.buttonTip.Click += new System.EventHandler(this.buttonTip_Click);
            // 
            // labelTip
            // 
            this.labelTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTip.BackColor = System.Drawing.Color.Transparent;
            this.labelTip.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTip.Location = new System.Drawing.Point(471, 855);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(204, 34);
            this.labelTip.TabIndex = 9;
            this.labelTip.Text = "€ 0.00";
            this.labelTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelExVAT
            // 
            this.labelExVAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExVAT.BackColor = System.Drawing.Color.Transparent;
            this.labelExVAT.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExVAT.Location = new System.Drawing.Point(471, 899);
            this.labelExVAT.Name = "labelExVAT";
            this.labelExVAT.Size = new System.Drawing.Size(204, 34);
            this.labelExVAT.TabIndex = 10;
            this.labelExVAT.Text = "€";
            this.labelExVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInVAT
            // 
            this.labelInVAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInVAT.BackColor = System.Drawing.Color.Transparent;
            this.labelInVAT.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInVAT.Location = new System.Drawing.Point(471, 994);
            this.labelInVAT.Name = "labelInVAT";
            this.labelInVAT.Size = new System.Drawing.Size(204, 34);
            this.labelInVAT.TabIndex = 11;
            this.labelInVAT.Text = "€";
            this.labelInVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 994);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "TOTAL INCL VAT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 899);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "TOTAL EXLC VAT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 855);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 34);
            this.label6.TabIndex = 12;
            this.label6.Text = "TIP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.headerLabel.FlatAppearance.BorderSize = 10;
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.headerLabel.Location = new System.Drawing.Point(23, 69);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(60);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(652, 80);
            this.headerLabel.TabIndex = 15;
            this.headerLabel.Text = "BILL TABLE NR";
            this.headerLabel.UseVisualStyleBackColor = false;
            // 
            // billPanel
            // 
            this.billPanel.BackgroundImage = global::ChapeauUI.Properties.Resources.newhandheldbg;
            this.billPanel.Controls.Add(this.topBarLabel);
            this.billPanel.Controls.Add(this.buttonBack);
            this.billPanel.Controls.Add(this.label1);
            this.billPanel.Controls.Add(this.label2);
            this.billPanel.Controls.Add(this.labelVAT);
            this.billPanel.Controls.Add(this.billGrid);
            this.billPanel.Controls.Add(this.headerLabel);
            this.billPanel.Controls.Add(this.label4);
            this.billPanel.Controls.Add(this.label5);
            this.billPanel.Controls.Add(this.label6);
            this.billPanel.Controls.Add(this.labelInVAT);
            this.billPanel.Controls.Add(this.labelExVAT);
            this.billPanel.Controls.Add(this.labelTip);
            this.billPanel.Controls.Add(this.buttonTip);
            this.billPanel.Controls.Add(this.buttonCard);
            this.billPanel.Controls.Add(this.buttonCash);
            this.billPanel.Location = new System.Drawing.Point(0, 0);
            this.billPanel.Name = "billPanel";
            this.billPanel.Size = new System.Drawing.Size(720, 1440);
            this.billPanel.TabIndex = 17;
            // 
            // topBarLabel
            // 
            this.topBarLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.topBarLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarLabel.Location = new System.Drawing.Point(0, 0);
            this.topBarLabel.Name = "topBarLabel";
            this.topBarLabel.Size = new System.Drawing.Size(720, 51);
            this.topBarLabel.TabIndex = 21;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(0, 1369);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(163, 66);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "<BACK";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 947);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "VAT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(0, 1366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(699, 74);
            this.label2.TabIndex = 19;
            this.label2.Text = "emptyString";
            // 
            // labelVAT
            // 
            this.labelVAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVAT.BackColor = System.Drawing.Color.Transparent;
            this.labelVAT.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVAT.Location = new System.Drawing.Point(471, 947);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(204, 34);
            this.labelVAT.TabIndex = 19;
            this.labelVAT.Text = "€";
            this.labelVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // billGrid
            // 
            this.billGrid.AllowUserToAddRows = false;
            this.billGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.billGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.billGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.billGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.billGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.billGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.billGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.billGrid.Location = new System.Drawing.Point(23, 166);
            this.billGrid.MultiSelect = false;
            this.billGrid.Name = "billGrid";
            this.billGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.billGrid.RowHeadersVisible = false;
            this.billGrid.RowHeadersWidth = 51;
            this.billGrid.RowTemplate.Height = 29;
            this.billGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.billGrid.Size = new System.Drawing.Size(652, 655);
            this.billGrid.TabIndex = 17;
            // 
            // description
            // 
            this.description.HeaderText = "";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 125;
            // 
            // gridBill
            // 
            this.gridBill.HeaderText = "";
            this.gridBill.MinimumWidth = 6;
            this.gridBill.Name = "gridBill";
            this.gridBill.ReadOnly = true;
            this.gridBill.Width = 125;
            // 
            // BillUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.winebg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(720, 1102);
            this.Controls.Add(this.billPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillUI";
            this.Text = "BillUI";
            this.billPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCash;
        private System.Windows.Forms.Button buttonCard;
        private System.Windows.Forms.Button buttonTip;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelExVAT;
        private System.Windows.Forms.Label labelInVAT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button headerLabel;
        private System.Windows.Forms.Panel billPanel;
        private System.Windows.Forms.DataGridView billGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label topBarLabel;
    }
}
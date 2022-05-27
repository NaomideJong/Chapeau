
namespace ChapeauUI
{
    partial class OwnerForm
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
            this.newStaffBtn = new System.Windows.Forms.Button();
            this.newStaffPnl = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.createStaffBtn = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phonenumberTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnamTextBox = new System.Windows.Forms.TextBox();
            this.newStaffPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // newStaffBtn
            // 
            this.newStaffBtn.Location = new System.Drawing.Point(13, 13);
            this.newStaffBtn.Name = "newStaffBtn";
            this.newStaffBtn.Size = new System.Drawing.Size(223, 29);
            this.newStaffBtn.TabIndex = 0;
            this.newStaffBtn.Text = "Add new staff member";
            this.newStaffBtn.UseVisualStyleBackColor = true;
            // 
            // newStaffPnl
            // 
            this.newStaffPnl.Controls.Add(this.passwordTextBox);
            this.newStaffPnl.Controls.Add(this.createStaffBtn);
            this.newStaffPnl.Controls.Add(this.emailTextBox);
            this.newStaffPnl.Controls.Add(this.phonenumberTextBox);
            this.newStaffPnl.Controls.Add(this.lastnameTextBox);
            this.newStaffPnl.Controls.Add(this.firstnamTextBox);
            this.newStaffPnl.Location = new System.Drawing.Point(236, 139);
            this.newStaffPnl.Name = "newStaffPnl";
            this.newStaffPnl.Size = new System.Drawing.Size(552, 299);
            this.newStaffPnl.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(4, 140);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(125, 27);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.Text = "password";
            // 
            // createStaffBtn
            // 
            this.createStaffBtn.Location = new System.Drawing.Point(4, 177);
            this.createStaffBtn.Name = "createStaffBtn";
            this.createStaffBtn.Size = new System.Drawing.Size(229, 29);
            this.createStaffBtn.TabIndex = 4;
            this.createStaffBtn.Text = "Create new staff member";
            this.createStaffBtn.UseVisualStyleBackColor = true;
            this.createStaffBtn.Click += new System.EventHandler(this.createStaffBtn_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(4, 106);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(125, 27);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.Text = "email";
            // 
            // phonenumberTextBox
            // 
            this.phonenumberTextBox.Location = new System.Drawing.Point(4, 72);
            this.phonenumberTextBox.Name = "phonenumberTextBox";
            this.phonenumberTextBox.Size = new System.Drawing.Size(125, 27);
            this.phonenumberTextBox.TabIndex = 2;
            this.phonenumberTextBox.Text = "phone";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(4, 38);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(125, 27);
            this.lastnameTextBox.TabIndex = 1;
            this.lastnameTextBox.Text = "lastname";
            // 
            // firstnamTextBox
            // 
            this.firstnamTextBox.Location = new System.Drawing.Point(4, 4);
            this.firstnamTextBox.Name = "firstnamTextBox";
            this.firstnamTextBox.Size = new System.Drawing.Size(125, 27);
            this.firstnamTextBox.TabIndex = 0;
            this.firstnamTextBox.Text = "firstname";
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newStaffPnl);
            this.Controls.Add(this.newStaffBtn);
            this.Name = "OwnerForm";
            this.Text = "OwnerForm";
            this.newStaffPnl.ResumeLayout(false);
            this.newStaffPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newStaffBtn;
        private System.Windows.Forms.Panel newStaffPnl;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox firstnamTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phonenumberTextBox;
        private System.Windows.Forms.Button createStaffBtn;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}
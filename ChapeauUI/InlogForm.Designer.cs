
namespace ChapeauUI
{
    partial class InlogForm
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
            this.IDnummerTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.inlogBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDnummerTextBox
            // 
            this.IDnummerTextBox.Location = new System.Drawing.Point(13, 13);
            this.IDnummerTextBox.Name = "IDnummerTextBox";
            this.IDnummerTextBox.Size = new System.Drawing.Size(125, 27);
            this.IDnummerTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(13, 47);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(125, 27);
            this.passwordTextBox.TabIndex = 1;
            // 
            // inlogBtn
            // 
            this.inlogBtn.Location = new System.Drawing.Point(13, 81);
            this.inlogBtn.Name = "inlogBtn";
            this.inlogBtn.Size = new System.Drawing.Size(94, 29);
            this.inlogBtn.TabIndex = 2;
            this.inlogBtn.Text = "inloggen";
            this.inlogBtn.UseVisualStyleBackColor = true;
            this.inlogBtn.Click += new System.EventHandler(this.inlogBtn_Click);
            // 
            // InlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inlogBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.IDnummerTextBox);
            this.Name = "InlogForm";
            this.Text = "InlogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDnummerTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button inlogBtn;
    }
}

namespace ChapeauUI
{
    partial class ConfirmOrderUI
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.DenyButton = new System.Windows.Forms.Button();
            this.labelOrderConfirmed = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ReturnButton.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Location = new System.Drawing.Point(71, 209);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Padding = new System.Windows.Forms.Padding(5);
            this.ReturnButton.Size = new System.Drawing.Size(511, 82);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "RETURN";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Visible = false;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ConfirmButton.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.Location = new System.Drawing.Point(55, 201);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Padding = new System.Windows.Forms.Padding(5);
            this.ConfirmButton.Size = new System.Drawing.Size(232, 95);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "YES";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // DenyButton
            // 
            this.DenyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.DenyButton.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DenyButton.ForeColor = System.Drawing.Color.White;
            this.DenyButton.Location = new System.Drawing.Point(371, 201);
            this.DenyButton.Name = "DenyButton";
            this.DenyButton.Size = new System.Drawing.Size(229, 95);
            this.DenyButton.TabIndex = 1;
            this.DenyButton.Text = "NO";
            this.DenyButton.UseVisualStyleBackColor = false;
            this.DenyButton.Click += new System.EventHandler(this.DenyButton_Click);
            // 
            // labelOrderConfirmed
            // 
            this.labelOrderConfirmed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.labelOrderConfirmed.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOrderConfirmed.Location = new System.Drawing.Point(32, 26);
            this.labelOrderConfirmed.Name = "labelOrderConfirmed";
            this.labelOrderConfirmed.Size = new System.Drawing.Size(596, 288);
            this.labelOrderConfirmed.TabIndex = 3;
            this.labelOrderConfirmed.Text = "ORDER HAS BEEN SEND";
            this.labelOrderConfirmed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelOrderConfirmed.Visible = false;
            // 
            // labelQuestion
            // 
            this.labelQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.labelQuestion.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuestion.Location = new System.Drawing.Point(28, 17);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(596, 288);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "ENTER QUESTION";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelQuestion.Visible = false;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(102, 176);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(480, 27);
            this.textBoxInput.TabIndex = 5;
            this.textBoxInput.Visible = false;
            // 
            // ConfirmOrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.confirm_order;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 323);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.labelOrderConfirmed);
            this.Controls.Add(this.DenyButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.labelQuestion);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmOrderUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmOrderUI";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button DenyButton;
        private System.Windows.Forms.Label labelOrderConfirmed;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textBoxInput;
    }
}
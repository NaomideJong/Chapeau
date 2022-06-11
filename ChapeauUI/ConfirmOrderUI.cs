using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace ChapeauUI
{
    public partial class ConfirmOrderUI : Form
    {
        public ConfirmOrderUI()
        {
            InitializeComponent();
            ReturnButton.DialogResult = DialogResult.Yes;
            DenyButton.DialogResult = DialogResult.No;
        }
        public ConfirmOrderUI(string question)
        {
            InitializeComponent();
            ConfirmButton.DialogResult = DialogResult.Yes;
            DenyButton.DialogResult = DialogResult.No;
            labelQuestion.Visible = true;
            labelQuestion.Text = question.ToUpper();
        }
        public ConfirmOrderUI(string question, DialogResult dialogResult)
        {
            InitializeComponent();
            switch (dialogResult){
                case DialogResult.OK:
                    labelQuestion.Text = question.ToUpper();
                    labelQuestion.Visible = true;
                    ReturnButton.DialogResult = DialogResult.OK;
                    DenyButton.Hide();
                    ConfirmButton.Hide();
                    ReturnButton.Show();
                    break;
                case DialogResult.None:
                    labelQuestion.Text = question.ToUpper();
                    labelQuestion.Visible = true;
                    DenyButton.DialogResult = DialogResult.No;
                    DenyButton.Text = "CANCEL";
                    DenyButton.Click += new EventHandler(OkAndCancel_Click);
                    ConfirmButton.Text = "OK";
                    ConfirmButton.Click -= ConfirmButton_Click;
                    ConfirmButton.Click += new EventHandler(OkAndCancel_Click);
                    DenyButton.DialogResult = DialogResult.Yes;
                    textBoxInput.Show();
                    break;
            }
        }
        public ConfirmOrderUI(string question, double priceInclVAT)
        {
            InitializeComponent();
            ConfirmButton.DialogResult = DialogResult.Yes;
            DenyButton.DialogResult = DialogResult.No;
            labelQuestion.Visible = true;
            labelQuestion.Text = question.ToUpper();
        }

        public double InputDouble()
        {
            double input = 0;
            if(denied)
            {
                this.Close();
            }
            else
            {
                try
                {
                    try
                    {
                        if (double.Parse(textBoxInput.Text) > 0)
                        {
                            input = double.Parse(textBoxInput.Text);
                        }
                    }
                    catch
                    {
                        throw new Exception("Please enter a number");
                    }
                    if (double.Parse(textBoxInput.Text) <= 0)
                    {
                        throw new Exception("Please fill in a tip above 0");
                    }
                    else if (double.Parse(textBoxInput.Text) <= 0)
                    {
                        throw new Exception("Please fill in a tip above 0");
                    }
                    else
                    {
                        throw new Exception("Please enter a number");
                    }
                }
                catch (Exception ex)
                {
                    ConfirmOrderUI confirmOrder = new ConfirmOrderUI(ex.Message, DialogResult.OK);
                    confirmOrder.ShowDialog();
                }
            }
            return input;
        }
        private void DenyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DenyButton.Visible = false;
            ConfirmButton.Visible = false;
            ReturnButton.Visible = true;
            labelOrderConfirmed.Visible = true;
        }
        private bool denied;
        private void OkAndCancel_Click(object sender, EventArgs e)
        {
            if(sender == DenyButton)
            {
                denied = true;
            }
            this.Close();
        }
    }
}

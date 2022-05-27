using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class ConfirmOrderUI : Form
    {
        public ConfirmOrderUI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SetButtons();
        }
        public ConfirmOrderUI(MessageBoxButtons Ok)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SetButtons();
        }
        private void SetButtons()
        {
            ReturnButton.DialogResult = DialogResult.Yes;
            DenyButton.DialogResult = DialogResult.No;
            
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
            BackgroundImage = Properties.Resources.confirmed_order;
        }
    }
}

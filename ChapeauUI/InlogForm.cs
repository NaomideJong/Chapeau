﻿using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class InlogForm : Form
    {
        public InlogForm()
        {
            InitializeComponent();
        }

        private void inlogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
                StaffService staffService = new StaffService();
                int staffID = int.Parse(IDnummerTextBox.Text);
                string salt = staffService.GetSaltByStaffID(staffID);
                string passwordInput = passwordTextBox.Text;
                string hashedPassword = pwHasher.StringHasher(passwordTextBox.Text, salt).Hash;

                Staff loggedInStaffMemeber = staffService.CheckPassword(staffID, hashedPassword);
                if (staffService.CheckIfWaiter(staffID))
                {
                    this.Hide();
                    TableOverview tableOverview = new TableOverview(loggedInStaffMemeber);
                    tableOverview.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("You cant log in on this device please chance to the desktop.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while logging in: " + ex.Message);
            }
        }
    }
}

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
    public partial class LogInDesktop : Form
    {
        public LogInDesktop()
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
                if (staffService.CheckIfBartender(staffID))
                {
                    BarOverview barOverview = new BarOverview();
                    barOverview.Show();
                    this.Hide();
                }
                else if (staffService.CheckIfChef(staffID))
                {

                }
                else if (staffService.CheckIfOwner(staffID))
                {
                    this.Hide();
                    OwnerForm ownerForm = new OwnerForm();
                    ownerForm.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while logging in: " + ex.Message);
            }
        }
    }
}
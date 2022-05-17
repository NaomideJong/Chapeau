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
    public partial class OwnerForm : Form
    {
        public OwnerForm()
        {
            InitializeComponent();
        }

        private void createStaffBtn_Click(object sender, EventArgs e)
        {
            StaffService staffService = new StaffService();
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            Random random = new Random();
            try
            {
                string firstame = firstnamTextBox.Text;
                string lastname = lastnameTextBox.Text;
                int phonenumber = int.Parse(phonenumberTextBox.Text);
                string email = emailTextBox.Text;
                int salt = random.Next(1, 1000);

                HashWithSaltResult hashedPasswordwithSalt = pwHasher.StringHasher("password", "asdfecf");

                //HashWithSaltResult hashedPasswordwithSalt = pwHasher.StringHasher(passwordTextBox.Text, salt.ToString());
                staffService.AddNewStaffMember(firstame, lastname, phonenumber, email, hashedPasswordwithSalt);
                MessageBox.Show("not logged in " + hashedPasswordwithSalt.Hash + "salt: " + hashedPasswordwithSalt.Salt + "password " + passwordTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong while adding a new user.\n" + ex.Message);
            }
        }
    }
}

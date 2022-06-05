﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class StaffService
    {
        private StaffDao staffDb;

        public StaffService()
        {
            staffDb = new StaffDao();
        }

        public string GetSaltByStaffID(int staffID)
        {
            return staffDb.GetSaltByID(staffID);
        }

        public Staff CheckPassword(int staffID, string hashedPassword)
        {
            return staffDb.CheckPassword(staffID, hashedPassword);
        }

        public void AddNewStaffMember(string firstname, string lastname, int phonenumber, string email, string hashedPassword, string salt)
        {
            staffDb.AddNewStaffMember(firstname, lastname, phonenumber, email, hashedPassword, salt);
        }

        public bool CheckIfBartender(int staffID)
        {
            return staffDb.CheckIfBartender(staffID);
        }
        public bool CheckIfChef(int staffID)
        {
            return staffDb.CheckIfChef(staffID);
        }
        public bool CheckIfOwner(int staffID)
        {
            return staffDb.CheckIfOwner(staffID);
        }
        public bool CheckIfWaiter(int staffID)
        {
            return staffDb.CheckIfWaiter(staffID);
        }

        public List<Staff> GetAllStaffs()
        {
            return staffDb.GetAllStaffs();
        }
    }
}


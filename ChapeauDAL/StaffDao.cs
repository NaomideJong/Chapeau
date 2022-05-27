using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ChapeauModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class StaffDao : BaseDao
    {
        public List<Staff> GetAllStaffs()
        {
            string query = "SELECT staff_ID, firstName, lastName, phoneNumber, emailAdress, salt, password FROM [staff]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public string GetAllSaltByID(int staffID)
        {
            string query = "SELECT salt FROM [staff] WHERE staff_ID = @staffID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@staffID", staffID);
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            try
            {
                return dataTable.Rows[0].Field<string>("SALT").ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("No user found by that name!");
            }
        }

        public Staff CheckPassword(int staffID, string hashedPassword)
        {
            string query = "SELECT * FROM [staff] WHERE staff_ID = @staffID AND [password] = @password";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@staffID", staffID);
            sqlParameters[1] = new SqlParameter("@password", hashedPassword);
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            try
            {
                return ReadTable(dataTable);
            }
            catch (Exception ex)
            {
                throw new Exception("Password and username dont match" + ex);
            }
        }
        public void AddNewStaffMember(string firstname, string lastname, int phonenumber, string email, string hashedPassword, string salt)
        {
            string query = "INSERT INTO [staff] VALUES (@firstname, @lastname, @phonenumber, @email, @salt ,@password);";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@firstname", firstname);
            sqlParameters[1] = new SqlParameter("@lastname", lastname);
            sqlParameters[2] = new SqlParameter("@phonenumber", phonenumber);
            sqlParameters[3] = new SqlParameter("@email", email);
            sqlParameters[4] = new SqlParameter("@salt", salt);
            sqlParameters[5] = new SqlParameter("@password", hashedPassword);
            ExecuteEditQuery(query, sqlParameters);
        }

        public bool CheckIfBartender(int staffID)
        {
            string query = "SELECT * FROM staff JOIN Bartender ON staff.staff_ID = Bartender.bartender_ID WHERE staff_ID = @staffID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@staffID", staffID);
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return dataTable.Rows.Count > 0;
        }
        public bool CheckIfChef(int staffID)
        {
            string query = "SELECT * FROM staff JOIN Chef ON staff.staff_ID = Chef.chef_ID WHERE staff_ID = @staffID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@staffID", staffID);
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return dataTable.Rows.Count > 0;
        }
        public bool CheckIfOwner(int staffID)
        {
            string query = "SELECT * FROM staff JOIN Owner ON staff.staff_ID = Owner.owner_ID WHERE staff_ID = @staffID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@staffID", staffID);
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return dataTable.Rows.Count > 0;
        }
        public bool CheckIfWaiter(int staffID)
        {
            string query = "SELECT * FROM staff JOIN Waiter ON staff.staff_ID = Waiter.waiter_ID WHERE staff_ID = @staffID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@staffID", staffID);
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return dataTable.Rows.Count > 0;
        }

        public List<Staff> ReadTables(DataTable dataTable)
        {
            List<Staff> staffs = new List<Staff>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Staff staff = new Staff()
                {
                    Staff_ID = (int)dr["staff_ID"],
                    firstName = (string)dr["firstName"],
                    lastName = (string)dr["lastName"],
                    phoneNumber = (int)dr["phoneNumber"],
                    emailAdress = (string)dr["emailAdress"],
                    salt = (string)dr["salt"],
                    passWord = (string)dr["password"]
                };
                staffs.Add(staff);
            }
            return staffs;
        }

        private Staff ReadTable(DataTable dataTable)
        {
            Staff staff = new Staff()
            {
                Staff_ID = dataTable.Rows[0].Field<int>("staff_ID"),
                firstName = dataTable.Rows[0].Field<string>("firstName"),
                lastName = dataTable.Rows[0].Field<string>("lastName"),
                phoneNumber = dataTable.Rows[0].Field<int>("phoneNumber"),
                emailAdress = dataTable.Rows[0].Field<string>("emailAdress"),
                salt = dataTable.Rows[0].Field<string>("SALT"),
                passWord = dataTable.Rows[0].Field<string>("password")
            };
            return staff;
        }
    }
}




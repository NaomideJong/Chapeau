﻿using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class ReservationDao : BaseDao
    {
        public void AddNewReservation(string customerFullName, bool isPresent, DateTime reservationTime, int table_ID, string comments, int phoneNumber, string emailAdress)
        {
            string query = "INSERT INTO [Reservation] (customerFullName, isPresent, reservationTime, table_ID, comments, phoneNumber, emailAdress) VALUES (@customerFullName, @isPresent, @reservationTime, 4, @comments, @phoneNumber, @emailAdress);";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@customerFullName", customerFullName);
            sqlParameters[1] = new SqlParameter("@isPresent", isPresent);
            sqlParameters[2] = new SqlParameter("@reservationTime", reservationTime);
            sqlParameters[3] = new SqlParameter("@table_ID", table_ID);
            sqlParameters[4] = new SqlParameter("@comments", comments);
            sqlParameters[5] = new SqlParameter("@phoneNumber", phoneNumber);
            sqlParameters[6] = new SqlParameter("@emailAdress", emailAdress);
            ExecuteEditQuery(query, sqlParameters);
        }

        public Reservation GetActiveReservationByTableID(int tableID)
        {
            string query = "SELECT * FROM [Reservation] WHERE table_ID = @tableID AND isPresent = 1";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableID", tableID);
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public void MarkReservationAsPresent(int reservationID)
        {
            string query = "UPDATE Reservations SET isPresent = 1 WHERE reservation_id = reservationID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@reservationID", reservationID);
        }
        private List<Reservation> ReadTables(DataTable dataTable)
        {
            List<Reservation> reservations = new List<Reservation>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Reservation reservation = new Reservation()
                {
                    ReservationId = (int)dr["reservation_id"],
                    CustomerFullName = (string)dr["customerFullName"],
                    isPresent = (bool)dr["isPresent"],
                    ReservationTime = (DateTime)dr["reservationTime"],
                    TableId = (int)dr["table_ID"],
                    Comments = (string)dr["comments"],
                    PhoneNumber = (int)dr["phoneNumber"],
                    EmailAddress = (string)dr["emailAdress"]
                };
                reservations.Add(reservation);
            }
            return reservations;
        }

        private Reservation ReadTable(DataTable dataTable)
        {
            Reservation reservation = new Reservation()
            {
                ReservationId = dataTable.Rows[0].Field<int>("reservation_id"),
                CustomerFullName = dataTable.Rows[0].Field<string>("customerFullName"),
                isPresent = dataTable.Rows[0].Field<bool>("isPresent"),
                ReservationTime = dataTable.Rows[0].Field <DateTime>("reservationTime"),
                TableId = dataTable.Rows[0].Field<int>("table_ID"),
                Comments = dataTable.Rows[0].Field<string>("comments"),
                PhoneNumber = dataTable.Rows[0].Field<int>("phoneNumber"),
                EmailAddress = dataTable.Rows[0].Field<string>("emailAdress")
            };
            return reservation;
        }
    }
}
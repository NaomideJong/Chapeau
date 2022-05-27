using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class BillDao : BaseDao
    {
        public List<Bill> GetAllBills()
        {
            string query = "SELECT bill_Id, table_Id, staff_ID, totalPriceInclVAT, totalPriceExclVAT, tip, isPaid, discount, currentDate, comments FROM [Bill]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadBillTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddBill(Bill bill)
        {
            string query = "INSERT INTO [Bill] VALUES (@bill_Id, @table_Id, @staff_ID, @totalPriceInclVAT, @totalPriceExclVAT, @totalVAT, @tip, @isPaid, @discount, @currentDate, @comments);";
            SqlParameter[] sqlParameters = new SqlParameter[10];
            sqlParameters[0] = new SqlParameter("@bill_Id", bill.BillID);
            sqlParameters[1] = new SqlParameter("@table_Id", bill.TableID);
            sqlParameters[2] = new SqlParameter("@staff_ID", bill.StaffID);
            sqlParameters[3] = new SqlParameter("@totalPriceInclVAT", bill.TotalPriceInclVAT);
            sqlParameters[4] = new SqlParameter("@totalPriceExclVAT", bill.TotalPriceExclVAT);
            sqlParameters[5] = new SqlParameter("@tip", bill.Tip);
            sqlParameters[6] = new SqlParameter("@isPaid", bill.IsPaid);
            sqlParameters[7] = new SqlParameter("@discount", bill.Discount);
            sqlParameters[8] = new SqlParameter("@currentDate", bill.Date);
            sqlParameters[9] = new SqlParameter("@comments", bill.Comments);
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Bill> ReadBillTables(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bill bill = new Bill()
                {
                    BillID = (int)dr["bill_Id"],
                    TableID = (int)dr["table_Id"],
                    StaffID = (int)dr["staff_ID"],
                    TotalPriceInclVAT = (double)dr["totalPriceInclVAT"],
                    TotalPriceExclVAT = (double)dr["totalPriceExclVAT"],
                    Tip = (double)dr["tip"],
                    IsPaid = (bool)dr["isPaid"],
                    Discount = (double)dr["discount"],
                    Date = (DateTime)dr["currentDate"],
                    Comments = (string)dr["comments"]
                };
                bills.Add(bill);
            }
            return bills;
        }

        public List<OrderItem> GetHighVAT(int reservationId)
        {
            string query = "SELECT oi.menuItem_ID, productName, price, amount FROM Order_Item AS OI" +
            "JOIN[Order] as o ON o.order_id = OI.order_id" +
            "JOIN[menuItem] AS M ON oi.menuItem_ID = m.menuItem_ID" +
            "WHERE o.reservation_Id = @reservationId AND OI.menuItem_ID IN(SELECT MenuItem_Id FROM Drink_Item WHERE isAlcoholic = 0)"+
            "ORDER BY oi.menuItem_ID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@reservationId", reservationId);

            return ReadOrderItemsTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> GetLowVAT(int reservationId)
        {
            string query = "SELECT m.menuItem_ID, m.productName, m.price, oi.amount FROM [MenuItem] AS m" +
            "JOIN [Order_item] AS oi ON m.menuItem_ID = oi.menuItem_ID" +
            "JOIN[Order] AS o ON o.order_id = oi.order_id" +
            "WHERE o.reservation_Id = @reservationId AND OI.menuItem_ID NOT IN(SELECT MenuItem_Id FROM Drink_Item WHERE isAlcoholic = 0)" +
            "ORDER BY oi.menuItem_ID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@reservationId", reservationId);

            return ReadOrderItemsTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> ReadOrderItemsTables(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    MenuItemId = (int)dr["menuItem_ID"],
                    ProductName = (string)dr["productName"],
                    Price = (double)dr["price"],
                    Amount = (int)dr["amount"]
                };

                orderItems.Add(orderItem);
            }
            return orderItems;
        }
    }
}

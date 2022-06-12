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
            return ReadBillsTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddBill(Bill bill)
        {   
            string query = "INSERT INTO [Bill] (table_Id, staff_ID, totalPriceInclVAT, totalPriceExclVAT, " +
            "tip, isPaid, discount, currentDate, comments, paymentMethod) " +
            "VALUES (@table_Id, @staff_ID, @totalPriceInclVAT, @totalPriceExclVAT, " +
            "@tip, @isPaid, @discount, @currentDate, @comments, @paymentMethod);";
            SqlParameter[] sqlParameters = new SqlParameter[10];
            sqlParameters[0] = new SqlParameter("@table_Id", bill.Table.TableID);
            sqlParameters[1] = new SqlParameter("@staff_ID", bill.Table.WaiterID);
            sqlParameters[2] = new SqlParameter("@totalPriceInclVAT", bill.TotalPriceInclVAT);
            sqlParameters[3] = new SqlParameter("@totalPriceExclVAT", bill.TotalPriceExclVAT);
            sqlParameters[4] = new SqlParameter("@tip", bill.Tip);
            sqlParameters[5] = new SqlParameter("@isPaid", bill.IsPaid);
            sqlParameters[6] = new SqlParameter("@discount", bill.Discount);
            sqlParameters[7] = new SqlParameter("@currentDate", bill.Date);
            sqlParameters[8] = new SqlParameter("@comments", bill.Comments);
            sqlParameters[9] = new SqlParameter("@paymentMethod", (int)bill.PaymentMethod);
            ExecuteEditQuery(query, sqlParameters);
        }
       
        public List<Bill> ReadBillsTables(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bill bill = new Bill()
                {
                    BillID = (int)dr["bill_Id"],
                    Table = new Table() { TableID = (int)dr["table_Id"], WaiterID = (int)dr["staff_ID"] },
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
        public void FinishReservation(int reservationId)
        {
            //change reservation isPresent to false
            string query = "UPDATE [Reservation] SET isPresent = 0 " +
            "WHERE reservation_id = @reservationId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@reservationId", reservationId);

            ExecuteEditQuery(query, sqlParameters);
        }

        public List<OrderItem> GetBillItems(int reservationId)
        {
            string query = "SELECT oi.menuItem_ID, productName, price, amount, D.isAlcoholic FROM Order_Item AS OI " +
            "JOIN[Order] as o ON o.order_id = OI.order_id " +
            "JOIN[menuItem] AS M ON oi.menuItem_ID = m.menuItem_ID " +
            "LEFT JOIN[Drink_Item] AS D ON oi.menuItem_ID = D.menuItem_ID " +
            "WHERE o.reservation_Id = @reservationId " +
            "ORDER BY oi.menuItem_ID";
            
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@reservationId", reservationId);

            return ReadOrderItemsTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> ReadOrderItemsTables(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    OrderItem orderItem = new OrderItem()
                    {
                        MenuItem = new MenuItem()
                        {
                            MenuItemId = (int)dr["menuItem_ID"],
                            ProductName = (string)dr["productName"],
                            Price = (double)dr["price"],
                        },
                        Amount = (int)dr["amount"],
                        IsAlcoholic = dr.Field<bool?>("isAlcoholic") ?? false,
                    };
                    orderItems.Add(orderItem);
                }
            }
            return orderItems;
        }
    }
}

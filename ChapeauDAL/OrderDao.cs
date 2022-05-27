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
    public class OrderDao : BaseDao
    {
        public List<Order> GetActiveOrders()
        {
            string query = "SELECT order_id, m.productName, m.[description], o.table_Id, o.comments, o.isFinished FROM [Order] AS o JOIN MenuItem AS m ON o.menuItem_ID = m.menuItem_ID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> activeOrders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["order_Id"],
                    ProductName = (string)dr["productName"],
                    ProductDescription = (string)dr["description"],
                    TableId = (int)dr["table_Id"],
                    Comments = ConvertFromDR<string>(dr["comments"]),
                    IsFinished = (bool)dr["isFinished"]
                };

                activeOrders.Add(order);
            }
            return activeOrders;
        }
        private T ConvertFromDR<T>(object obj)
        {
            if (obj == DBNull.Value)
            {
                return default(T);
            }
            else
            {
                return (T)obj;
            }
        }
        public void CreateCompleteOrder(List<OrderItem> orderedItem, Reservation reservation, string comments)
        {
            string query = "INSERT INTO [Order](reservation_Id, table_Id, isFinished, timePlaced, comments) VALUES (@reservationId, @tableId, 0, @currentTime, @comments);";
            SqlParameter[] sqlParameters = new SqlParameter[4]
            {
                new SqlParameter("@reservationId", reservation.ReservationId),
                new SqlParameter("@tableId", reservation.TableId),
                new SqlParameter("@currentTime", DateTime.Now),
                new SqlParameter("@comments", comments),
            };
            ExecuteEditQuery(query, sqlParameters);
            foreach (OrderItem orderItem in orderedItem)
            {
                query = "INSERT INTO[order_Item](order_id, menuItem_Id, amount) VALUES((SELECT TOP 1 order_id FROM [Order] ORDER BY order_id DESC), @menuItemId, @amount);";
                sqlParameters = new SqlParameter[3]
                {
                     new SqlParameter("@orderId", 7),
                     new SqlParameter("@menuItemId", orderItem.MenuItemID),
                     new SqlParameter("@amount", orderItem.Amount),
                };
                ExecuteEditQuery(query, sqlParameters);
            }
        }
    }
}

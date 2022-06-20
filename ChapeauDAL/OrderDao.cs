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
        public List<Order> GetOrdersForWaiter(int staffID)
        {
            string query = "SELECT order_id, o.table_Id, o.comments, o.isFinished, o.timePlaced FROM [Order] AS o JOIN [Table] AS t ON t.table_ID = o.table_Id WHERE t.Waiter_ID = @staffID AND isFinished = 1 AND isDelivered IS NULL";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@staffID", staffID);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetFoodOrdersForWaiterToDeliver(int staffID)
        {
            string query = "SELECT DISTINCT [Order].order_id, [Order].table_Id, CAST([Order].comments AS VARCHAR(MAX)) AS comments, [Order].isFinished, [Order].timePlaced FROM[order_Item] JOIN MenuItem ON MenuItem.menuItem_ID = [Order_Item].menuItem_ID JOIN[Order] ON[Order].order_id = [Order_Item].order_id JOIN[Table] AS t ON t.table_ID = [Order].table_Id WHERE t.Waiter_ID = @staffID AND isFinished != 1 AND(select count(*) where[Status] = 1) = (select COUNT(*)) AND[order_Item].menuItem_ID NOT in (SELECT menuItem_ID FROM Drink_Item) ORDER BY [order].table_Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@staffID", staffID);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetDrinkOrdersForWaiterToDeliver(int staffID)
        {
            string query = "SELECT DISTINCT [Order].order_id, [Order].table_Id, CAST([Order].comments AS VARCHAR(MAX)) AS comments, [Order].isFinished, [Order].timePlaced FROM[order_Item] JOIN MenuItem ON MenuItem.menuItem_ID = [Order_Item].menuItem_ID JOIN[Order] ON[Order].order_id = [Order_Item].order_id JOIN[Drink_Item] AS d ON d.menuItem_Id = [MenuItem].menuItem_ID JOIN[Table] AS t ON t.table_ID = [Order].table_Id WHERE t.Waiter_ID = @staffID AND isFinished != 1 AND(select count(*) where[Status] = 1) = (select COUNT(*)) ORDER BY [order].table_Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@staffID", staffID);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> GetOngoingFoodOrdersForWaiter(int staffID)
        {
            string query = "SELECT DISTINCT [Order].order_id, [Order].table_Id, CAST([Order].comments AS VARCHAR(MAX)) AS comments, [Order].isFinished, [Order].timePlaced FROM[order_Item] JOIN MenuItem ON MenuItem.menuItem_ID = [Order_Item].menuItem_ID JOIN[Order] ON[Order].order_id = [Order_Item].order_id JOIN[Table] AS t ON t.table_ID = [Order].table_Id WHERE t.Waiter_ID = @staffID AND isFinished != 1 AND(select count(*) where[Status] = 1) != (select COUNT(*)) AND[order_Item].menuItem_ID NOT in (SELECT menuItem_ID FROM Drink_Item) ORDER BY [order].timePlaced";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@staffID", staffID);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetOngoingDrinkOrdersForWaiter(int staffID)
        {
            string query = "SELECT DISTINCT [Order].order_id, [Order].table_Id, CAST([Order].comments AS VARCHAR(MAX)) AS comments, [Order].isFinished, [Order].timePlaced FROM[order_Item] JOIN MenuItem ON MenuItem.menuItem_ID = [Order_Item].menuItem_ID JOIN[Order] ON[Order].order_id = [Order_Item].order_id JOIN[Drink_Item] AS d ON d.menuItem_Id = [MenuItem].menuItem_ID JOIN[Table] AS t ON t.table_ID = [Order].table_Id WHERE t.Waiter_ID = @staffID AND isFinished != 1 AND(select count(*) where[Status] = 1) != (select COUNT(*)) ORDER BY [order].timePlaced";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@staffID", staffID);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetActiveDrinkOrders()
        {
            string query = "SELECT [Order_Item].order_id, [Order_Item].menuItem_ID, [Order_Item].amount, " +
                "[MenuItem].productName, [MenuItem].[description], [Order].comments, [Order_Item].[Status], [order].timePlaced, " +
                "[order].table_Id, [order].table_Id, [Drink_Item].IsAlcoholic FROM[order_Item] JOIN MenuItem ON MenuItem.menuItem_ID = " +
                "[Order_Item].menuItem_ID JOIN [Drink_Item] on [Drink_Item].menuItem_Id = [Order_Item].menuItem_ID " +
                "JOIN[Order] ON[Order].order_id = [Order_Item].order_id WHERE[Order_Item].order_id in (SELECT order_id FROM[order_Item] " +
                "WHERE[Order_Item].Status = 0) AND[order_Item].menuItem_ID IN(select menuItem_ID FROM Drink_Item) AND[Order_Item].Status = 0 AND [order].timePlaced > @DateNow " +
                "ORDER BY[order].timePlaced; ";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                 new SqlParameter("@DateNow", DateTime.Now.Date),
            };
            return ReadTablesDrinkItem(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> GetActiveFoodOrders()
        {
            string query = "SELECT [Order_Item].order_id, [Order_Item].menuItem_ID, [Order_Item].amount, " +
                "[MenuItem].productName, [MenuItem].[description], [Order].comments, [Order_Item].[Status], [order].timePlaced, " +
                "[order].table_Id, [order].table_Id, [MenuItem].[threeCourseMealCode] FROM[order_Item] JOIN MenuItem ON MenuItem.menuItem_ID = [Order_Item].menuItem_ID " +
                "JOIN[Order] ON[Order].order_id = [Order_Item].order_id WHERE[Order_Item].order_id in (SELECT order_id FROM[order_Item] " +
                "WHERE[Order_Item].Status = 0) AND[order_Item].menuItem_ID NOT IN(select menuItem_ID FROM Drink_Item) AND[Order_Item].Status = 0 AND [order].timePlaced > @DateNow " +
                "ORDER BY[order].timePlaced; ";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                 new SqlParameter("@DateNow", DateTime.Now.Date),
            };
            return ReadTablesFoodItem(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> GetDrinkOrdersFromStatusDelivered()
        {
            string query = "SELECT [Order_Item].order_id, [Order_Item].menuItem_ID, [Order_Item].amount, " +
                "[MenuItem].productName, [MenuItem].[description], [Order].comments, [Order_Item].[Status], [order].timePlaced, " +
                "[order].table_Id, [order].table_Id, [Drink_Item].IsAlcoholic FROM[order_Item] JOIN MenuItem ON MenuItem.menuItem_ID = " +
                "[Order_Item].menuItem_ID JOIN [Drink_Item] on [Drink_Item].menuItem_Id = [Order_Item].menuItem_ID " +
                "JOIN[Order] ON[Order].order_id = [Order_Item].order_id WHERE[Order_Item].order_id in (SELECT order_id FROM[order_Item] " +
                "WHERE[Order_Item].Status = 1) AND[order_Item].menuItem_ID IN(select menuItem_ID FROM Drink_Item) AND[Order_Item].Status = 1 AND [order].timePlaced > @DateNow " +
                "ORDER BY[order].timePlaced; ";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                 new SqlParameter("@DateNow", DateTime.Now.Date),
            };
            return ReadTablesDrinkItem(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> GetFoodOrdersFromStatusDelivered()
        {
            string query = "SELECT [Order_Item].order_id, [Order_Item].menuItem_ID, [Order_Item].amount, " +
                "[MenuItem].productName, [MenuItem].[description], [Order].comments, [Order_Item].[Status], [order].timePlaced, " +
                "[order].table_Id, [order].table_Id, [MenuItem].[threeCourseMealCode] FROM[order_Item] JOIN MenuItem ON MenuItem.menuItem_ID = [Order_Item].menuItem_ID " +
                "JOIN[Order] ON[Order].order_id = [Order_Item].order_id WHERE[Order_Item].order_id in (SELECT order_id FROM[order_Item] " +
                "WHERE[Order_Item].Status = 1) AND[order_Item].menuItem_ID NOT IN(select menuItem_ID FROM Drink_Item) AND[Order_Item].Status = 1 AND [order].timePlaced > @DateNow " +
                "ORDER BY[order].timePlaced; ";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                 new SqlParameter("@DateNow", DateTime.Now.Date),
            };
            return ReadTablesFoodItem(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> GetLastOrders()
        {
            string query = "SELECT o.order_id, o.table_Id, o.comments, o.isFinished, MAX(o.timePlaced) AS timePlaced FROM [Order] AS o JOIN [Reservation] AS r ON r.reservation_id = o.reservation_Id WHERE r.IsPresent = 1 AND o.isDelivered IS NULL GROUP BY o.table_Id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        
        public Order GetDrinkOrder(Order order)
        {
            string query = "SELECT [Order_Item].menuItem_ID, [Order_Item].amount, [MenuItem].productName, [MenuItem].description, [MenuItem].ThreeCourseMealCode FROM[order_Item] JOIN MenuItem ON MenuItem.menuItem_ID = [Order_Item].menuItem_ID JOIN[Order] ON[Order].order_id = [Order_Item].order_id JOIN[Drink_Item] AS d ON d.menuItem_Id = [MenuItem].menuItem_ID WHERE[Order_Item].order_id = 20";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            order.OrderItems = ReadTablesOrderItems(ExecuteSelectQuery(query, sqlParameters));
            return order;
        }

        public Order GetOrderItemsForOrder(Order order)
        {
            string query = "SELECT [Order_Item].menuItem_ID, [Order_Item].amount, [MenuItem].productName, [MenuItem].[description], [MenuItem].ThreeCourseMealCode, [order_Item].[Status] FROM[order_Item] JOIN MenuItem ON MenuItem.menuItem_ID = [Order_Item].menuItem_ID JOIN[Order] ON[Order].order_id = [Order_Item].order_id WHERE[Order_Item].order_id = @OrderID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@OrderID", order.OrderId);
            order.OrderItems = ReadTablesOrderItems(ExecuteSelectQuery(query, sqlParameters));
            return order;
        }

        public List<OrderItem> ReadTablesOrderItems(DataTable dataTable)
        {
            List<OrderItem> activeOrders = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {

                OrderItem orderItem = new OrderItem()
                {
                    //Order = new Order() { OrderId = (int)dr["order_Id"], Comments = Convert.ToString(dr["comments"]), IsFinished = (bool)dr["isFinished"], TimePlaced = (DateTime)dr["timePlaced"] },
                    MenuItem = new MenuItem
                    {
                        MenuItemId = (int)dr["menuItem_ID"],
                        ProductName = (string)dr["productName"],
                        //Price = (double)dr["price"],
                        Description = Convert.ToString(dr["description"]),
                        //stock = (int)dr["stock"],
                        MenuItemType = (MenuItemType)dr["ThreeCourseMealCode"]
                    },
                    Amount = (int)dr["amount"],
                    Status = (Status)dr["Status"],
                };
                activeOrders.Add(orderItem);
            }
            return activeOrders;
        }
        public List<Order> ReadTablesFoodItem(DataTable dataTable)
        {
            List<Order> activeOrders = new List<Order>();
            if(dataTable.Rows.Count != 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Order order = new Order()
                    {
                        OrderId = (int)dr["order_Id"],
                        Comments = Convert.ToString(dr["comments"]),
                        TimePlaced = (DateTime)dr["timePlaced"],
                        TableId = (int)dr["table_Id"],
                        OrderItems = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                        MenuItem = new MenuItem
                            {
                                MenuItemId = (int)dr["menuItem_ID"],
                                ProductName = (string)dr["productName"],
                                Description = Convert.ToString(dr["description"]),
                                MenuItemType = (MenuItemType)dr["threeCourseMealCode"]
                            },
                        Amount = (int)dr["amount"],
                        Status = (Status)dr["status"],
                        }

                    }
                    };
                    activeOrders.Add(order);
                }
            }

            return activeOrders;
        }
        public List<Order> ReadTablesDrinkItem(DataTable dataTable)
        {
            List<Order> activeOrders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["order_Id"],
                    Comments = Convert.ToString(dr["comments"]),
                    TimePlaced = (DateTime)dr["timePlaced"],
                    TableId = (int)dr["table_Id"],
                    OrderItems = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                        MenuItem = new MenuItem
                            {
                                MenuItemId = (int)dr["menuItem_ID"],
                                ProductName = (string)dr["productName"],
                                Description = Convert.ToString(dr["description"]),
                            },
                        Amount = (int)dr["amount"],
                        Status = (Status)dr["status"],
                        IsAlcoholic = (bool?)dr["IsAlcoholic"],
                        }

                    }
                };
                activeOrders.Add(order);
            }
            return activeOrders;
        }
        public List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> activeOrders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["order_Id"],

                    //MenuItem = new MenuItem() { ProductName = (string)dr["productName"], Description = (string)dr["description"] },
                    TableId = (int)dr["table_Id"],
                    Comments = Convert.ToString(dr["comments"]),
                    TimePlaced = (DateTime)dr["timePlaced"]
                    
                };

                activeOrders.Add(order);
            }
            return activeOrders;
        }
        public void UpdateStateIsFinished(Order order)
        {
            string query = $"UPDATE [Order_Item] SET Status=@Status WHERE order_id=@order_id AND menuItem_Id=@menuItem_id";
            SqlParameter[] sqlParameters = new SqlParameter[3] {
            new SqlParameter("@order_id", order.OrderId),
            new SqlParameter("@menuItem_ID", order.OrderItems[0].MenuItem.MenuItemId),
            new SqlParameter("@status", order.OrderItems[0].Status),
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateStateIsdelivered(int orderID)
        {
            string query = $"UPDATE [Order] SET IsDelivered=1 WHERE order_Id=@orderID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderID", orderID);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateStateIsFinished(int orderID)
        {
            string query = $"UPDATE [Order] SET[isFinished] = 1 WHERE order_id = @orderID AND (select count(*) FROM Order_Item WHERE order_id = 20 AND[Status] = 2) = (select COUNT(*)FROM Order_Item WHERE order_id = 20)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderID", orderID);
            ExecuteEditQuery(query, sqlParameters);
        }


        public void CreateCompleteOrder(Order order)
        {
            string query = "INSERT INTO [Order](reservation_Id, table_Id, isFinished, timePlaced, comments) VALUES (@reservationId, @tableId, 0, @currentTime, @comments);";
            SqlParameter[] sqlParameters = new SqlParameter[4]
            {
                new SqlParameter("@reservationId", order.Reservation.ReservationId),
                new SqlParameter("@tableId", order.Reservation.TableId),
                new SqlParameter("@currentTime", DateTime.Now),
                new SqlParameter("@comments", order.Comments),
            };
            ExecuteEditQuery(query, sqlParameters);
            foreach (OrderItem orderItem in order.OrderItems)
            {
                query = "INSERT INTO[order_Item](order_id, menuItem_Id, amount, status) VALUES((SELECT TOP 1 order_id FROM [Order] ORDER BY order_id DESC), @menuItemId, @amount, 0);" +
                    "UPDATE [menuItem] SET [stock] = [stock] - @amount WHERE [menuItem_ID] = @menuItemId;" +
                    "UPDATE [Table] SET [Waiter_id] = @staffId WHERE [table_ID] = @tableId;";
                sqlParameters = new SqlParameter[5]
                {
                     new SqlParameter("@orderId", 7),
                     new SqlParameter("@menuItemId", orderItem.MenuItem.MenuItemId),
                     new SqlParameter("@amount", orderItem.Amount),
                     new SqlParameter("@staffId", order.StaffId),
                     new SqlParameter("@tableId", order.Reservation.TableId),
                };
                ExecuteEditQuery(query, sqlParameters);
            }
        }
    }
}
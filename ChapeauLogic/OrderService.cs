using System;
using System.Collections.Generic;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderService
    {

        OrderDao orderDao;

        public OrderService()
        {
            orderDao = new OrderDao();
        }

        public List<Order> GetActiveOrders()
        {
            return orderDao.GetActiveOrders();
        }
        public void CreateCompleteOrder(List<OrderItem> orderedItem, Reservation reservation, string comments)
        {
            orderDao.CreateCompleteOrder(orderedItem, reservation, comments);
        }
    }
}


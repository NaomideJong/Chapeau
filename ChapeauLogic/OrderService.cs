﻿using System;
using System.Collections.Generic;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderService
    {

        private OrderDao orderDao;
        public OrderService()
        {
            orderDao = new OrderDao();
        }
        public List<OrderItem> GetActiveDrinkOrders()
        {
            return orderDao.GetActiveDrinkOrders();
        }
        public List<OrderItem> GetActiveFoodOrders()
        {
            return orderDao.GetActiveFoodOrders();
        }
        public void GetUpdateStateIsFinished(bool isFinished)
        {
            orderDao.UpdateStateIsFinished(isFinished);
        }//add een orderitem update
        public void CreateCompleteOrder(List<OrderItem> orderedItem, Reservation reservation, string comments)
        {
            orderDao.CreateCompleteOrder(orderedItem, reservation, comments);
        }
    }
}


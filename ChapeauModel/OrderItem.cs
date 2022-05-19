﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ReservationId { get; set; }
        /*public string ProductName { get; set; }
        public string ProductDescription { get; set; }*/
        public int TableId { get; set; }
        public string Comments { get; set; }
        public bool IsFinished { get; set; }
        public DateTime TimePlaced { get; set; }
    }
}
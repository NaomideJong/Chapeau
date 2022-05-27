using System;

namespace ChapeauModel
{
	public class OrderItem
	{
		public int MenuItemId { get; set; }
		public string ProductName { get; set; }
		public double Price { get; set; }
		public int Amount { get; set; }
    public int OrderId { get; set; }
	}
}


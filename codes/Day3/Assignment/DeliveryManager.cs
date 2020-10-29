using System;
using System.Collections.Generic;
using OrderProcessing;
using CRM;
namespace OrderProcessing {
	public class DeliveryManager:Manager {
		public DeliveryManager () { }
		

		public List<Order> orders { get; set; }

		public DeliveryManager (List<Order> orders)
		{
			this.orders = orders;
		}

		public string insertOrder (Order order)
		{
			 this.orders.Add (order); 
			
			if (this.orders != null) return "order added"; else return "error";
		}

		public static void updateOrder ()
		{
		}

		public string deleteOrder (Order order)
		{
			if (this.orders != null) {this.orders.Remove (order); return "deleted successfully"; } else return "error";
		}

		public List<Order> getOrdersByCustomerId (string userid)
		{
			List<Order> orders = new List<Order> ();
			foreach (WorkOrder workOrder in this.orders) { if (workOrder.Vendor == userid) { orders.Add (workOrder); } }
			return orders;
		}

		public Order getOrderById (int orderid)
		{
			Order order1 = new Order ();
			foreach (Order order in this.orders) { if (order.orderId == orderid) order1 = order; else return null; }
			return order1;
		}


		public List<Order> getAllOrder ()
		{
			List<Order> Orders = new List<Order> ();
			foreach (WorkOrder workOrder in this.orders) { Orders.Add (workOrder); }
			return Orders;
		}

		public override string ToString ()
		{
			return " " + this.orders;
		}
	}
	
}

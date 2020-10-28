using System;
using System.Collections.Generic;
using OrderProcessing;
using CRM;
namespace OrderProcessing {
	public class OrderProcess {

		public List<Order> orders { get; set; }

		public OrderProcess ()
		{

			this.orders = new List<Order> ();
		}


		public String insertOrder (Order order)
		{
			orders.Add (order);
			if (orders != null)
				return "order added";
			else
				return "error";

		}

		public static void updateOrder ()
		{


		}

		public string deleteOrder (Order order)
		{
			if (order != null) { orders.Remove (order); return "deleted successfully"; } else return "error";

		}

		public List<Order> getOrdersByCustomerId (int userid)
		{
			//Customer customer = new Customer();

			List<Order> orders = new List<Order> ();

			foreach (Order order in this.orders) {

				if (order.customer.id == userid) {
					orders.Add (order);
				}
				

			}


			return orders;
		}

		public Order getOrderById (int orderid)
		{
			Order order1 = new Order ();
			foreach (Order order in this.orders) {


				if (order.orderId == orderid)
					order1 = order;
				else
					return null;
			}
			return order1;
		}


		public List<Order> getAllOrder ()
		{

			List<Order> orders = new List<Order> ();
			foreach (Order order in this.orders) { orders.Add (order); }

			return orders;

		}

		public override string ToString ()
		{
			return " " + this.orders;
		}

		
	}
}



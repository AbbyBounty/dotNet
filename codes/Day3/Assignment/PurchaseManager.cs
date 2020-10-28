using System;
using System.Collections.Generic;
using OrderProcessing;
using CRM;
namespace OrderProcessing {
	public class PurchaseManager : Manager {

		public List<PurchaseOrder> orders { get; set; }

		public PurchaseManager ()
		{
			this.orders = new List<PurchaseOrder> ();
		}


		public string insertOrder (PurchaseOrder order)
		{
			orders.Add (order);
			if (orders != null) return "order added"; else return "error";
		}

		public static void updateOrder ()
		{ }


		public string deleteOrder (PurchaseOrder order)
		{
			if (order != null) { orders.Remove (order); return "deleted successfully"; } else return "error";
		}

		public List<PurchaseOrder> getOrdersByCustomerId (int userid)
		{
			List<PurchaseOrder> orders = new List<PurchaseOrder> ();

			foreach (PurchaseOrder order in this.orders) {
				if (order.customer.id == userid) {
					orders.Add (order);
				}
			}
			return orders;
		}

		public PurchaseOrder getOrderById (int orderid)
		{
			PurchaseOrder order1 = new PurchaseOrder ();
			foreach (PurchaseOrder order in this.orders) {
				if (order.orderId == orderid)
					order1 = order;
				else
					return null;
			}
			return order1;
		}


		public List<PurchaseOrder> getAllOrder ()
		{
			List<PurchaseOrder> orders = new List<PurchaseOrder> ();
			foreach (PurchaseOrder order in this.orders) { orders.Add (order); }
			return orders;
		}

		public override string ToString ()
		{
			return " " + this.orders;
		}


	}
}



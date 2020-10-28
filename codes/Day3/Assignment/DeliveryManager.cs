using System;
using System.Collections.Generic;
using OrderProcessing;
using CRM;
namespace OrderProcessing {
	public class DeliveryManager:Manager {
		public DeliveryManager () { }
		

			public List<PurchaseOrder> purchaseOrders { get; set; }

		public DeliveryManager (List<PurchaseOrder> orders)
		{
			this.purchaseOrders = orders;
		}

		public String insertOrder (PurchaseOrder purchaseOrder)
		{
			this.purchaseOrders.Add (purchaseOrder);
			if (this.purchaseOrders != null)
				return "order added";
			else
				return "error";

		}

		public static void updateOrder ()
		{


		}

		public string deleteOrder (PurchaseOrder purchaseOrder)
		{
			if (this.purchaseOrders != null) {this.purchaseOrders.Remove (purchaseOrder); return "deleted successfully"; } else return "error";

		}

		public List<PurchaseOrder> getOrdersByCustomerId (int userid)
		{
			//Customer customer = new Customer();

			List<PurchaseOrder> purchaseOrders = new List<PurchaseOrder> ();

			foreach (PurchaseOrder purchaseOrder in this.purchaseOrders) {

				if (purchaseOrder.customer.id == userid) {
					purchaseOrders.Add (purchaseOrder);
				}


			}


			return purchaseOrders;
		}

		public PurchaseOrder getOrderById (int orderid)
		{
			PurchaseOrder order1 = new PurchaseOrder ();
			foreach (PurchaseOrder purchaseOrder in this.purchaseOrders) {


				if (purchaseOrder.orderId == orderid)
					order1 = purchaseOrder;
				else
					return null;
			}
			return order1;
		}


		public List<PurchaseOrder> getAllOrder ()
		{

			List<PurchaseOrder> purchaseOrders = new List<PurchaseOrder> ();
			foreach (PurchaseOrder purchaseOrder in this.purchaseOrders) { purchaseOrders.Add (purchaseOrder); }

			return purchaseOrders;

		}

		public override string ToString ()
		{
			return " " + this.orders;
		}
	}
	
}

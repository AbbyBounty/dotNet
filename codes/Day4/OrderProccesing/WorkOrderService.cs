using System;

using System.Collections.Generic;
using OrderProcessing;
using CRM;
namespace OrderProcessing {
	public class WorkOrderService : IorderService {
		DeliveryManager deliveryManager = new DeliveryManager ();

		public WorkOrderService () { }

		public void Approve ()
		{
			throw new NotImplementedException ();
		}

		public bool Cancle (Order order)
		{
			this.deliveryManager.deleteOrder (order);
			if (this.deliveryManager!= null) { return true; } else { return false; }
		}

		public bool Create (Order order)
		{
			this.deliveryManager.insertOrder (order);
			if (this.deliveryManager != null) { return true; } else { return false; }
		}

		public Order getOrder (int id)
		{
			return deliveryManager.getOrderById (id);
		}

		public List<Order> getOrders ()
		{
			List<Order> orders = new List<Order> ();

			//orders =  (PurchaseOrder)purchaseManager.getAllOrder ();

			return orders;
		}

		public bool Process (Order order)
		{
			return true;
		}

		public bool Update (Order order)
		{
			return true;

		}

	}
}

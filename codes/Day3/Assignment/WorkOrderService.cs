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
			WorkOrder workOrder = (WorkOrder)order;
			if (this.deliveryManager.deleteOrder (workOrder) != null) { return true; } else { return false; }
		}

		public bool Create (Order order)
		{
			WorkOrder workOrder = (WorkOrder)order;
			if (this.deliveryManager.insertOrder (workOrder) != null) { return true; } else { return false; }
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

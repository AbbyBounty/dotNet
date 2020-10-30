using System;

using System.Collections.Generic;
using OrderProcessing;
using CRM;
namespace OrderProcessing {
	public class PurchaseOrderService : IorderService {
		PurchaseManager purchaseManager = new PurchaseManager ();

		public PurchaseOrderService () { }

		public void Approve ()
		{
			throw new NotImplementedException ();
		}

		public bool Cancle (Order order)
		{
			PurchaseOrder purchaseOrder = (PurchaseOrder)order;
			if (this.purchaseManager.deleteOrder (purchaseOrder) != null) { return true; } else { return false; }
		}

		public bool Create (Order order)
		{
			
			if (this.purchaseManager.insertOrder (order) != null) { return true; } else { return false; }
		}

		public Order getOrder (int id)
		{
			return purchaseManager.getOrderById (id);
		}

		public List<Order> getOrders ()
		{
			List<Order> orders =new List<Order>();

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

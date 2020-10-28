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

		public bool Cancle (PurchaseOrder purchaseManager)
		{
			if (this.purchaseManager.deleteOrder (purchaseManager) != null) { return true; } else { return false; }
		}

		public bool Create (PurchaseOrder purchaseManager)
		{
			if (this.purchaseManager.insertOrder (purchaseManager) != null) { return true; } else { return false; }
		}

		public PurchaseOrder getOrder (int id)
		{
			return purchaseManager.getOrderById (id);
		}

		public List<PurchaseOrder> getOrders ()
		{
			return purchaseManager.getAllOrder ();
		}

		public bool Process (PurchaseOrder order)
		{
			return true;
		}

		public bool Update (PurchaseOrder order)
		{
			return true;

		}
	}
}

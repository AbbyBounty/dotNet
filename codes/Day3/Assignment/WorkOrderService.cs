using System;

using System.Collections.Generic;
using OrderProcessing;
using CRM;
namespace OrderProcessing {
	public class WorkOrderService : IorderService {
		public void Approve ()
		{
			throw new NotImplementedException ();
		}

		public bool Cancle (PurchaseOrder order)
		{
			throw new NotImplementedException ();
		}

		public bool Create (PurchaseOrder order)
		{
			throw new NotImplementedException ();
		}

		public PurchaseOrder getOrder (int id)
		{
			throw new NotImplementedException ();
		}

		public List<PurchaseOrder> getOrders ()
		{
			throw new NotImplementedException ();
		}

		public bool Process (PurchaseOrder order)
		{
			throw new NotImplementedException ();
		}

		public bool Update (PurchaseOrder order)
		{
			throw new NotImplementedException ();
		}
	}
}

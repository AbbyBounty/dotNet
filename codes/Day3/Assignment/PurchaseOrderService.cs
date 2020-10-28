using System;

using System.Collections.Generic;
using OrderProcessing;
using CRM;
namespace OrderProcessing {
	public class PurchaseOrderService : IorderService {
		OrderProcess orderProcess = new OrderProcess ();

		public PurchaseOrderService () { }

		public void Approve ()
		{
			throw new NotImplementedException ();
		}

		public bool Cancle (Order order)
		{
			if (orderProcess.deleteOrder (order) != null) { return true; } else { return false; }
		}

		public bool Create (Order order)
		{
			if (orderProcess.insertOrder (order) != null) { return true; } else { return false; }
		}

		public Order getOrder (int id)
		{
			return orderProcess.getOrderById (id);
		}

		public List<Order> getOrders ()
		{
			return orderProcess.getAllOrder ();
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

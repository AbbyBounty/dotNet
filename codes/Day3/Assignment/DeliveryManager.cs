using System;
using System.Collections.Generic;
using OrderProcessing;
using CRM;
namespace OrderProcessing {
	public class DeliveryManager:Manager {
		public DeliveryManager () { }
		

		public List<WorkOrder> workOrders { get; set; }

		public DeliveryManager (List<WorkOrder> workOrders)
		{
			this.workOrders = workOrders;
		}

		public string insertOrder (WorkOrder workOrders)
		{
			 this.workOrders.Add (workOrders); 
			
			if (this.workOrders != null) return "order added"; else return "error";
		}

		public static void updateOrder ()
		{
		}

		public string deleteOrder (WorkOrder workOrder)
		{
			if (this.workOrders != null) {this.workOrders.Remove (workOrder); return "deleted successfully"; } else return "error";
		}

		public List<WorkOrder> getOrdersByCustomerId (string userid)
		{
			List<WorkOrder> workOrders = new List<WorkOrder> ();
			foreach (WorkOrder workOrder in this.workOrders) { if (workOrder.Vendor == userid) { workOrders.Add (workOrder); } }
			return workOrders;
		}

		public WorkOrder getOrderById (int orderid)
		{
			WorkOrder order1 = new WorkOrder ();
			foreach (WorkOrder workOrder in this.workOrders) { if (workOrder.orderId == orderid) order1 = workOrder; else return null; }
			return order1;
		}


		public List<WorkOrder> getAllOrder ()
		{
			List<WorkOrder> workOrders = new List<WorkOrder> ();
			foreach (WorkOrder purchaseOrder in this.workOrders) { workOrders.Add (purchaseOrder); }
			return workOrders;
		}

		public override string ToString ()
		{
			return " " + this.workOrders;
		}
	}
	
}

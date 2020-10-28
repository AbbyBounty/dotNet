using System;
using OrderProcessing;
using CRM;
using System.Collections.Generic;
using ShoppingCart;
using Cataloge;

namespace OrderProcessing {
	public class WorkOrder:PurchaseOrder {


		public string Vendor { get; set; }
		public string Description { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Status { get; set; }
		public int priority { get; set; }
		public List<Job> jobs { get; set; }

		public WorkOrder ()
		{
		
		}
	}
}

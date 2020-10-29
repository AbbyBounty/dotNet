using System;
using OrderProcessing;
using CRM;
using System.Collections.Generic;
using ShoppingCart;
using Cataloge;

namespace OrderProcessing {
	public class WorkOrder:Order {


		public string Vendor { get; set; }
		public string Description { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Status { get; set; }
		public int priority { get; set; }
		public List<Job> jobs { get; set; }

		public WorkOrder (string vendor, string description, DateTime startDate, DateTime endDate, string status, int priority, List<Job> jobs)
		{
			Vendor = vendor;
			Description = description;
			StartDate = startDate;
			EndDate = endDate;
			Status = status;
			this.priority = priority;
			this.jobs = jobs;
		}

		public WorkOrder ()
		{
		
		}

		public override string ToString ()
		{
			return this.Vendor + " " + this.Description + " " + this.Status + " " + this.EndDate + " " + this.Status + " " + this.priority + " " + this.jobs;
		}
	}
}

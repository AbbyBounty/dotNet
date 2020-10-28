using System;
using OrderProcessing;
using CRM;
using System.Collections.Generic;
using ShoppingCart;
using Cataloge;

namespace OrderProcessing {

	


	public class Job {
		public int id { get; set; }
		public string title { get; set; }
		public string Description { get; set; }
		public int Duration { get; set; }
		public string Status { get; set; }

		public Job (int id, string title, string description, int duration, string status)
		{
			this.id = id;
			this.title = title;
			Description = description;
			Duration = duration;
			Status = status;
		}

		public Job ()
		{
		}

		public override string ToString ()
		{
			return this.id + " " + this.Description + " " + this.title + " " + this.Duration + " " + this.Status;
		}
	}
}
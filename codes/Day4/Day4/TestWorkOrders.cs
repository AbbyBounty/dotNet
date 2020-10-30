using System;
using OrderProcessing;
using CRM;
using System.Collections.Generic;
using ShoppingCart;
using Cataloge;
using System.Globalization;

namespace OrderTest {
	public class TestWorkOrders {


		static void Main (string [] args)
		{

			

			
			DateTime startTime = new DateTime (1999, 3, 4,1,2,3);
			DateTime endTime = new DateTime (1999, 3, 4,1,2,3);


			List<Job> jobs = new List<Job> () {
				new Job(11,"orderdispatch","order is about to distapatch",120,"Active"),
				new Job(11,"orderdispatch","order is about to distapatch",120,"Active"),
				new Job(11,"orderdispatch","order is about to distapatch",120,"Active"),
				new Job(11,"orderdispatch","order is about to distapatch",120,"Active")
			};

			WorkOrder workOrder = new WorkOrder ("Courier","This is Courier service",startTime,endTime,"Active",1,jobs);

			IorderService workOrderService = new WorkOrderService ();

			//insert
			Console.WriteLine(workOrderService.Create (workOrder));


			//getorderbyid
			Console.WriteLine (workOrderService.getOrder (11));

			////get all order
			List<Order> orders = workOrderService.getOrders ();
			foreach (WorkOrder workOrderlist in orders) {
				foreach (Job job in workOrderlist.jobs) { Console.WriteLine (job); }
			}

			//delete order
			Console.WriteLine (workOrderService.Cancle (workOrder));

		}
	}
}
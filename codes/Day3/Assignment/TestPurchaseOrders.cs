using System;
using OrderProcessing;
using CRM;
using System.Collections.Generic;
using ShoppingCart;
using Cataloge;

namespace OrderTest {
	public class TestPurchaseOrders {


		//static void Main (string [] args)
		//{

		//	//OrderProcess orderProcess = new OrderProcess ();

			
		//	DateTime dateTime = new DateTime (1999, 3, 4);
		//	Customer customer = new Customer (1, "steve", "jobs", "steve@gmail.com", "98989767");
		//	List<Item> items = new List<Item> () { new Item(1, new Product(1, "java", "this is java book", 2, 4), 3),
		//				  new Item(2, new Product(2, "C", "this is best  C book", 2, 4), 3),
		//				  new Item(3, new Product(3, "OS", "this is best OS book", 2, 4), 3)
		//			       };

		//	PurchaseOrder order = new PurchaseOrder (12,dateTime,customer,items);


		//	//insert Order
		//	//Console.WriteLine (orderProcess.insertOrder (order));

		//	//delete order
		//	//Console.WriteLine(orderProcess.deleteOrder(order));


		//	//get all order
		//	//List<Order> orders = orderProcess.getAllOrder ();
		//	//foreach (Order orderlist in orders) {
		//	//	Console.WriteLine (orderlist);
		//	//	foreach (Item itemlist in orderlist.Items) { Console.WriteLine (itemlist); }
		//	//}


		//	//getOrderById
		//	//Order orders = orderProcess.getOrderById (12);
		//	//Console.WriteLine (orders);

		//	//getOrdersByCustomerId
		//	//List<Order> OrdersByCustomerId = orderProcess.getOrdersByCustomerId (1);
		//	//foreach (Order orderlist in OrdersByCustomerId) {
		//	//	Console.WriteLine (orderlist);
		//	//	foreach (Item itemlist in orderlist.Items) { Console.WriteLine (itemlist); }
		//	//}



		//	IorderService purchaseOrderService = new PurchaseOrderService ();

		//	//insert
		//	Console.WriteLine(purchaseOrderService.Create (order));

			
		//	//getorderbyid
		//	Console.WriteLine( purchaseOrderService.getOrder (12));

		//	//get all order
		//	List<PurchaseOrder> orders = purchaseOrderService.getOrders ();
		//	foreach (PurchaseOrder orderlist in orders) {
		//		foreach (Item itmes in orderlist.Items) { Console.WriteLine (itmes); }
		//	}

		//	//delete order
		//	Console.WriteLine (purchaseOrderService.Cancle (order));

		//}
	}
}
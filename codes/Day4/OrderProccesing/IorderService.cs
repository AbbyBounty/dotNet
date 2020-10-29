using System;

using System.Collections.Generic;
using OrderProcessing;
using CRM;
namespace OrderProcessing {

	public interface IorderService {
		 bool Process (Order order);
		 bool Cancle (Order order);
		 bool Create (Order order);
		 bool Update (Order order);

		 Order getOrder (int id);
		 List<Order> getOrders ();

		
		
		 void Approve ();

	}
}

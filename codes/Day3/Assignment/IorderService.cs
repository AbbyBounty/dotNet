using System;

using System.Collections.Generic;
using OrderProcessing;
using CRM;
namespace OrderProcessing {

	public interface IorderService {
		 bool Process (PurchaseOrder order);
		 bool Cancle (PurchaseOrder order);
		 bool Create (PurchaseOrder order);
		 bool Update (PurchaseOrder order);

		 PurchaseOrder getOrder (int id);
		 List<PurchaseOrder> getOrders ();

		
		
		 void Approve ();

	}
}

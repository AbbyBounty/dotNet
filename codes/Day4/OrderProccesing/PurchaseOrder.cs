using System;
using CRM;
using System.Collections.Generic;
using ShoppingCart;
namespace OrderProcessing {
	public class PurchaseOrder : Order {

                
                public Customer customer { get; set; }
                public List<Item> Items { get; set; }

                public PurchaseOrder (int orderId, DateTime orderDate, Customer customer, List<Item> items) : this (orderId)
                {
                        this.orderDate = orderDate;
                        this.customer = customer;
                        Items = items;
                }

		public PurchaseOrder ()
                {
                }

                public PurchaseOrder (int id)
                {
                        this.orderId = id;
                }

                public PurchaseOrder (Customer customer)
                {
                        this.customer = customer;
                }

                public override string ToString ()
                {
                        return this.orderDate + " " + this.customer.ToString ();
                }

               
	}
}

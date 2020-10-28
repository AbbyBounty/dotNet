using System;
using CRM;
using System.Collections.Generic;
using ShoppingCart;

namespace OrderProcessing
{
    public class Order
    {

        public int orderId { get; set; }
        public DateTime orderDate { get; set; }
        public Customer customer { get; set; }
        public List<Item> Items { get; set; }

        public Order()
        {
        }

        public Order(int id)
        {
            this.orderId = id;
        }

        public Order(Customer customer)
        {
            this.customer = customer;
        }

        public override string ToString()
        {
            return this.orderDate+" "+this.customer.ToString();
        }


       
    }
}

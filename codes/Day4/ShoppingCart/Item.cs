
using Cataloge;
using System;
namespace ShoppingCart
{
    public class Item
    {

        private int id;
        //private Product product;
        //private int quantity;


        public Product product { get; set; }
        public int quantity { get; set; }

        public Item(int id, Product product, int quantity)
        {
            this.id = id;
            this.product = product;
            this.quantity = quantity;
        }

        public Item(Product product, int quantity)
        {

            this.product = product;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return this.id + " " + this.product + " " + this.quantity;
        }
    }
}

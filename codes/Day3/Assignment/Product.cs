using System;
namespace Cataloge
{
    public class Product
    {

        private int id;
        private string title;
        private string description;
        private int unitPrice;
        private int quantity;

        public Product(int id, string title, string description, int unitPrice, int quantity)
        {
            this.description = description;
            this.id = id;
            this.title = title;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }

        public override string ToString()
        { 

            return this.id + " " + this.title + " " + this.description + " " + this.unitPrice + " " + this.quantity;
        }

    }
}

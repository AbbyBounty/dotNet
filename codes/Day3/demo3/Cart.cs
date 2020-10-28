using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public class Cart
    {
        private List<Item> items;
        private static int cnt;

        public List<Item> Items { get { return items; } set { items = value; } }

        public Cart(List<Item> items)
        {
            this.items = items;
            
        }

        public void AddtoCart(Item item)
        {
            
            //items.Insert(cnt,item);
            items.Add(item);
            //cnt++;


        }

        public string RemoveFromCart(Item item)
        {
            items.Remove(item);
            return "item removed successfully";
        }

        public List<Item> getAllItems()
        {
            List<Item> items = new List<Item>(); 
            foreach (Item item in this.items){ items.Add(item); }

            return items;
        }

        public override string ToString()
        {
            return " " + this.items;
        }
    }
}

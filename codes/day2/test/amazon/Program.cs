using System;
using System.Collections.Generic;
using Cataloge;
using CRM;
using ShoppingCart;
using Banking;
using Membership;

namespace amazon
{
    class MainClass
    {
        //public static void Main(string[] args)
        //{
        //    //Product
        //    Product product = new Product(1, "java", "this is java book", 2, 4);
        //    Console.WriteLine(product);

        //    //Customer
        //    Customer customer = new Customer(1, "steve", "jobs", "steve@gmail.com", "98989767");
        //    Console.WriteLine(customer.ToString());


        //    //Account
        //    Account account = new Account(1000);
        //    account.Withdraw(100);
        //    account.Deposite(500);
        //    Console.WriteLine(account.ToString());


        //    //AccountManager
        //    //AccountManager accountManager = new AccountManager("rayn", "rayn");
        //    Boolean res = AccountManager.Login("rayn", "rayn");
        //    Console.WriteLine(res);


        //    //Item
            //Item item = new Item(1, new Product(1, "java", "this is java book", 2, 4), 3);
            //Console.WriteLine("item : " + item.ToString());

        //Cart
        List<Item> items = new List<Item>() { new Item(1, new Product(1, "java", "this is java book", 2, 4), 3),
                new Item(2, new Product(2, "C", "this is best  C book", 2, 4), 3),
                new Item(3, new Product(3, "OS", "this is best OS book", 2, 4), 3)
            };

        //    Cart cart = new Cart(items);
        //    List<Item> cartitems = cart.getAllItems();
        //    foreach (Item cartitem in cartitems) { Console.WriteLine(cartitem); }


        //}
    }
}

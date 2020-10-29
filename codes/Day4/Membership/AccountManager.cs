using System;
using CRM;
namespace Membership
{
    public static class AccountManager
    {

        //private  string username;
        //private  string password;

        //public AccountManager(string username, string password)
        //{
        //    this.username = username;
        //    this.password = password;
        //}

        //public AccountManager()
        //{
        //}

        public static Boolean Login(string username, string password)
        {
            //AccountManager accountManager = new AccountManager();

            if (username=="steve" && password=="steve")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool Register(string loginId,string password,string name,string email,string phone)
        {
            Customer customer = new Customer();
            customer.firstname = name;
            customer.password = password;
            customer.email = email;
            customer.userid = loginId;
            customer.contactNumber = phone;

            if (customer != null)
                return true;
            else
                return false;

        }

       public static bool ChangePassword(string loginId,string oldPassword,string newPassword)
        {
            return false;

        }


    }





}

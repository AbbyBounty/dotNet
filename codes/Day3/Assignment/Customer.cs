using System;
namespace CRM
{
    public class Customer
    {
        

    
        public int id { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }

        public string email { get; set; }
        public string contactNumber { get; set; }

        public string userid { get; set; }
        public string password { get; set; }

        public Customer(int id)
        {
            this.id = id;
        }

        public Customer()
        {
        }

        public Customer(int id, string firstname, string lastname, string email, string contactNumber)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.contactNumber = contactNumber;
        }


       


        public Customer(string userid,  string firstname, string email,string password, string contactNumber)
        {
            this.userid = userid;
            this.firstname = firstname;
            this.password = password;
            this.email = email;
            this.contactNumber = contactNumber;
        }


        public override string ToString()
        {
            return this.id + " " + this.firstname + " " + this.lastname + " " + this.email + " " + this.contactNumber;
        }
    }


}

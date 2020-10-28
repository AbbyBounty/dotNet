using System;
namespace HR
{
    public struct Point
    {
        public int x;
        public int y;
    }
    public class Person
    {

        protected string firstName { set; get; }
        protected string lastName { set; get; }
        protected DateTime birthdate { set; get; }

        public Person(string firstName, string lastName, DateTime birthdate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdate = birthdate;
        }

        public Person()
        {
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.birthdate;
        }
    }
}

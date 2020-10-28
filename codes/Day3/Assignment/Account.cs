using System;
namespace Banking
{
    public class Account
    {
        private float balance;

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account(int balance)
        {
            this.balance = balance;
        }

        public void Withdraw(float num)
        {
            this.balance = this.balance - num;

        }

        public void Deposite(float num)
        {
            this.balance = this.balance + num;

        }

        public override string ToString()
        {
            return " "+this.balance;
        }
    }
}

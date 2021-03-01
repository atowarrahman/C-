using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;//Association(HAS-A Relation)

        public Account(int accountNumber, string accountName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }


        public void Deposit(double x)
        {
            Balance = x + Balance;
            Console.WriteLine(x + " Taka deposited successfully.");
            Console.WriteLine("Balance After deposit:" + Balance);
        }
        public Boolean Withdraw(double y)
        {
            if (Balance >= y)
            {
                Balance = (Balance - y);
                Console.WriteLine(y + " Taka withdrawn successfully.");
                Console.WriteLine("Balance AfterWithdraw:" + Balance);
                return true;
            }
            else
            {
                Console.WriteLine("Withdrawl of money can not possible.");
                return false;
            }
        }
        public void Transfer(double amount, Account receiver)
        {
            if (this.Withdraw(amount)) ;
            {
                receiver.Deposit(amount);
            }
            Balance = (Balance - amount);
            Console.WriteLine(amount + " Taka Transferred Successfully.");
            Console.WriteLine("Transfer:" + Balance);
        }





        public void ShowAccountInformation()
        {
            //Console.WriteLine("Account No:"+this.accountNumber+"\nAccount Name:"+this.accountName+"\nBalance:"+this.balance);
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
            this.address.GetAddress();
        }
    }
}
}

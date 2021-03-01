using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_E_
{
    //Constructor
    //1. parameterless/empty
    //2. parameterized/valued
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;

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
        public Account()//parameterless
        {
            this.accountNumber = 0;
            this.accountName="";
            this.balance = 0.0;
        }
        public Account(int accountNumber,string accountName,double balance)//parameterized
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            //this.balance = balance;
        }
        public Account( string accountName, int accountNumber, double balance):this(accountNumber,accountName,balance)
        {
            this.balance = balance;
        }
        public void PrintAccount()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}",this.accountNumber,this.accountName,this.balance);
        }
        ~Account()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Account account1 = new Account("Tamim",2002,15000.0);
            //account1.PrintAccount();
            //Account account2 = new Account(1001,"Shakib",20000.0);
            //account2.PrintAccount();

            Account account3 = new Account() { AccountNumber=5005,AccountName="Mushfiq",Balance=40000};
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_E_
{
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

        //Auto-implemented property

        public string Branch
        {
            set;
            get;
        }
        public void PrintAccount()
        {
            //Console.WriteLine("Account No:"+this.accountNumber+"\nAccount Name:"+this.accountName+"\nBalance:"+this.balance);
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}\nBranch:{3}",this.accountNumber,this.accountName,this.balance,this.Branch);
        }
    }
}

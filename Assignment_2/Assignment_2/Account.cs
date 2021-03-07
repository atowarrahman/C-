using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Account : Open
    {
        string acctype;
        int reciver;
        public Account(string accType, int reciver, string name, string dob, string address, double startbCus) : base(name, dob, address, startbCus)
        {
            AccType = acctype;
        }
        public string AccType
        {
            get { return acctype; }
            set { acctype = value; }
        }
        public int Reciver
        {
            get { return reciver; }
            set { reciver = value; }
        }
        public void Deposit(double x)
        {
            StartbCus = x + StartbCus;
            Console.WriteLine(x + " Taka deposited successfully.");
            Console.WriteLine("Balance After deposit:" + StartbCus);
        }
        public Boolean Withdraw(double y)
        {
            if (StartbCus >= y)
            {
                StartbCus = (StartbCus - y);
                Console.WriteLine(y + " Taka withdrawn successfully.");
                Console.WriteLine("Balance AfterWithdraw:" + StartbCus);
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
            if (this.Withdraw(amount))
            {
                receiver.Deposit(amount);
            }
            StartbCus = (StartbCus - amount);
            Console.WriteLine(amount + " Taka Transferred Successfully.");
            Console.WriteLine("Transfer:" + StartbCus);
        }
        public void showInfo()
        {
            Console.WriteLine("Transactions");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ourBank = new Bank("Developers Bank", 5);
            Account a = new Account(2, "Bank", 500, new Address(20, 10, "Dhaka", "Bangladesh"));
            a.ShowAccountInformation();
            a.Deposit(500);
            a.Withdraw(100);
            ourBank.PrintAccountDetails();



            Console.ReadKey();
        }
    }
}

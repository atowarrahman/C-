using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank ourBank = new Bank("Our Bank");
            Account a = new Account("Bank", 30000, 2, new Address(20, 10, "Dhaka", "Bangladesh"));
            Account b = new Account("Bank2", 30000, 3, new Address(20, 10, "Dhaka", "Bangladesh"));
            a.ShowAccountInformation();
            a.Deposit(500);
            a.Withdraw(100);

            ourBank.PrintAccountDetails();
          



            Console.ReadKey();
        }
    }
}

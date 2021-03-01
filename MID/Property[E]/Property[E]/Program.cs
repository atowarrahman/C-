using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.AccountNumber = 101;
            account.AccountName = "Abc";
            account.Balance = 2000;
            account.Branch = "Banani";
            //Console.WriteLine(account.AccountNumber);
            account.PrintAccount();
        }
    }
}

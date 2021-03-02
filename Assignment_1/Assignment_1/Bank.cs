using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Bank
    {

        private Account[] myBank = new Account[1000];
        private string bankName;
        public Bank(string name)
        {
            this.bankName = name;
           
        }

        public string Name
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        public Account[] Accounts
        {
            get { return this.myBank; }
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }

        public void DeletAccount(int accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i] = null;
                    Console.WriteLine("Account Deleted\n");
                    for (int j = i; j < myBank.Length - 1; j++)
                    {
                        myBank[j] = myBank[j + 1];

                    }
                    break;
                }

            }



        }
     

        public void Transaction(int transactionType, params object[] perameters)
        {
            switch (transactionType)
            {
                case 1:
                    Console.WriteLine("You have choose withdraw!!");
                    double wAmount = (double)perameters[1];
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i] == perameters[0])
                        {
                            myBank[i].Withdraw(wAmount);
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("You have choose deposit!!");
                    double dAmount = (double)perameters[1];
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i] == perameters[0])
                        {
                            myBank[i].Deposit(dAmount);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("You have choose Transfer");
                    Account sender = new Account();
                    double tAmount = (double)perameters[2];
                    Console.Write(tAmount + "\n");
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i] == perameters[0])
                        {
                            sender = myBank[i];
                            break;
                        }
                    }
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i] == perameters[1])
                        {
                            Console.Write(sender.Balance);
                            sender.Transfer(myBank[i], tAmount);
                            break;

                           
                        }
                    }
                    break;

            }
        }

        public void PrintAccountDetails()
        {

            Console.WriteLine("Bank Name: " + bankName);
        }
    }
}
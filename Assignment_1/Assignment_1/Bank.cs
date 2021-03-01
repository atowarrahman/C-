using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Bank
    {

        private Account[] myBank;
        private string bankName;
        public Bank(string name, int size)
        {
            this.bankName = name;
            this.myBank = new Account[size];
            //  Console.WriteLine("Bank Name:" + name + "  Size:" + size);
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


        public void Transaction(int transactionType, int amount)
        {
            Console.WriteLine();
        }

        public void PrintAccountDetails()
        {

            Console.WriteLine("Bank Name: " + bankName);
        }
    }
}


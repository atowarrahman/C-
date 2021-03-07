using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool temp = true;
            while (temp)
            {
                Open a = new Open("Emon", "birthday", "banani", 100);
                Console.WriteLine("Please Select Any Option.");
                Console.WriteLine("\nType 'open' to Open an Account \nType 'account' to access Account \nType 'quit' to Quit");
                string option = Console.ReadLine();
                if (option == "open")
                {
                    Console.WriteLine("Open Account");
                    a.info();
                }
                else if (option == "account")
                {
                    Console.WriteLine("Account");
                    string option2 = Console.ReadLine();
                    Account b = new Account(option2, 1, "Emon", "birthday", "banani", 100);
                    Account c = new Account(option2, 2, "mon", "birthday", "banani", 200);

                    while (true)
                    {
                        if (option2 == "deposit")
                        {
                            b.Deposit(200);
                            b.ToString();
                            break;
                        }
                        else if (option2 == "withdraw")
                        {
                            b.Withdraw(100);
                            break;
                        }
                        else if (option2 == "transfer")
                        {
                            //b.Transfer(100,1);
                            break;
                        }
                        else if (option2 == "quit")
                        {
                            Console.WriteLine("Thank you for visiting.");
                            temp = false;
                        }
                    }

                }
                else if (option == "quit")
                {
                    Console.WriteLine("Thank you for visiting.");
                    temp = false;
                }
                else
                {
                    Console.WriteLine("Invalid Selection!!!");
                }
            }
            Console.ReadKey();
        }
    }
}

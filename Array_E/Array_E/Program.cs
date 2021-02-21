using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_E
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cityName = new string[5] { "Dhaka", "London", "New York", "Tokyo","Rangpur" };
            Console.WriteLine("Enter a City name :");
            string city = Console.ReadLine();
            for(int i=0; i< cityName.Length; i++) 
            {
                if (cityName[i] == city)
                {
                    Console.WriteLine("Found city.");
                    break;
                }
                else
                {
                    Console.WriteLine("Found not city.");
                    break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string id;
            int n;
            IdGenarator ig = new IdGenarator();
            Console.WriteLine("How many student you want:");
            n = System.Convert.ToInt32(System.Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Student name:");
                name = System.Console.ReadLine();
                id = ig.ID();
                System.Console.Write("ID: " + id);
            }
            System.Console.ReadKey();

        }
    }
}

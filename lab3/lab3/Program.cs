using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //student s = new student();
            Console.Write("Please enter your name: ");
             string name = Console.ReadLine();
           // s.Name = "Atowar";
           // s.Id = "19-41012-2";
            Console.Write("Please enter your ID: ");
            string id = Console.ReadLine();
            Console.Write("Please enter your CGPA: ");
             double cgpa =Convert.ToDouble( Console.ReadLine());
            student s = new student();
            s.Print();

            // s.Cgpa = 3.67f;
            // Console.WriteLine(s.Name);
            //  Console.WriteLine(s.Id);
            // Console.WriteLine(s.Cgpa);
        }
    }
}

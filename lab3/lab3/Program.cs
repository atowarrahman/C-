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



            student s = University.Getstudent();
            Console.Write("Please enter your name: ");
             string name = Console.ReadLine();
           
            Console.Write("Please enter your ID: ");
            string id = Console.ReadLine();
            Console.Write("Please enter your CGPA: ");
             double cgpa =Convert.ToDouble( Console.ReadLine());

            University.GetStudentCgpaOrder(ref s);
     
        }
    }
}

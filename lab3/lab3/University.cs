using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
   public class University
    {

      public  static student  Getstudent()
        {
            student s = new student();
       
            return s;
        }
       public static void GetStudentCgpaOrder(ref student ss)
        {
           
            double[] cgpa = { 3.50, 3.94, 4.00, 2.96, 3.00 };
            Array.Sort(cgpa);
            Array.Reverse(cgpa);
            foreach (double value in cgpa)
            {
                Console.WriteLine("CGPA :" + value);
            }

        }
    }
}

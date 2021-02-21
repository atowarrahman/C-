using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            //1.single dimensional array
            //2.Multi-dimensional array
            //3.jagged array

            //single dimensional array
            //  int[] array = new int[2];
            //  array[0] = 20;
            // array[1] = 30;
            //  Console.WriteLine(array[0]);
            // Console.WriteLine(array[1]);
            //  int[] array = new int[7] { 5, 7, 8,4,8,9,5};
            //int[] array = new int[] { 5, 7, 8, 4, 8, 9, 5 };
            int[] array = { 5, 7, 8, 4, 8, 9, 5 };
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            //for (int i = 0; i < array.Length; i++)
          //  {
          //      Console.WriteLine(array[i]);
           // }
        }
    }
}

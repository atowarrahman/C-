using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            //1. Single dimensional array
            //2. Multi-dimensional array
            //3. Jagged array

            //Single dimensional array

            //int[] array= new int[3];
            //array[0] = 20;
            //array[1] = 30;
            //array[2] = 40;
            //Console.WriteLine(array[3]);//Error

            int[] array = new int[3] { 5, 7, 8 };
            //int[] array = new int[] { 5, 7, 8 ,10};
            //int[] array = { 5, 7, 8, 10 };

            //for (int i=0;i<array.Length;i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_Modifiers_E_
{
    class Program
    {
        //static void MyMethod(ref int a)
        //{
        //    a = 50;
        //}
        //static void MyMethod(out int a)
        //{
        //    a = 50;
        //}

        //params
        static void MyMethod(params object[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i].GetType());
            }
        }
        static void Main(string[] args)
        {
            //int x = 10;
            //MyMethod(x);//pass by value
            //pass by reference-> ref, out keywords
            //int x;
            //int y = 20;
            //MyMethod(out x);
            //Console.WriteLine(x);

            int x = 10;
            int y = 20;
            MyMethod( x,"hello", 3.5, y );
        }
    }
}

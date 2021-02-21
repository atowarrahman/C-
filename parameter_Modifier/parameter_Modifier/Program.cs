using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter_Modifier
{
    class Program
    {
      //  static void MyMethode(ref int a,out float b)
       // {
       //     a = 50;
            //b = 100;
       // }
       // static void MyMethode(out int a,ref int b)
       // {
        //    a = 50;
      //      b = 200;
      //  }
        static void MyMethod(params object[]myArray)
        {
           // Console.WriteLine(myArray[0]);
           for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i].GetType());
                 
            }
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            //MyMethode(x);//pass by value
            //pass by reference by value keyword
            // MyMethode( out x,ref y);
            // Console.WriteLine(MyMethode);
            //  Console.WriteLine(x);
            MyMethod(x, y, 100, 200,1224,200,500,364,32,"hello",3.67,700.00);
        }
    }
}

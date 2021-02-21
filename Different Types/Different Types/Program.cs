using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Types
{
    class Program
    {
       // Nullable<int> id = 100;
        public void MyMethode(Nullable<int> anything)
        {
            Console.WriteLine(anything);
        }

        static void Main(string[] args)
        {
            //boxing
            //int x = 10;
            // object obj = x;
            // x = 5;
            // obj = 7;
            // Console.WriteLine("x:" + x);
            // Console.WriteLine("obj:" + obj);
            // int y = (int)obj;
            // y = 20;
            //  Console.WriteLine("Y:" + y);
            //  Console.WriteLine("obj:" + obj);
            //nullable
            Nullable <int>x = null;
            // Console.WriteLine(x.HasValue);
            // Console.WriteLine(x);

          //  Console.WriteLine(new Program().id);
        }
    }
}

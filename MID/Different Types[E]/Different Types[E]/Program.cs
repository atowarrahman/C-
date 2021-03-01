using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Types_E_
{
    class Program
    {
        //Nullable<int> id = 100;//Correct

        //var id = 110;//Error

        //dynamic id = 110;//Correct

        //public void MyMethod(Nullable<int> anything)//Correct
        //public void MyMethod(var anything)//Error
        //public void MyMethod(dynamic anything)//Correct
        public void MyMethod()
        {
            //Console.WriteLine(anything);
        }
        static void Main(string[] args)
        {
            //Boxing(boxed-value)
            //int x = 10;
            //object obj = x;
            //x = 5;
            //obj = 7;
            //Console.WriteLine("x:"+x);
            //Console.WriteLine("obj:" + obj);

            //Unboxing
            //int y =(int) obj;
            //y = 15;
            //obj = 20;
            //Console.WriteLine("y:" + y);
            //Console.WriteLine("obj:" + obj);

            //Nullable
            //Nullable<int> x=5;
            //int? x = 10;
            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(x);
            //Console.WriteLine(new Program().id);


            //var keyword
            //var x = 3.5f;
            //x = "hello";//Error
            //Console.WriteLine(x);

            //dynamic keyword
            dynamic x = "hello";
            //x = 3.5;//Correct
            //Console.WriteLine(x.GetType());
            //Console.WriteLine(x);
            //Console.WriteLine(new Program().id);
        }
    }
}

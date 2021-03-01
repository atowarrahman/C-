using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_static__VS_Instance_non_static__E_
{
    class Program
    {
        int instanceField = 10;
        static int classField = 20;

        //Constant->const, readonly
        const int constantField=70;
        readonly int readonlyField=90;
        public Program()
        {
            //constantField = 700;//Error
            readonlyField = 900;
        }
        public Program(int x)
        {
            readonlyField = x;
        }
        void NonStaticMethod()
        {
            instanceField = 100;
            Program.classField = 200;
            const int x = 400;//Correct
            //readonlyField = 40;//Error
            //readonly int y = 10;//Error
        }

        static void StaticMethod(Program p)
        {
            Program.classField = 200;
            p.instanceField = 100;
            //const int x = 400;
        }
        static void Main(string[] args)
        {
            Program p = new Program(150);
            //Console.WriteLine(Program.constantField);
            Console.WriteLine(p.readonlyField);

        }
    }
}

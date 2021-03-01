using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration_E_
{
    //set of string integral constants
    enum Hobbies:byte
    {
        Travelling=5,
        Reading=10,
        Singing=20,
        Gardening=200
    }

    enum Gender:byte
    {
        Female,
        Male
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name:"+Hobbies.Reading+" value:"+(int)Hobbies.Reading);
        }
    }
}

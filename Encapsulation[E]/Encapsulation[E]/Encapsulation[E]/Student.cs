using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
namespace Encapsulation_E_
{
    class Student:Person
    {
        public Student()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.email);
            Console.WriteLine(this.contactNumber);
        }
    }
}

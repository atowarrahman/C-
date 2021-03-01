using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class Teacher:Person
    {
        public Teacher()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.email);
            Console.WriteLine(this.address);
            Console.WriteLine(this.contactNumber);
        }
    }
}

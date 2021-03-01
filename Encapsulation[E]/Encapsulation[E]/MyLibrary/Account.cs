using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class Account
    {
        Person person = new Person();
        public Account()
        {
            Console.WriteLine(person.name);
            Console.WriteLine(person.address);
            Console.WriteLine(person.contactNumber);
        }
    }
}

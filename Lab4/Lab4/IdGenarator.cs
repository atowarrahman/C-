using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class IdGenarator
    {
        static int count = 0;
        private string id = "21-0000";
        public string ID()
        {
            count = count + 1;
            Console.WriteLine(id + count + "-1");
        }
    }
}

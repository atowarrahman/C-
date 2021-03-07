using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Open
    {

        protected string name, dob, address;
        protected double startbCus;
        protected int accnum;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double StartbCus
        {
            get { return startbCus; }
            set { startbCus = value; }
        }
        public int Accnum
        {
            get { return accnum; }
            set { accnum = value; }
        }
        public Open(string name, string dob, string address, double startbCus)
        {
            Name = name;
            Dob = dob;
            Address = address;
            StartbCus = startbCus;
            Accnum = accnum + GetHashCode();
        }
        public void info()
        {
            Console.WriteLine("Your name: " + Name + "\n"
                + "Date of birth: " + Dob + "\n"
                + "Address: " + Address + "\n"
                + "Balance: " + StartbCus);
        }
    }
}
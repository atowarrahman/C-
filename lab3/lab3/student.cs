using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{

    public class student
    {
        public string name;
        public string id;
        public double cgpa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public void Print()
        {
          Console.WriteLine("Student Name ={0}\nStudent ID={1}\nCgpa ={2}", Name, id, Cgpa);
         }
    }
}




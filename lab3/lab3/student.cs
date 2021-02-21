using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public string Name;
    public string ID;
    public double Cgpa;
    public class student(string Name,string id,double cgpa)
    {
        this.Name=Name;
            this.ID=ID;
            this.Cgpa=Cgpa;
             }
    public void Print()
    {
        Console.WriteLine("Student Name ={0}\nStudent ID={1}\nCgpa ={2}", Name, ID, Cgpa);
    }
}



//private string name;
// private string id;
// private double cgpa;
// public string Name
// {
//     get { return name; }
//     set { name = value; }
// }
// public string Id
// {
//   get { return id; }
//    set { id = value; }
// }
//public double Cgpa
// {
//    get { return cgpa; }
//     set { cgpa = value; }
// }





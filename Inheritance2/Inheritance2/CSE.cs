using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Inheritance2
{
     class CSE: Student
    {
        public string department { get; set; }
        public string Major {  get; set; }

        public void setCSE(int Id,string Name,int Age,string department, string Major)
        {
            setStudent(Id, Name, Age);
            this.department = department;
            this.Major = Major;
        }

        public void getCSE()
        {
            Console.WriteLine("Id: "+Id);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Major: " + Major);
            Console.WriteLine("*********************");
        }
    }
}

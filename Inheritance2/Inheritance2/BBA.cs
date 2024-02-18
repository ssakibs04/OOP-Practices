using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
     class BBA :Student
    {
        public string department { get; set; }
        public string major {  get; set; }

        public void setBBA (int Id,string Name,int Age, string department, string major)
        {
            setStudent(Id, Name, Age);
            this.department = department;
            this.major = major;
        }
        public void getBBA()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Major: " + major);
        }
    }
}

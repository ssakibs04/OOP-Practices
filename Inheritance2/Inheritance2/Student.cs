using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
     class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void setStudent(int ID  ,string Name, int Age)
        {
            this.Id = ID;
            this.Name = Name;
            this.Age = Age;

        }
    }
}

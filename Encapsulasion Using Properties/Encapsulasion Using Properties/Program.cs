using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulasion_Using_Properties
{
    class person
    {
        public string firstName { get; set; }
        public string lastName { get;  set; }

        public int age { get; set; }


        public person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
                this.age = age;
        }

        public void DisplayPerson()
        {
            Console.WriteLine("First Name: "+firstName);
            Console.WriteLine("Last Name: "+lastName);
            Console.WriteLine("Age: "+age);
        }
    }
        class program
        {
            static void Main(string[] args)
            {
                person p = new person("Sadman","Sakib",23);
                p.DisplayPerson();
            
            Console.ReadLine();
            }


        }
        
    }


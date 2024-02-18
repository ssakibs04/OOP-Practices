using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    public class Person
    {
        public string name;
        public int age;
        

        public Person(string name, int age) {
            this.name = name;
            this.age = age;

        }
        public void getDetails()
        {
            Console.WriteLine("Your Name {0}",name);
            Console.WriteLine("Your Age {0} Years Old",age);
              Console.WriteLine("-------------------");
        }
        //Destructor
        ~Person()
        {
            Console.WriteLine("Destructor");
        }
        static void Main(string[] args)
        {
            Person sakib = new Person("Sakib",10);
            sakib.getDetails();

            Person Rakib =new Person("Rakib",88);
            Rakib.getDetails();

            Person Karim = new Person("Karim", 99);
            Karim.getDetails();
            Console.ReadLine();


        }
    }
}

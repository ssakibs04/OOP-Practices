using System;

namespace Encapsulation
{
    public class Student
    {
        private int id;
        private string name;

        // Encapsulation for ID
        public void SetID(int id)
        {
            if (id > 0)
            {
                this.id = id;
                Console.WriteLine("ID: " + this.id);
            }
            else
            {
                Console.WriteLine("Can't enter negative ID");
            }
        }

        public void GetID()
        {
            if (id > 0)
            {
              
            }
            else
            {
             
            }
        }

        // Encapsulation for Name
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.name = name;
            }
            else
            {
                
            }
        }

        public void GetName()
        {
            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name: " + this.name);
            }
            else
            {
                Console.WriteLine("Name not set");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.SetID(2);
            s.GetID();

            s.SetName("Sakib");
            s.GetName();

           

            Console.ReadLine();
        }
    }
}

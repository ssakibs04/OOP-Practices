using System;

namespace OperatorOverloading
{
    class oprtr
    {
        public string name;
        public int num;

        // Overloading the + operator
        public static oprtr operator +(oprtr firstName, oprtr lastName)
        {
            oprtr fullName = new oprtr();
            fullName.name = firstName.name + " " + lastName.name;
            fullName.num = firstName.num + lastName.num;
            return fullName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            oprtr firstName = new oprtr();
            firstName.name = "Sadman";
            firstName.num = 10;

            oprtr lastName = new oprtr();
            lastName.name = "Sakib";
            lastName.num = 20;

            oprtr fullName = firstName + lastName;

            Console.WriteLine(fullName.name);
            Console.WriteLine(fullName.num);

            Console.ReadLine();
        }
    }
}

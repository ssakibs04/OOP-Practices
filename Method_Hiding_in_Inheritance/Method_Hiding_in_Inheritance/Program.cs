using Method_Hiding_in_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding_in_Inheritance
{
    class employee
    {
        public string firstName;
        public string lastName ;

        public new void fullName()
        {
            Console.WriteLine(firstName+" "+lastName);
        }
    }

    class partTimeEmp: employee 
    {

        public new void fullName()
        {
            Console.WriteLine("Part Time: "+firstName + " " + lastName);
        }

    }
    
    class fullTimeEmp : employee
    {
        public new void fullName()
        {
            ////if i want to run base class method then i can use 
            //base.fullName();
            Console.WriteLine("Full Time: "+firstName + " " + lastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           fullTimeEmp fullName= new fullTimeEmp();
            fullName.firstName = "Sadman";
            fullName.lastName = "Sakib";
            fullName.fullName();

            Console.ReadLine();
        }
    }
}



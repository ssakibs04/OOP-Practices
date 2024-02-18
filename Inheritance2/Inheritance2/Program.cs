
using System;

namespace Inheritance2
{
     class Program
    {
        static void Main(string[] args)
        {
            CSE sakib = new CSE();
            sakib.setCSE(101, "Sakib", 23, "CSE", "SE");
            sakib.getCSE();


            BBA rakib=new BBA();
            rakib.setBBA(201,"Rakib",24,"BBA", "Marketing");
            rakib.getBBA();
            
            Console.ReadLine();
        }
    }
}

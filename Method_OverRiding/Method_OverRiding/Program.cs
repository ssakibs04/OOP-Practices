using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_OverRiding
{
    class Parent
    {
        public virtual void Print(int a, int b)
        {
            int c=a*b;
            
            Console.WriteLine("Run Parent Class "+c);
        }
    }
    class child:Parent
    {
        public override void Print(int a , int b)
        {
            int c = a + b;
            Console.WriteLine("Run Child Class :"+c);
        }

    }
     class Program
    {
        static void Main(string[] args)
        {
            Parent p = new child(); 
            p.Print(1, 2);


            Console.ReadLine();

        }
    }
}

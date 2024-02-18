using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{
     class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "One", "Two", "Three", "Four" };
            string singleString = String.Join(".", words); ;
            Console.WriteLine(singleString);
            Console.ReadLine();
        }
    }
}

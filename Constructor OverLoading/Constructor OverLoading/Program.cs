using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_OverLoading
{
 class Program
	{
		public Program()
		{
			Console.WriteLine("Default Constructor");
		}
		public Program(int a , int b)
		{
			Console.WriteLine("Second Constructor ");
		}

	public Program(int a , int b , int c)
		{
            Console.WriteLine("Third Constructor "+(a+b+c));
        }


		
	}
}

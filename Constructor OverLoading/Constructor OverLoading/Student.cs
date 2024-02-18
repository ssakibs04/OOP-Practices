using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_OverLoading
{
	internal class Student
	{
		static void Main(string[] args)
		{
			//for default or first constructor
			Program p1 = new Program();
			//for second constructor
			Program p = new Program(30, 40);

			//for third constructor
			Program p3 = new Program(1, 456, 465);
			Console.ReadLine();

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC_CONSTRUCTOR
{
	class person
	{
		public static string name;
		public static int age;

		static person()
		{
			name = "John";
			age = 25;
			Console.WriteLine("Static Constrructor");
		}
		public person()
		{
			Console.WriteLine("Default Constructor");
		}
		public static void getDetails()
		{
			Console.WriteLine("Person Name: "+name);
			Console.WriteLine("Person Age: " + age);
		}
		
		class Program
		{
			static void Main(string[] args)
			{
				person jihn = new person();
				person.getDetails();
				
				
				
				Console.ReadLine();
			}

		}
	}
}

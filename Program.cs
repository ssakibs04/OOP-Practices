using System;

namespace StudentData
{
	class Student
	{
		private string name;
		private string standard;
		private int age;

		public void SetStudent()
		{
			Console.Write("Enter your name: ");
			name = Console.ReadLine();
			Console.Write("Enter your standard: ");
			standard = Console.ReadLine();
			Console.Write("Enter your age: ");
			age = int.Parse(Console.ReadLine());
			Console.WriteLine("*********");
		}

		public void GetStudent()
		{
			Console.WriteLine("Your name is: " + name);
			Console.WriteLine("Your standard is: " + standard);
			Console.WriteLine("Your Age is: " + age);
			Console.WriteLine("------------------------");
		}

		
	}
}

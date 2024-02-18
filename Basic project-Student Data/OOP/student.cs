using StudentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class student
	{
		static void Main(string[] args)
		{
			int numberOfStudents = 100; // Change this value based on the number of students you want

			Student[] students = new Student[numberOfStudents];

			for (int i = 0; i < numberOfStudents; i++)
			{
				students[i] = new Student();
				students[i].SetStudent();
				students[i].GetStudent();
			}

			Console.ReadLine();
		}
	}
}

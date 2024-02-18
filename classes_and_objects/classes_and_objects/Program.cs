using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
	public class student
	{
		public string name;
		public int roll;
		public int level;
		public float fees;
	public student(string name, int roll, int level, float fees)// create constructor parameter
		{
			this.name = name;
			this.roll = roll;
			this.level = level;
			this.fees = fees;
		}
		
		public void getStudent()
		{
            Console.WriteLine("Student Namme: "+name);
			Console.WriteLine("Student's Roll: "+roll);
			Console.WriteLine("Students;s Level: "+level);
			Console.WriteLine("Student's Mothly Fees: "+fees);
            Console.WriteLine("-----------");
        }
		static void Main(string[] args)
		{
			student sakib = new student("Sadman Sakib", 0101, 01, 1000);

			sakib.getStudent();


			student rakib = new student("Rakib Hossain", 0102, 01, 1000);
			rakib.getStudent();

            Console.ReadLine();
			  


        }
	}
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceMember
{
	 class studentDetails
	{
		
		static void Main(string[] args)
		{
           //student1
            student sakib = new student();
			sakib.rollNo = 01;
			sakib.lastname = "Sakib";
			sakib.firstname = "Sadman";
		
			//student2
			student rakib = new student();
			rakib.rollNo = 02;
			rakib.firstname = "Rakib";
			rakib.lastname = "Hossain";

			//sstudent3(20%discount)
			student sadman = new student();
			sadman.rollNo = 03;
			sadman.firstname = "Sadman";
			sadman.lastname = "Alam";

			
			Console.WriteLine("Roll: "+sakib.rollNo);
			Console.WriteLine(sakib.firstname);
			Console.WriteLine(sakib.lastname);
				sakib.printFullName() ;
            Console.WriteLine(student.schoolName);
            Console.WriteLine("Fees: "+student.fees);
            Console.WriteLine("Annual fees Increament: "+student.getFeesAnnualincreament());//discount

            Console.WriteLine("--------------");

			Console.WriteLine("Roll"+rakib.rollNo);
			Console.WriteLine(rakib.firstname);
			Console.WriteLine(rakib.lastname);
			rakib.printFullName() ;
			Console.WriteLine(student.schoolName);
			Console.WriteLine("Fees: " + student.fees);
            Console.WriteLine("Annual Fees Increament: "+student.getFeesAnnualincreament());
			Console.WriteLine("--------------");

			//Discount
			Console.WriteLine("Roll" + sadman.rollNo);
			Console.WriteLine(sadman.firstname);
			Console.WriteLine(sadman.lastname);
			sadman.printFullName();
			Console.WriteLine(student.schoolName);
			Console.WriteLine("Fees: " + student.discountfees);
			Console.WriteLine("Annual Fees Increament: " + student.getFeesAnnualIncreamentDiscount());
			Console.ReadLine();
  Console.ReadLine();
		}
	}
}

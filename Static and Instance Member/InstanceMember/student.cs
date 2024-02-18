using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceMember
{

	public class student
	{
		//Instance variable
		public int rollNo;
		public string firstname;
		public string lastname;
		public static string schoolName="ABC School";//static variable bcz school name is same for every student.
		public static decimal fees = 4000;
		public static decimal discountfees = fees * 0.80m;
		//instance Method
		public void printFullName()
		{
			string fullName = this.firstname+" "+this.lastname;
			Console.WriteLine("Your Full Name is {0}", fullName);
			
        }
		//static method
	//	public static decimal getFees()
	//{
	//	return fees;

	//}
		public static decimal getFeesAnnualincreament() {
			return fees/10;
		
		}
		public static decimal getFeesAnnualIncreamentDiscount()//for discount students
		{
			return discountfees/10;
		}

		//public static decimal DiscountStudentsFees()
		//{
		//	return fees * 0.80m;
		//}
	
	}
	
}

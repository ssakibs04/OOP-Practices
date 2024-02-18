using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COPY_CONSTRUCTOR
{
	 class copy
	{
		string name;
		int age;
		public copy(string name, int age)
		{
			this.name = name;
			this.age = age;
		}
		public copy(copy c)
		{
			this.name=c.name;
			this.age = c.age;
		}
		public void getData()
		{
            Console.WriteLine(name);
			Console.WriteLine(age);
        }
		static void Main(string[] args)
		{
			copy obj = new copy("Sadik",20);
			obj.getData();
			copy p1 = new copy(obj);
			p1.getData();
			Console.ReadKey();

		}
	}
}

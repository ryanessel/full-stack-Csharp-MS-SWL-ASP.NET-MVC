using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ineritance
{
	public class Teacher:Employee
	{
		public string Branch { get; set; }
		public void FindSalary()
		{
			Salary = 3000;
		}
		public void SetValues2()
		{
			Position = "Teacher";
			Branch = "Math";
		}
	}
}

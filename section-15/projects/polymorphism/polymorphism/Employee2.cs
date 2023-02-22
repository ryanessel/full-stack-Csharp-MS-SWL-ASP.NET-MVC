using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
	public class Employee2
	{
		public int EmployeeID { get; set; }
		public string EmployeeName { get; set; }
		public double EmployeeSalary { get; set; }
		public string EmployeePosition { get; set; }

		//VIRTUAL AND OVERRIDING EXAMPLE
		public virtual string SetVals(int ID, string WorkerName, double Salary)
		{
			EmployeeID = ID;
			EmployeeName = WorkerName;
			EmployeeSalary = Salary;

			string text = "Employee ID: " + EmployeeID + Environment.NewLine;
			text += "Employee Name: " + EmployeeName + Environment.NewLine;
			text += "Employee Salary: " + EmployeeSalary + Environment.NewLine;
			return text;
		}


	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
	public class Teacher:Employee
	{
		public string EmployeePosition { get; set; }
		public void SetVals(int ID, string WorkerName, double Salary, string position)
		{
			EmployeeID = ID;
			EmployeeName = WorkerName;
			EmployeeSalary = Salary;
			EmployeePosition= position;
		}

		public string GetVals()
		{
			string text ="Employee ID: "  + EmployeeID + Environment.NewLine;
			text += "Employee Name: " + EmployeeName + Environment.NewLine;
			text += "Employee Salary: " + EmployeeSalary + Environment.NewLine;
			text += "Employee Position: " + EmployeePosition + Environment.NewLine;
			return text;
		}




	}
}

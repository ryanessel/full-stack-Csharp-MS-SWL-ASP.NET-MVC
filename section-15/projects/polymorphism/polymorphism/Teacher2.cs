using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
	public class Teacher2:Employee2
	{
		//OVERRRIDING EXAMPLE 
		override public string SetVals(int ID, string WorkerName, double Salary)
		{
			EmployeeID = ID;
			EmployeeName = WorkerName;
			EmployeeSalary = Salary;
			EmployeePosition = "Gym Teacher";

			string text = "Employee ID: " + EmployeeID + Environment.NewLine;
			text += "Employee Name: " + EmployeeName + Environment.NewLine;
			text += "Employee Salary: " + EmployeeSalary + Environment.NewLine;
			text += "Employee Position: " + EmployeePosition + Environment.NewLine;
			return text;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
	public class Employee
	{
		public int EmployeeID { get; set; }
		public string EmployeeName { get; set; }
		public double EmployeeSalary { get; set; }
		public void SetVals(int ID)
		{
			EmployeeID = ID;
		}

		public void SetVals(int ID, string WorkerName)
		{
			EmployeeID = ID;
			EmployeeName = WorkerName;
		}
		public void SetVals(int ID, string WorkerName, double Salary)
		{
			EmployeeID = ID;
			EmployeeName = WorkerName;
			EmployeeSalary = Salary;
		}




	}
}

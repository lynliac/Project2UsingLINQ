using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2UsingLINQ
{
	class Employees
	{
		public int EmployeeID { get; set; }
		public String EmployeeName { get; set; }
		public int Age { get; set; }
	}//class Employee
	class Program
	{
		static void Main(string[] args)
		{
			Employees[] employeeArray = {
				new Employees() { EmployeeID = 1, EmployeeName = "Mark", Age = 25},
				new Employees() { EmployeeID = 2, EmployeeName = "Alan", Age = 31},
				new Employees() { EmployeeID = 3, EmployeeName = "Joseph", Age = 22},
				new Employees() { EmployeeID = 4, EmployeeName = "James", Age = 28},
				new Employees() { EmployeeID = 5, EmployeeName = "Aron", Age = 24},
				new Employees() { EmployeeID = 6, EmployeeName = "Joey", Age = 35},
				new Employees() { EmployeeID = 7, EmployeeName = "Justin", Age = 29},
				new Employees() { EmployeeID = 8, EmployeeName = "Tom", Age = 27},
				new Employees() { EmployeeID = 9, EmployeeName = "Julie", Age = 23},
				new Employees() { EmployeeID = 10, EmployeeName = "Jodie", Age = 26},
				new Employees() { EmployeeID = 11, EmployeeName = "Fred", Age = 26},
				new Employees() { EmployeeID = 12, EmployeeName = "Tom", Age = 45},
				new Employees() { EmployeeID = 13, EmployeeName = "Donny", Age = 29},
				new Employees() { EmployeeID = 14, EmployeeName = "Liam", Age = 22},
				new Employees() { EmployeeID = 15, EmployeeName = "Pat", Age = 23},
			};

			var emp = from e in employeeArray
					  where e.Age > 24 && e.Age < 35
					  select e;

			foreach (var emps in emp)
			{
				WriteLine("My employees between 24 and 35 are : " + emps.EmployeeName);
			}



			var groups = from e in employeeArray
						 orderby e.Age
						 group e by e.Age;

			foreach (var empls in groups)
			{
				Console.WriteLine("**************** Age group: {0}", empls.Key);
				foreach (Employees e in empls)
				{
					WriteLine("Employee name: {0}", e.EmployeeName);
				}
			}


			var jays = from j in employeeArray
					   where j.EmployeeName.StartsWith("J")
					   select j;

			foreach (var empls in jays)
			{
				WriteLine("My employees that start with J are: " + empls.EmployeeName + " and they are " + empls.Age);
			}


		}
	}
}

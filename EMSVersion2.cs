using System;
using System.Collections.Generic;					

public class Employee
{
	public int EmpId;
	public string EName;
	public decimal Salary;
	public int DeptId;
}

public class Program
{
	static List<Employee> employees = new List<Employee>();
	
	public static void Main()
	{
		Employee emp = new Employee();//Object has been created
		
		Console.Write("Enter Employee Id: ");
		emp.EmpId = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter Employee Name: ");
		emp.EName = Console.ReadLine();
		
		Console.Write("Enter Salary: ");
		emp.Salary = Convert.ToDecimal(Console.ReadLine());
					  
		Console.Write("Enter Department Id: ");
		emp.DeptId = Convert.ToInt32(Console.ReadLine());
					  
		employees.Add(emp);
					  
		Console.WriteLine("\nEmployee List");
					  
		foreach(var e in employees)
		{
		  Console.WriteLine(
		  "ID: " + e.EmpId +
		  " | Name: " + e.EName +
		  " | Salary: " + e.Salary +
		  " | DeptId: " + e.DeptId	  
		  );	
		}
	}
}

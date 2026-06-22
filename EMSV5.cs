using System;
using System.Collections.Generic;

public class Employee
{
    public int EmpId;
    public string EmpName;
    public decimal Salary;
    public int DeptId;
}

public class Program
{
    static List<Employee> employees = new List<Employee>();
    public static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n===== EMPLOYEE MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Search Employee");
			Console.WriteLine("4. Update Employee");
            Console.WriteLine("5. Exit");

            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    AddEmployee();
                    break;

                case 2:
                    ViewEmployees();
                    break;

                case 3:
                    SearchEmployee();
                    break;
					
				case 4:
    				UpdateEmployee();
    				break;

                case 5:
                    Console.WriteLine("Thank You");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while(choice != 5);
    }

    static void AddEmployee()
    {
        Employee emp = new Employee();
        Console.Write("Enter Employee Id: ");
        emp.EmpId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        emp.EmpName = Console.ReadLine();

        Console.Write("Enter Salary: ");
        emp.Salary = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter Department Id: ");
        emp.DeptId = Convert.ToInt32(Console.ReadLine());

        employees.Add(emp);
        Console.WriteLine("Employee Added Successfully");
    }
    static void ViewEmployees()
    {
        Console.WriteLine("\nEmployee List");
        if(employees.Count == 0)
        {
            Console.WriteLine("No Employees Found");
            return;
        }

        foreach(var emp in employees)
        {
            Console.WriteLine(
                "ID: " + emp.EmpId +
                " | Name: " + emp.EmpName +
                " | Salary: " + emp.Salary +
                " | DeptId: " + emp.DeptId
            );
        }
    }

    static void SearchEmployee()
    {
        Console.Write("Enter Employee Id to Search: ");
        int id = Convert.ToInt32(Console.ReadLine());

        bool found = false;
        foreach(var emp in employees)
        {
            if(emp.EmpId == id)
            {
                Console.WriteLine(
                    "ID: " + emp.EmpId +
                    " | Name: " + emp.EmpName +
                    " | Salary: " + emp.Salary +
                    " | DeptId: " + emp.DeptId
                );

                found = true;
                break;
            }
        }
        if(!found)
        {
            Console.WriteLine("Employee Not Found");
        }
    }
	static void UpdateEmployee()
{
    Console.Write("Enter Employee Id to Update: ");
    int id = Convert.ToInt32(Console.ReadLine());

    bool found = false;

    foreach(var emp in employees)
    {
        if(emp.EmpId == id)
        {
            Console.Write("Enter New Name: ");
            emp.EmpName = Console.ReadLine();

            Console.Write("Enter New Salary: ");
            emp.Salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter New Department Id: ");
            emp.DeptId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Employee Updated Successfully");

            found = true;
            break;
        }
    }

    if(!found)
    {
        Console.WriteLine("Employee Not Found");
    }
}
}

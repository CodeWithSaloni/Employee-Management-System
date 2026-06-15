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
        Employee emp1 = new Employee();

        emp1.EmpId = 1;
        emp1.EmpName = "Saloni";
        emp1.Salary = 25000;
        emp1.DeptId = 1;

        employees.Add(emp1);

        Console.WriteLine("Employee List");

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
}

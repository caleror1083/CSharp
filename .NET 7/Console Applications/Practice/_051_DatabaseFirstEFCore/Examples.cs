using _051_DatabaseFirstEFCore.Models;
using System;
using System.Linq;

namespace _051_DatabaseFirstEFCore;

internal class Examples
{
    public static void ProcessExamples()
    {
        bool check;
        string decision;

        Start:
            Console.Write("Please select an example from 1-2: ");
            check = int.TryParse(Console.ReadLine(), out int choice);

            if (check)
            {
                switch (choice)
                {
                    case 1:
                        Example1();
                        break;
                    case 2:
                        Example2();
                        break;
                    default:
                        Console.WriteLine("Your choice is invalid");
                        goto Start;
                }
            }
            else
            {
                Console.WriteLine($"Selection chosen is incorrect");
                goto Start;
            }

        Decide:
            Console.Write("Do you want to do another example? - Yes or No: ");
            decision = Console.ReadLine();
            Console.WriteLine();

            switch (decision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your decision is invalid. Try again");
                    goto Decide;
            }
    }

    private static void Example1()
    {
        // Create data for the database
        Console.Write("Enter employee name: ");
        var employeeName = Console.ReadLine();

        Console.Write("Enter department: ");
        var department = Console.ReadLine();

        Console.Write("Enter date of joining");
        var dateofJoining = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter photo file name: ");
        var photoFileName = Console.ReadLine();

        using var context = new CompanyContext();
        
        var emp = new Employee
        {
            EmployeeName = employeeName.ToString(),
            DepartmentName = department.ToString(),
            DateofJoining = dateofJoining.ToLocalTime(),
            PhotoFileName = photoFileName.ToString()
        };

        context.Add(emp);
        context.SaveChanges();
    }

    private static void Example2()
    {
        // Read data from database
        using var context = new CompanyContext();
        var select = context.Employees.ToList(); // SELECT * FROM Employees

        foreach (var employeeObj in select)
        {
            Console.WriteLine($"{employeeObj.EmployeeID} {employeeObj.EmployeeName} {employeeObj.DepartmentName} {employeeObj.DateofJoining:M/d/yyyy} {employeeObj.PhotoFileName}");
        }
    }
}
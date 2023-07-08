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
                    case 3:
                        Example3();
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
        Console.WriteLine("Getting Connection ...");

        // simplified using statement allows you to declare and initialize a disposable resource in a single line
        // the resources will be automatically disposed when it goes out of scope.
        using var results = new CompanyContext();

        try
        {
            Console.WriteLine("Opening Connection ...");
            Console.WriteLine("Connection successful!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    private static void Example2()
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

        using var results = new CompanyContext();
        
        var emp = new Employees
        {
            EmployeeName = employeeName.ToString(),
            DepartmentName = department.ToString(),
            DateofJoining = dateofJoining.ToLocalTime(),
            PhotoFileName = photoFileName.ToString()
        };

        results.Add(emp);
        results.SaveChanges();
    }

    private static void Example3()
    {
        // Read data from database
        using var results = new CompanyContext();
        var select = results.Employees.ToList(); // SELECT * FROM Employees

        foreach (var employeeObj in select)
        {
            Console.WriteLine($"{employeeObj.EmployeeId} {employeeObj.EmployeeName} {employeeObj.DepartmentName} {employeeObj.DateofJoining:M/d/yyyy} {employeeObj.PhotoFileName}");
        }
    }
}
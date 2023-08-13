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
            Console.Write("Please select an example from 1-4: ");
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
                    case 4:
                        Example4();
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

    // create data for the database
    private static void Example1()
    {
        Console.Write("Enter employee name: ");
        var employeeName = Console.ReadLine();

        Console.Write("Enter department name: ");
        var department = Console.ReadLine();

        Console.Write("Enter date of joining");
        var dateofJoining = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter photo file name: ");
        var photoFileName = Console.ReadLine();

        Console.Write("Enter ssn: ");
        var ssn = Console.ReadLine();

        using var context = new CompanyContext();
        
        var employeeInfo = new Employee
        {
            EmployeeName = employeeName.ToString(),
            DepartmentName = department.ToString(),
            DateofJoining = dateofJoining.ToLocalTime(),
            PhotoFileName = photoFileName.ToString(),
            SSN = ssn.ToString()
        };

        context.Add(employeeInfo);
        context.SaveChanges();
    }

    // read data from database
    private static void Example2()
    {
        using var context = new CompanyContext();

        // SELECT * FROM Employees
        var records = context.Employees.ToList();

        // empty line
        Console.WriteLine();

        // displays the column names of the table
        Console.WriteLine($"{nameof(Employee.EmployeeID), -13} {nameof(Employee.EmployeeName), -15} {nameof(Employee.DepartmentName), -20} {nameof(Employee.DateofJoining), -16} {nameof(Employee.PhotoFileName), -18} {nameof(Employee.SSN)}");

        // iterates through the records retrieved from the employees tables in the database
        foreach (var employee in records)
        {
            Console.WriteLine($"{employee.EmployeeID, -13} {employee.EmployeeName, -15} {employee.DepartmentName, -20} {employee.DateofJoining, -16:M/d/yyyy} {employee.PhotoFileName, -18} {employee.SSN}");
        }

        // empty line
        Console.WriteLine();
    }

    // update data in database
    private static void Example3()
    {
        using var context = new CompanyContext();
        Console.WriteLine("Updating database information");
        Console.WriteLine();

        // SELECT * FROM Employees
        var employees = context.Employees.ToList();

        // empty line
        Console.WriteLine();

        // displays the column names of the table
        Console.WriteLine($"{nameof(Employee.EmployeeID),-13} {nameof(Employee.EmployeeName),-15} {nameof(Employee.DepartmentName),-20} {nameof(Employee.DateofJoining),-16} {nameof(Employee.PhotoFileName),-18} {nameof(Employee.SSN)}");

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.EmployeeID,-13} {employee.EmployeeName,-15} {employee.DepartmentName,-20} {employee.DateofJoining,-16:M/d/yyyy} {employee.PhotoFileName,-18} {employee.SSN}");
        }

        // empty line
        Console.WriteLine();

        // ask the user to enter the employee id to update
        Console.Write($"Enter the employee id to update: ");
        var employeeID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        // SELECT * FROM Employees WHERE EmployeeID = employeeID
        var employeeToDelete = context.Employees.Find(employeeID);

        // if the employee id does not exist, display invalid input
        if (employeeToDelete == null)
        {
            Console.WriteLine($"Invalid input");
            return;
        }

        // if the employee id is found in the database then ask the user what they want to update, press 1 to update employee name, press 2 to update department name, press 3 to update date of joining, press 4 to update photo file name, press 5 to update ssn and press 6 to update all fields of the employee id selected
        Console.WriteLine($"Press 1 to update employee name, press 2 to update department name, press 3 to update date of joining, press 4 to update photo file name, press 5 to update ssn and press 6 to update all fields of the employee id selected");
        Console.Write($"Enter your choice: ");
        var choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(choice);
        Console.WriteLine();
        Console.WriteLine(
            $"{nameof(Employee.EmployeeID),-13} {nameof(Employee.EmployeeName),-15} {nameof(Employee.DepartmentName),-20} {nameof(Employee.DateofJoining),-16} {nameof(Employee.PhotoFileName),-18} {nameof(Employee.SSN)}");
            Console.WriteLine();
            Console.WriteLine(
                $"{employeeToDelete.EmployeeID,-13} {employeeToDelete.EmployeeName,-15} {employeeToDelete.DepartmentName,-20} {employeeToDelete.DateofJoining,-16:M/d/yyyy} {employeeToDelete.PhotoFileName,-18} {employeeToDelete.SSN}");
                Console.WriteLine();
                Console.WriteLine(
                    $"Enter the new value for the field you want to update");
                    Console.WriteLine();
    }

    // delete data from the database
    public static void Example4()
    {
        using var context = new CompanyContext();

        // SELECT * FROM Employees
        var employees = context.Employees.ToList();

        // empty line
        Console.WriteLine();

        // displays the column names of the table
        Console.WriteLine($"{nameof(Employee.EmployeeID),-13} {nameof(Employee.EmployeeName),-15} {nameof(Employee.DepartmentName),-20} {nameof(Employee.DateofJoining),-16} {nameof(Employee.PhotoFileName),-18} {nameof(Employee.SSN)}");

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.EmployeeID,-13} {employee.EmployeeName,-15} {employee.DepartmentName,-20} {employee.DateofJoining,-16:M/d/yyyy} {employee.PhotoFileName,-18} {employee.SSN}");
        }

        // empty line
        Console.WriteLine();

        // ask the user to enter the employee id to delete
        Console.Write($"Enter the employee id to delete: ");
        var employeeID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        // SELECT * FROM Employees WHERE EmployeeID = employeeID
        var employeeToDelete = context.Employees.Find(employeeID);

        // if the employee id does not exist, display invalid input
        if (employeeToDelete == null)
        {
            Console.WriteLine($"Invalid input");
            return;
        }

        // delete the employee from the database
        context.Employees.Remove(employeeToDelete);
        context.SaveChanges();
        Console.WriteLine($"Data deleted from database successfully");
        Console.WriteLine();

        // would you like to delete more data? yes or no
        Console.Write($"Would you like to delete more data? - Yes or No: ");
        var decision1 = Console.ReadLine();

        if (decision1.ToUpper() == "YES")
        {
            // SELECT * FROM Employees
            var employees1 = context.Employees.ToList();

            // empty line
            Console.WriteLine();

            // displays the column names of the table
            Console.WriteLine($"{nameof(Employee.EmployeeID),-13} {nameof(Employee.EmployeeName),-15} {nameof(Employee.DepartmentName),-20} {nameof(Employee.DateofJoining),-16} {nameof(Employee.PhotoFileName),-18} {nameof(Employee.SSN)}");

            foreach (var employee1 in employees1)
            {
                Console.WriteLine($"{employee1.EmployeeID,-13} {employee1.EmployeeName,-15} {employee1}");
            }
        }
    }
}
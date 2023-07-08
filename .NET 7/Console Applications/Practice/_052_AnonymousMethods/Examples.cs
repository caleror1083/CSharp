using System;
using System.Collections.Generic;

namespace _052_AnonymousMethods;

internal class Examples
{
    public static void ProcessExamples()
    {
        Start:
            Console.Write($"Please select an example from 1: ");
            bool check = int.TryParse(Console.ReadLine(), out int choice);

            if (check)
            {
                switch (choice)
                {
                    case 1:
                        Example1();
                        break;
                    default:
                        Console.WriteLine($"Your choice is invalid");
                        goto Start;
                }
            }
            else
            {
                Console.WriteLine($"Selection chosen is incorrect");
                goto Start;
            }

        Decide:
            Console.Write($"Do you want to do another example? - Yes or No: ");
            var decision = Console.ReadLine();
            Console.WriteLine();

            switch (decision.ToUpper())
			{
				case "YES":
					goto Start;
				case "NO":
					break;
				default:
					Console.WriteLine($"Your decision is invalid. Try again");
					goto Decide;
			}
	}

	static void Example1()
	{
		var employees = new List<Employee>()
			{
				new Employee{ ID = 101, Name = "Mark" },
				new Employee{ ID = 102, Name = "John" },
				new Employee{ ID = 103, Name = "Mary" },
			};
		var info =  employees.Find(delegate(Employee emp)
        {
            return emp.ID == 102;
        });

		Console.WriteLine($"ID = {info.ID}, Name = {info.Name}");
	}
}
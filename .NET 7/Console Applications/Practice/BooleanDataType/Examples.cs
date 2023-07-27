using System;

namespace BooleanDataType;

internal class Examples
{
    public static void ProcessExamples()
    {
        Start:
            Console.Write($"Please select an example from 1-3: ");
            bool check = int.TryParse(Console.ReadLine(), out int choice);

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
            string decision = Console.ReadLine();
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
        var x = true;
        Console.WriteLine($"This is {x}");
    }

    static void Example2()
    {
        var a = 1;
        var b = 2;
        var greaterAB = (a > b);
        var equalA1 = (a == 1);

        if (greaterAB)
        {
            Console.WriteLine("A > B");
        }
        else
        {
            Console.WriteLine("A <= B");
        }

        Console.WriteLine($"greaterAB = {greaterAB}");
        Console.WriteLine($"equalA1 = {equalA1}");
    }

    static void Example3()
    {
        var isFemale = false;

        Console.WriteLine($"{isFemale}");
    }
}
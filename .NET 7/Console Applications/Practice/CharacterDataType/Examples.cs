using System;
using System.Text;

namespace CharacterDataType;

internal class Examples
{
    internal static void ProcessExamples()
    {
        Start:
            Console.Write($"Please select an example from 1-3: ");
            var check = int.TryParse(Console.ReadLine(), out int choice);

            if (check)
            {
                switch (choice)
                {
                    case 1:
                    {
                        Example1();
                        break;
                    }
                    case 2:
                    {
                        Example2();
                        break;
                    }
                    case 3:
                    {
                        Example3();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine($"Your choice is invalid");
                        goto Start;
                    }
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
                {
                    goto Start;
                }
                case "NO":
                {
                    break;
                }
                default:
                {
                    Console.WriteLine($"Your decision is invalid. Try again");
                    goto Decide;
                }
            }
    }

    static void Example1()
    {
        var myChar = 'A';
        Console.WriteLine($"The value of char is {myChar}");
    }

    static void Example2()
    {
        var unicodeChar = '\u002A'; // setting the unicode character to the value of 42 which is the asterisk (*) symbol
        Console.WriteLine($"{unicodeChar}");
    }

    static void Example3()
    {
        /* Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
              ©
             © ©
            ©   ©
           © © © ©
        */

        Console.OutputEncoding = Encoding.UTF8; // setting the console to UTF8 encoding because the default is ASCII encoding and it doesn't support the copyRight symbol in the console
        var copyRight = '\u00A9';

        Console.WriteLine($"   {copyRight}");
        Console.WriteLine($"  {copyRight} {copyRight}");
        Console.WriteLine($" {copyRight}   {copyRight}");
        Console.WriteLine($"{copyRight} {copyRight} {copyRight} {copyRight}");
    }
}
using System;
using System.Text;

namespace StringBuilderApp;

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

    private static void Example1()
    {
        var sentence = new StringBuilder("C#");
        sentence.Append(" video"); // Appends a string to the end of the string
        sentence.Append(" tutorial");
        sentence.Append(" for");
        sentence.Append(" beginners");
        Console.WriteLine($"{sentence}");
    }

    private static void Example2()
    {
        var customString = new StringBuilder("This is the first sentence.").AppendLine(); // Appends a new line to the end of the string
        customString.AppendFormat($"My name is {"Rob"} and I live in {"Paterson"}"); // Appends a formatted string
        customString.Replace("a", "e"); // Replaces all a's with e's
        customString.Remove(5, 7); // Removes 7 characters starting from the 5th character
        Console.WriteLine($"{customString}");
    }
}
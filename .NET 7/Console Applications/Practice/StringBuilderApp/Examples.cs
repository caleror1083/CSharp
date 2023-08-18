using System;
using System.Globalization;
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

    private static void Example1()
    {
        // Creates a new StringBuilder object with a string then appends other strings to the end of the string one after another
        var sentence = new StringBuilder("C#")
            .Append(" video")
            .Append(" tutorial")
            .Append(" for")
            .Append(" beginners");

        Console.WriteLine($"{sentence}");
    }

    private static void Example2()
    {
        // creates a new StringBuilder object with a string then appends a new line to the end of the string, append a formatted sting
        // replace all occurences of letter a with letter e and remove the substring index 5 and ending at index 12 (total of 7 characters will be removed)
        var customString = new StringBuilder("This is the first sentence.")
            .AppendLine()
            .AppendFormat($"My name is {"Rob"} and I live in {"Paterson"}")
            .Replace("a", "e")
            .Remove(5, 7);

        Console.WriteLine($"{customString}");
    }

    private static void Example3()
    {
        var a1 = new StringBuilder();
        var a2 = new StringBuilder(50); // Set max capacity to 50 characters
        var a3 = new StringBuilder("Yes", 0, 2, 70); // Set max capacity to 70 characters and set initial string to "Ye" with a length of 2 characters starting at index 0 of the string "Yes"
        var a4 = new StringBuilder(60, 100); // Set max capacity to 100 characters and set initial string to 60 characters
        var a5 = new StringBuilder("Random Text");
        var a6 = new StringBuilder("More stuff that is very important", 256); // Set max capacity to 256 characters and set initial string to "More stuff that is very important"
        
        Console.WriteLine(a1.Append(true)); // Append a boolean value to the end of the string
        a1.Clear();
        Console.WriteLine(a1.Append((byte)1)); // Append a byte value to the end of the string
        a1.Clear();
        Console.WriteLine(a1.Append('s')); // Append a char value to the end of the string
        a1.Clear();
        Console.WriteLine(a1.Append(new char[] {'a', 'e'})); // Append a char array to the end of the string
        a1.Clear();
        Console.WriteLine(a1.Append((decimal)4.5)); // Append a decimal value to the end of the string
        a1.Clear();
        Console.WriteLine(a1.Append(5.0)); // Append a double value to the end of the string
        a1.Clear();
        Console.WriteLine(a1.Append(6.0f)); // Append a float value to the end of the string
        a1.Clear();
        Console.WriteLine(a1.Append(8)); // Append an int value to the end of the string
        a1.Clear();
        Console.WriteLine(a1.Append('g', 2)); // Append a char value to the end of the string 2 times
        a1.Clear();
        Console.WriteLine(a2.Append(true));
        a2.Clear();
        Console.WriteLine(a3.Append(true));
        a3.Clear();
        Console.WriteLine(a4.Append(true));
        a4.Clear();

        unsafe
        {
            var myChar = 't';
            var myCharPointer = &myChar; // Get the address of the char variable
            Console.WriteLine(a1.Append(myCharPointer, 1)); // Append a char pointer to the end of the string
        }
        a1.Clear();
        Console.WriteLine(a1.Append(new char[] {'a', 'e'}, 0, 2)); // Append a char array to the end of the string starting at index 0 and ending at index 2
        a1.Clear();
        Console.WriteLine(a1.Append($"sk", 0, 2)); // Append a formatted string to the end of the string starting at index 0 and ending at index 2
        a1.Clear();

        Console.WriteLine($"The maximum number of characters for this StringBuilder object is: {a6.Capacity}"); // Get max capacity of the StringBuilder object
        Console.WriteLine($"The length of the StringBuilder object is: {a6.Length}"); // Get length of the StringBuilder object string value (not the max capacity)
        a6.AppendLine().AppendLine("More important text"); // Append a new line to the end of the string and append another string to the end of the string on a new line (2 lines total)

        var enUS = CultureInfo.CreateSpecificCulture("en-US"); // Define culture specific formatting
        var bestCustomer = "Bob Smith";
        a6.AppendFormat($"Worst customer {bestCustomer}").AppendLine().AppendFormat(enUS, $"Best Customer: {bestCustomer}");

        // Output StringBuilder
        Console.WriteLine(a6);
 
        // Replace a string
        a6.Replace("text", "characters");
        Console.WriteLine(a6);

        // Clear a string builder
        a6.Clear().Append("Random Text");
 
        // Are objects equal
        Console.WriteLine(a5.Equals(a6));
 
        // Insert at an index
        a6.Insert(11, " that's Great"); 
        Console.WriteLine($"Insert: {a6}");
 
        // Remove number of characters starting at index
        a6.Remove(11, 7);
        Console.WriteLine($"Remove: {a6}");
    }
}
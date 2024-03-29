﻿using System;

namespace IntegerDataType;

internal class Examples
{
    public static void ProcessExamples()
	{
	    Start:
		    Console.Write($"Please select an example from 1-31: ");
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
					case 4:
						Example4();
						break;
					case 5:
						Example5();
						break;
					case 6:
						Example6();
						break;
					case 7:
						Example7();
						break;
					case 8:
						Example8();
						break;
					case 9:
						Example9();
						break;
					case 10:
						Example10();
						break;
					case 11:
						Example11();
						break;
					case 12:
						Example12();
						break;
					case 13:
						Example13();
						break;
					case 14:
						Example14();
						break;
					case 15:
						Example15();
						break;
					case 16:
						Example16();
						break;
					case 17:
						Example17();
						break;
					case 18:
						Example18();
						break;
					case 19:
						Example19();
						break;
					case 20:
						Example20();
						break;
					case 21:
						Example21();
						break;
					case 22:
						Example22();
						break;
					case 23:
						Example23();
						break;
					case 24:
						Example24();
						break;
					case 25:
						Example25();
						break;
					case 26:
						Example26();
						break;
					case 27:
						Example27();
						break;
					case 28:
						Example28();
						break;
					case 29:
						Example29();
						break;
					case 30:
						Example30();
						break;
					case 31:
						Example31();
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

	private static void Example1()
	{
		Console.WriteLine($"{1}"); // Displaying an integer value
	}

	private static void Example2()
	{
		Console.WriteLine($"The largest value for an integer is: {int.MaxValue:N0}");    // Returns the largest possible value of an integer
	}

	private static void Example3()
	{
		Console.WriteLine($"The smallest value for an integer is: {int.MinValue:N0}");    // Returns the smallest possible value of an integer
	}

	private static void Example4()
	{
		Console.WriteLine($"The sum of these integers is: {5 + 5}"); // Displaying the sum of 2 integer values
	}

	private static void Example5()
	{
		Console.WriteLine($"The total is {(4 + 2) * 3}"); // Order of operations, parentheses first
	}

	private static void Example6()
	{
		Console.WriteLine($"The total is {4 + 2 * 3}"); // Order of operations, multiplication
	}

	private static void Example7()
	{
		int number = 1; // Integer variable declaration and initialization

		Console.WriteLine($"The integer value is: {number}");  // Displaying the value of the integer variable
	}

	private static void Example8()
	{
		Console.Write($"Enter a number: ");
		int number = int.Parse(Console.ReadLine());  // Explicit conversion - string to int - Converts the string value entered into an integer

		Console.WriteLine($"The value entered is: {number}");
	}

	private static void Example9()
	{
		Console.Write($"Enter a number: ");
		int number = int.Parse(Console.ReadLine()); 

		++number; // Prefix Incrementing the value of an integer by 1

		Console.WriteLine($"Incrementing the number entered by 1: {number}");
	}

	private static void Example10()
	{
		Console.Write($"Enter a number: ");
		int number = int.Parse(Console.ReadLine());

		number++; // Postfix Incrementing the value of an integer by 1

		Console.WriteLine($"Incrementing the number entered by 1: {number}");
	}

	static void Example11()
	{
		Console.Write($"Enter a number: ");
		int number = int.Parse(Console.ReadLine());

		number += 2; // Incrementing the value of an integer by 2

		Console.WriteLine($"Incrementing the number entered by 2: {number}");
	}

	private static void Example12()
	{
		Console.Write($"Enter a number: ");
		int number = int.Parse(Console.ReadLine());

		number--; // Decrementing the value of an integer by 1

		Console.WriteLine($"Decrementing the number entered by 1: {number}");
	}

	private static void Example13()
	{
		Console.Write($"Enter a first number: ");
		int number1 = int.Parse(Console.ReadLine());

		Console.Write($"Enter a second number: ");
		int number2 = int.Parse(Console.ReadLine());

		Console.WriteLine($"The sum of the values entered is: {number1 + number2}"); // Arithmetic can also be done with -, *, /, %
	}

	private static void Example14()
	{
		Console.Write($"Enter a number: ");
		int number = int.Parse(Console.ReadLine());

		Console.WriteLine($"The absolute value of the number entered is: {Math.Abs(number)}");  // Displays the absolute value
	}

	private static void Example15()
	{
		Console.Write($"Enter a first number: ");
		int number1 = int.Parse(Console.ReadLine());

		Console.Write($"Enter a second number: ");
		int number2 = int.Parse(Console.ReadLine());

		Console.WriteLine($"The maximum value between the 2 numbers entered is: {Math.Max(number1, number2)}"); // Returns the maximum value of 2 integers
	}

	private static void Example16()
	{
		Console.Write($"Enter a first number: ");
		int number1 = int.Parse(Console.ReadLine());

		Console.Write($"Enter a second number: ");
		int number2 = int.Parse(Console.ReadLine());

		Console.WriteLine($"The minimum value between the 2 numbers entered is: {Math.Min(number1, number2)}"); // Returns the minimum value of 2 integers
	}

	private static void Example17()
	{
		var numbers = new Random();
		Console.WriteLine($"Random integers between 1 to 10: {numbers.Next(1, 11)}"); // Returns random integers between 1 and 10
	}

	private static void Example18()
	{
		Console.Write($"How much money you got? ");
		int valueEntered = int.Parse(Console.ReadLine());  

		Console.WriteLine($"You got: {valueEntered, 0:C}"); // Returns currency numeric format string - value in a currency format with 2 decimal places
	}

	private static void Example19()
	{
		Console.Write($"Enter a number: ");
		int valueEntered = int.Parse(Console.ReadLine());

		Console.WriteLine($": {valueEntered, 0:D}"); // Returns the decimal numeric format string
	}

	private static void Example20()
	{
		Console.Write($"Enter a number: ");
		int valueEntered = int.Parse(Console.ReadLine());

        // Returns the fixed-point numeric format string - value with 2 decimal places. If a double is used, it rounds to the next highest number
		Console.WriteLine($"Number entered with 2 decimal places is: {valueEntered, 0:F}"); 
	}

	private static void Example21()
	{
		Console.Write($"Enter a number: ");
		int valueEntered = int.Parse(Console.ReadLine());

        // Returns the number numeric string format - integer value with commas and 2 decimal places
		Console.WriteLine($"Number entered with 2 decimal places is: {valueEntered, 0:N}"); 
	}

	private static void Example22()
	{
		Console.Write($"Enter a number: ");
		double valueEntered = double.Parse(Console.ReadLine());  // Explicit conversion - string to double - Converts the string value entered into a double

		Console.WriteLine($"Number entered with 2 decimal places is: {valueEntered, 0:#.00}"); // Returns the digit placeholder numeric format string
	}

	private static void Example23()
	{
		Console.Write($"Enter a number: ");
		string number = Console.ReadLine();

		bool conversion = int.TryParse(number, out int valueEntered);  // TryParse() returns a bool indicating whether it succeeded or failed

		if (conversion) // Checks whether the conversion from string to int was successful
		{
			Console.WriteLine($"{valueEntered}");
		}
		else
		{
			Console.WriteLine($"Please enter a valid integer value");
		} 
	}

	private static void Example24()
	{
		Console.WriteLine("Example 9: Implicit conversion from an int value to float");
		int num3 = 100;    // int variable declaration and instantiation
		float f = num3;    // implicit conversion - assign the value of the int to a float variable

		Console.WriteLine($"The integer value is {num3}");
		Console.WriteLine($"After conversion the float value is {f}");
	}


	private static void Example25()
	{
		// If you want to cast from one type to another
		long num10 = 1234;
		int num20 = (int)num10;

		Console.WriteLine($"Orig : {num10.GetType()}\nCast : {num20.GetType()}");
		Console.WriteLine("");
	}

	private static void Example26()
	{
		Console.WriteLine("Example 10: Converting Miles ran to Feet");
		const int yards_in_mile = 1760;    // Declare and assign a constant value to the variable
		const int feet_in_yard = 3;
		const int feet_in_mile = yards_in_mile * feet_in_yard;
		int num_miles; // Variable declaration

		Console.Write("How many miles did you run today? ");
		num_miles = int.Parse(Console.ReadLine());

		Console.WriteLine($"You ran {feet_in_mile * num_miles:N0} feet today!");
		Console.WriteLine();
	}

	private static void Example27()
	{
		Console.WriteLine("Example 11: Calculates the area of a frame");
		int out_length; // Variable declaration
		int out_width; // Variable declaration
		int in_length; // Variable declaration
		int in_width; // Variable declaration
		int total_area; // Variable declaration
		int inner_area; // Variable declaration
		int frame_area; // Variable declaration

		Console.Write("What is the outer length of the frame? "); // Writes the string to the console and stays on the same line
		out_length = Convert.ToInt32(Console.ReadLine()); // gets input from the user

		Console.Write("What is the outer width of the frame? "); // Writes the string to the console and stays on the same line
		out_width = Convert.ToInt32(Console.ReadLine()); // gets input from the user

		Console.Write("What is the inner length of the frame? "); // Writes the string to the console and stays on the same line
		in_length = Convert.ToInt32(Console.ReadLine()); // gets input from the user

		Console.Write("What is the inner width of the frame? "); // Writes the string to the console and stays on the same line
		in_width = Convert.ToInt32(Console.ReadLine()); // gets input from the user

		total_area = out_length * out_width; // Calculates the area of outer rectangle
		inner_area = in_length * in_width; // Calculates the area of the inner rectangle
		frame_area = total_area - inner_area; // Calculates the area of the frame
		Console.WriteLine($"The area of the border is: {frame_area:N0}"); // Displays the input from the user to the console
		Console.WriteLine();
	}

	private static void Example28()
	{
		/* Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
			* Print the variable values before and after the exchange. */

		Console.Write("Enter the value of the 1st number: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Enter the value of the 2nd number: ");
		int b = int.Parse(Console.ReadLine());

		Console.WriteLine($"The initial values of the variables are: {a}, {b}");
						
		(b, a) = (a, b);  // swaps the values of 2 integers using tuple
						
		Console.WriteLine($"After swapping, the values of the variables are: {a}, {b}");
	}

	private static void Example29()
	{
		// Declare some variables
		byte centuries = 20;     // A small number (up to 255)
		ushort years = 2000;     // A small number (up to 32767)
		uint days = 730480;      // A large number (up to 4.3 billion)
		ulong hours = 17531520;  // A very big number (up to 18 quintillion)

		// Print the result on the console
		Console.WriteLine($"{centuries} centuries is {years} years, or {days} days, or {hours} hours.");

		ulong maxIntValue = UInt64.MaxValue;
		Console.WriteLine($"{maxIntValue}");
	}

	private static void Example30()
	{
		/* Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, 
			short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, 
			-10000. Choose a large enough type for each number to ensure it will fit in it. */

		ushort variable1 = 52130;
		sbyte variable2 = -115;
		int variable3 = 4825932;
		byte variable4 = 97;
		short variable5 = -10000;

		// Print the result on the console
		Console.WriteLine($"The 5 variables are {variable1}, {variable2}, {variable3}, {variable4}, {variable5}");
	}

	private static void Example31()
	{
		/* Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). 
			* Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure that the result is “254”. */

		int hexadecimalVar = 0xFE;

		// Print the result on the console
		Console.WriteLine($"{hexadecimalVar}");
	}
}
	
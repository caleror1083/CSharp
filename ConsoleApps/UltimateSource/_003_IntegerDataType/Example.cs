// Robert Calero - App displaying Integral Data Types, Converting String values to Integers
using System;

class Example
	{
		public void PrintSomething()
			{
				int number = 23;    // int is an alias to fully qualified name - variable declaration and instantiation

				Console.WriteLine("Example 1: Adding 2 integer values");
				Console.WriteLine(1 + 1);    // adds 2 integer values
				Console.WriteLine();

				Console.WriteLine("Example 2: Order of operations with integer values: PEMDAS");
				Console.WriteLine((4 + 2) * 3);    // Order of operations, Parenthesis first
				Console.WriteLine(4 + 2 * 3);
				Console.WriteLine();

				Console.WriteLine("Example: var variable types");
				var num1 = 10;
				Console.Write($"The value of var is {num1}");    // displaying the value or a var value
				Console.WriteLine("\n");

			    // ----- IMPLICIT TYPING -----
				// You can use var to have C# figure out the 
				// data type
 
				var intVal = 1234;
				Console.WriteLine("intVal Type : {0}", intVal.GetType());

				Console.WriteLine("Example 3: Displaying the value of an int variable");
				Console.WriteLine($"This is number {number}");    // displaying the value of the int variable using string interpolation
				Console.WriteLine();

				Console.WriteLine("Example 4: Incrementing and Decrementing the value of an int variable");
				number++;    // increments the integer value by 1 via postfix increment operator
				Console.WriteLine($"This is number {number} incremented");

				number--;    // decrements the integer value by 1
				Console.WriteLine($"This is number {number} decremented");
				Console.WriteLine();

				Console.WriteLine("Example 5:Pre and postfix increment operators");
				// demonstrate postfix increment operator
				int c = 5; // assign 5 to c

				Console.WriteLine($"c before postincrement: {c}");
				Console.WriteLine($"    postincrementing c: {c++}");
				Console.WriteLine($" c after postincrement: {c}");
				Console.WriteLine(); // skip a line

				// demonstrate prefix increment operator
				int d = 10;
				Console.WriteLine($" d before preincrement: {d}");
				Console.WriteLine($"     preincrementing d: {++d}");
				Console.WriteLine($"  d after preincrement: {d}");

				int counter;
				counter = 5;
				Console.Write("\nCounter is " + counter);

				counter = 7;	// Change counter to 7
				Console.Write("\nCounter is " + counter);

				counter++;	// Increment counter by 1
				Console.Write("\nCounter is " + counter);

				counter += 1;	// Increment counter by 1 using compound assignment
				Console.Write("\nCounter is " + counter);

				counter += 1;	// Increment counter by 1 3rd alternate
				Console.Write("\nCounter is " + counter);

				counter--;	// Decrement counter by 1
				Console.Write("\nCounter is " + counter);

				counter += 2;	// Increment counter by 2 using compound assignment
				Console.Write("\nCounter is " + counter);

				counter += 2;	// Increment counter by 2 2nd alternate
				Console.Write("\nCounter is " + counter);

				counter *= 3;	// Multiply
				Console.Write("\nCounter is " + counter);

				counter /= 3;	// Division
				Console.Write("\nCounter is " + counter);

				counter %= 2;	// Modulus division, outputs remainder
				Console.WriteLine("\nCounter is " + counter);
				Console.WriteLine();

				Console.WriteLine("Example 6: Math operators with misc integer information");
				Console.WriteLine(Math.Abs(-40));    // displays the absolute value of a value
				Console.WriteLine(Math.Ceiling(40.7));    // displays the ceiling value of a value
				Console.WriteLine(Math.Floor(40.3));    // displays the floor value of a value
				Console.WriteLine(Math.Max(4, 90));    // displays the maximum value between two values
				Console.WriteLine(Math.Min(4, 90));    // displays the minimum value between two values
				Console.WriteLine(Math.Pow(3, 2));    // displays the result of 3 to the power of 2 aka 3 squared
				Console.WriteLine(Math.Sqrt(36));    // displays the square root of a value
				Console.WriteLine();

				Console.WriteLine($"The largest value for a 8-bit Integer is {sbyte.MaxValue:N0}");    // :N0 displays the value with commas  - unsigned (byte)
				Console.WriteLine($"The largest value for a 16-bit Integer is {short.MaxValue:N0}");    // unsigned (ushort)
				Console.WriteLine($"The largest value for a 32-bit Integer is {int.MaxValue:N0}");    // unsigned (uint)
				Console.WriteLine($"The largest value for a 64-bit Integer is {long.MaxValue:N0}");    // unsigned (ulong)
				Console.WriteLine();

				Console.WriteLine($"The smallest value for a 8-bit Integer is {sbyte.MinValue:N0}");
				Console.WriteLine($"The smallest value for a 8-bit Integer is {sbyte.MinValue:N0}");
				Console.WriteLine($"The smallest value for a 16-bit Integer is {short.MaxValue:N0}");
				Console.WriteLine($"The smallest value for a 32-bit Integer is {int.MinValue:N0}");
				Console.Write($"The smallest value for a 64-bit Integer is {long.MaxValue:N0}");
				Console.WriteLine("\n");

				Console.WriteLine("Example: Random numbers between 1-10");
				Random randx = new Random();
				Console.WriteLine("Random Number between 1 to 10: " + (randx.Next(1, 11))); // returns a random number
				Console.WriteLine();

				Console.WriteLine("Example: Formatting output values");
				double valuex;
				int value2x;

				valuex = 12345;
				value2x = 17;

				Console.WriteLine("Output number converted to currency = " + valuex.ToString("C"));
				Console.WriteLine("Alternate format to output number converted to currency = {0:C}", valuex);
				Console.WriteLine("Output number converted to decimal = " + value2x.ToString("D"));
				Console.WriteLine("Output number converted to exponential = " + valuex.ToString("E"));
				Console.WriteLine("Output number converted to fixed-point = " + valuex.ToString("F"));
				Console.WriteLine("Output number converted to general number = " + valuex.ToString("G"));
				Console.WriteLine("Output number converted to numeric = " + valuex.ToString("N"));
				Console.WriteLine("Output number converted to percent = " + valuex.ToString("P"));
				Console.WriteLine("Output number converted to round-trip = " + valuex.ToString("R"));
				Console.WriteLine("Output number converted to hexadecimal = " + value2x.ToString("X"));
				Console.WriteLine(" "); // Writes text to the console

				Console.WriteLine("Example 8: Adding two string values that were converted to int displaying the result");
				int num = int.Parse("100");    // Converts the String value into an Int
				int num2 = Convert.ToInt32("100");    // Converts the String value into an Int - alternate way
				Console.WriteLine($"Sum of converted numbers is {num + num2}");
				Console.WriteLine();

				Console.WriteLine("Example 9: Implicit conversion from an int value to float");
				int num3 = 100;    // int variable declaration and instantiation
				float f = num3;    // implicit conversion - assign the value of the int to a float variable

				Console.WriteLine($"The integer value is {num3}");
				Console.WriteLine($"After conversion the float value is {f}");
				Console.WriteLine();

				// ----- CASTING -----
				// If you want to cast from one type to another
				long num10 = 1234;
				int num20 = (int)num10;
 
				Console.WriteLine("Orig : {0} Cast : {1}", num10.GetType(), num20.GetType());
				Console.WriteLine("");

				Console.WriteLine("Example 7: Adding two int values were received from the user and displaying the result");
				System.Int32 number2;    // fully qualified name Int variable declaration
				int number3;
				int result;

				Console.Write("Enter your first number: ");      // Prompts the user for input
				number2 = int.Parse(Console.ReadLine());  // Waits for user input and converts the string into the Data type

				Console.Write("Enter your second number: ");
				number3 = Convert.ToInt32(Console.ReadLine());

				result = number2 + number3;    // adds the values entered by the user

				Console.WriteLine($"The sum of both numbers entered is {result:N0}");
				Console.WriteLine($"Alternate way to display sum without the use of result variable: {number2 + number3:N0}");    // alternate way to display sum without an extra variable
				Console.WriteLine();

				Console.WriteLine("Example 10: Converting Miles ran to Feet");
				const int yards_in_mile = 1760;    // Declare and assign a constant value to the variable
				const int feet_in_yard = 3;
				const int feet_in_mile = yards_in_mile * feet_in_yard;
				int num_miles; // Variable declaration

				Console.Write("How many miles did you run today? "); // Writes the string to the console and stays on the same line

				num_miles = Convert.ToInt32(Console.ReadLine()); // returns the value of number of miles

				Console.WriteLine($"You ran {feet_in_mile * num_miles:N0} feet today!"); // Displays the input from the user to the console 
				Console.WriteLine();

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

				Console.WriteLine("Example: Swapping value of 2 variables");
				int n1, n2, temp;

				Console.Write("Enter the value of the 1st number: ");
				n1 = int.Parse(Console.ReadLine());
				Console.Write("Enter the value of the 2nd number: ");
				n2 = int.Parse(Console.ReadLine());

				Console.WriteLine($"The initial values of the variables are: {n1}, {n2}");
				temp = n1;    // stores the initial value of the 1st number into temp
				n1 = n2;    // stores the initial value of 2nd number into number1
				n2 = temp;    // stores the temp value in number2
				Console.WriteLine($"After swapping, the values of the variables are: {n1}, {n2}");



			}
	}    // end class Print
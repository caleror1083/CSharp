// Robert Calero - App displaying text, escape sequences and verbatim literals
using System;

namespace _001_Print
	{
		class Print    // Class declaration - a class defines the variables and methods used by objects
			{
				public void PrintSomething()
					{
						Console.WriteLine("Example 1:");
						Console.WriteLine();    // fully qualified name using the System console object, displays blank line, goes to new line

						Console.WriteLine("Example 2:");
						Console.Write("Writes a string to the console followed by a newline escape sequence\n");    // alternate way to go to newline
						Console.WriteLine();

						Console.WriteLine("Example 3:");
						Console.WriteLine("Writes a string to the console followed by a new line");    // a statement
						Console.WriteLine();

						Console.WriteLine("Example 4:");
						Console.WriteLine("Displays \' in a string");    // display apostrophes in a string
						Console.WriteLine();

						Console.WriteLine("Example 5:");
						Console.WriteLine("Displays \" in a string");    // displays double quotes in a string
						Console.WriteLine();

						Console.WriteLine("Example 6:");
						Console.WriteLine(@"Displays "" in a string without using an escape sequence instead using verbatim string literal");    // Verbatim string literal
						Console.WriteLine();

						Console.WriteLine("Example 7:");
						Console.WriteLine("Makes \abell alert chime");    // makes bell alert chime
						Console.WriteLine();

						Console.WriteLine("Example 8:");
						Console.WriteLine("Displays a \thorizontal tab in a string");    // displays tabs in a string
						Console.WriteLine();

						Console.WriteLine("Example 9:");
						Console.WriteLine("Displays a \v vertical tab in a string");    // displays vertical tabs in a string
						Console.WriteLine();

						Console.WriteLine("Example 10:");
						Console.WriteLine("Displays \\ in a string");    // displays forward slashes in a string
						Console.WriteLine();

						Console.WriteLine("Example 11:");
						Console.WriteLine(@"Displays \ in a string without using an escape sequence instead using verbatim string literal");    // Verbatim string literal
						Console.WriteLine();

						Console.WriteLine("Example 12:");
						Console.WriteLine("This is a carriage return\r");    // carriage return
						Console.WriteLine();

						Console.WriteLine("Example 13:");
						Console.Write("Something"); // print without a newline
						Console.WriteLine(" else");
					}
			}    // end class Print
	}
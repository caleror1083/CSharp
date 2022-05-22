// Robert Calero - App displaying Float Data Types
using System;

class Print    // Class declaration - a class defines the variables and methods used by objects
	{
		public void PrintSomething()
			{
				Console.WriteLine("Example 1: Displaying float value");			
				float myFloat = 6.5F;    // (32-bit) approximately 6-9 digits
				Console.WriteLine($"The value of float is {myFloat}");
				Console.WriteLine();

				Console.WriteLine("Example 2: Explicit conversion from an float value to int");
				float f1 = 123.45F;    // variable declaration and instantiation
				int i = (int)f1;    // type cast operator - assigning the float value to an int
				int j = Convert.ToInt32(f1);    // using convert class - alternate way

				Console.WriteLine(i);
				Console.WriteLine(j);
			}    // end method
	}    // end class Print
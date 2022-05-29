// Robert Calero - App displaying double and decimal data type
using System;

class Print    // Class declaration - a class defines the variables and methods used by objects
	{
		public void Circle()
			{
				Console.WriteLine("Example 1: Displaying double value");
				double myDbl = 5.9;		// (64-bit) approximately 15-17 digits
				Console.WriteLine($"The value of double is {myDbl}");
				Console.WriteLine();

				Console.WriteLine("Example 2: Displaying decimal value");
				decimal myDecimal = 4.5M;	// (128-bit) approximately 28-29 digits
				Console.WriteLine($"The value of decimal is {myDecimal}");
				Console.WriteLine();

				Console.WriteLine("Example 3: The cost of a circular piece of land");
				const double pi = 3.14159; // Declare and assign a constant value to the variable
				double radius; // Variable declaration
				double area; // Variable declaration
				double cost; // Variable declaration
				double totalCost; // Variable declaration

				Console.Write("Please enter the radius of your circle? "); // Writes the string to the console and stays on the same line
				radius = Double.Parse(Console.ReadLine()); // gets input from the user

				Console.Write("Please enter the cost of your circle? "); // Writes the string to the console and stays on the same line
				cost = Double.Parse(Console.ReadLine()); // gets input from the user

				area = pi * Math.Pow(radius, 2); // Calculates the area of a circle
				totalCost = cost * area; // Multiples 2 variables and passes the value to another variable

				Console.WriteLine($"The circle of land will cost {totalCost, 4:C}"); // Displays the input from the user to the console
				Console.WriteLine();

				Console.WriteLine("Example 4:");
				double myDouble;

				Console.Write("Enter a double: ");
				myDouble = Double.Parse(Console.ReadLine());

				Console.WriteLine("Your value entered is " + string.Format("{0:N2}", myDouble));    // formats double value to 2 decimal places
				Console.WriteLine();

				Console.WriteLine("Example 5: Obtain 3 values and determine maximum value");    // Method Maximum with three parameters.
				Console.Write("Enter first floating-point value: ");
				double number1 = double.Parse(Console.ReadLine());
				Console.Write("Enter second floating-point value: ");
				double number2 = double.Parse(Console.ReadLine());
				Console.Write("Enter third floating-point value: ");
				double number3 = double.Parse(Console.ReadLine());

				// determine the maximum of three values
				double result = Maximum(number1, number2, number3);    // see maximum method

				// display maximum value 
				Console.WriteLine("Maximum is: " + result);
				Console.WriteLine();

				Console.WriteLine("Example 6: Finding the hypotenuse of a right triangle");
				double a;
				double b;
				double c;

				Console.Write("Enter side A: ");
				a = double.Parse(Console.ReadLine());

				Console.Write("Enter side B: ");
				b = double.Parse(Console.ReadLine());

				c = Math.Sqrt((a * a) + (b * b));

				Console.WriteLine($"The hypotenuse of this triangle is: {c:N2}");
				Console.WriteLine();

				Console.WriteLine("Example 7: Convert Fahrenheit to Celcius");
                double fahrenheit; // Variable declaration
                double celsius; // Variable declaration

                Console.Write("Please enter the amount in Fahrenheit? "); // Writes the string to the console and stays on the same line
                fahrenheit = Convert.ToDouble(Console.ReadLine()); // gets input from the user

                celsius = (fahrenheit - 32) * 5 / 9; // Calculates Fahrenheit to Celsius

                Console.WriteLine(fahrenheit + " Fahrenheit = " + celsius + " Celsius"); // Displays the input from the user to the console 
				Console.WriteLine();

				Console.WriteLine("Example 8: Calculates the time it takes 2 trains to meet");
                const int MINUTES_PER_HOUR = 60; // Assigns and declares a constant value to a variable
                double distance; // Variable declaration
                double speedTrain1; // Variable declaration
                double speedTrain2; // Variable declaration
                double minutes_to_meet; // Variable declaration
                double hr_to_meet; // Variable declaration

                Console.Write("What is the distance between trains in miles? "); // Writes the string to the console and stays on the same line
                distance = Convert.ToDouble(Console.ReadLine()); // gets input from the user

                Console.Write("What is the speed of the first train in MPH? "); // Writes the string to the console and stays on the same line
                speedTrain1 = Convert.ToDouble(Console.ReadLine()); // gets input from the user

                Console.Write("What is the speed of the second train in MPH? "); // Writes the string to the console and stays on the same line
                speedTrain2 = Convert.ToDouble(Console.ReadLine()); // gets input from the user

                hr_to_meet = distance / (speedTrain1 + speedTrain2); // Calculates the time to meet
                minutes_to_meet = hr_to_meet * MINUTES_PER_HOUR; // Calculates the minutes to meet
                Console.WriteLine(); // Writes a blank line to the console

                Console.WriteLine("It will take " + minutes_to_meet + " minutes for the trains to meet"); // Displays the input from the user to the console
                Console.WriteLine("The first train will travel " + (speedTrain1 * hr_to_meet) + " miles"); // Displays the input from the user to the console
                Console.WriteLine("The second train will travel " + (speedTrain2 * hr_to_meet) + " miles"); // Displays the input from the user to the console
				Console.WriteLine();

				Console.WriteLine("Example 9: Math operators with doubles");
				Console.WriteLine(Math.Round(4.5));    // returns the nearest integral value from a double value
				Console.WriteLine(Math.Round(4.6));    // returns the nearest integral value from a double value, midpoint value is rounded up
			}    // end method Circle

		static double Maximum(double x, double y, double z)							// returns the maximum of its three double parameters
			{ 
				double maximumValue = x; // assume x is the largest to start

				// determine whether y is greater than maximumValue 
				if (y > maximumValue) 
					{
						maximumValue = y; 
					}

				// determine whether z is greater than maximumValue 
				if (z > maximumValue) 
					{
						maximumValue = z; 
					}
				return maximumValue;
			}    // end method Maximum

		static void Example13()
					{
						Console.Write($"Enter a number: ");
						double number = double.Parse(Console.ReadLine());

						Console.WriteLine($"The ceiling value of the number entered is: {Math.Ceiling(number)}");  // Displays the ceiling value
					}

		static void Example14()
					{
						Console.Write($"Enter a number: ");
						double number = double.Parse(Console.ReadLine());

						Console.WriteLine(Math.Pow(3, 2));    // displays the result of 3 to the power of 2 aka 3 squared
						Console.WriteLine(Math.Sqrt(36));    // displays the square root of a value
						Console.WriteLine($"The ceiling value of the number entered is: {Math.Floor(number)}");  // Displays the ceiling value
					}
	}    // end class Print
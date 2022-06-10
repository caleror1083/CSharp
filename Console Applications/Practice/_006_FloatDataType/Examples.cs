// Robert Calero - App displaying Float Data Types
using System;

// Namespaces
namespace _006_FloatDataType
	{
		// Classes
		internal class Examples
			{
				// Methods(Parameters)
				public void ProcessExamples()
					{
						Start:
							Console.Write($"Please select an example from 1-29: ");
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
						float myFloat = 6.5F;    // (32-bit) approximately 6-9 digits
						Console.WriteLine($"The value of float is {myFloat}");  // Displaying float value
						Console.WriteLine();
					}

				static void Example2()
					{
						float floatPI = 3.14F;
						double doublePI = 3.14;
						double nan = double.NaN;
						double infinity = double.PositiveInfinity;

						Console.WriteLine($"{floatPI}");  // 3.14
						Console.WriteLine($"{doublePI}"); // 3.14
						Console.WriteLine($"{nan}");  // NaN
						Console.WriteLine($"{infinity}");  // Infinity
					}

				static void Example3()
					{
						// Declare some variables
						float floatPI = 3.141592653589793238f;
						double doublePI = 3.141592653589793238;

						// Print the results on the console
						Console.WriteLine("Float PI is: " + floatPI);
						Console.WriteLine("Double PI is: " + doublePI);
					}

				static void Example4()
					{
						float f = 0.1f;
						double d = 0.1f;
						float ff = 1.0f / 3;
						double dd = ff;
						
						Console.WriteLine(f); // 0.1 (correct due to rounding)
						Console.WriteLine(d); // 0.100000001490116 (incorrect)
						Console.WriteLine(ff); // 0.3333333 (correct due to rounding)
						Console.WriteLine(dd); // 0.333333343267441 (incorrect)
					}

				static void Example5()
					{
						float f1 = 123.45F;    // variable declaration and instantiation
						int i = (int)f1;    // type cast operator - assigning the float value to an int - Explicit conversion from an float value to int
						int j = Convert.ToInt32(f1);    // using convert class - alternate way

						Console.WriteLine(i);
						Console.WriteLine(j);
					}

				static void Example6()
					{
						double myDbl = 5.9;		// (64-bit) approximately 15-17 digits
						Console.WriteLine($"The value of double is {myDbl}"); // Displaying double value
						Console.WriteLine();
					}

				static void Example7()
					{
						// The cost of a circular piece of land
						const double pi = 3.14159; // Declare and assign a constant value to the variable

						Console.Write("Please enter the radius of your circle? "); // Writes the string to the console and stays on the same line
						double radius = Double.Parse(Console.ReadLine()); // gets input from the user

						Console.Write("Please enter the cost of your circle? "); // Writes the string to the console and stays on the same line
						double cost = Double.Parse(Console.ReadLine()); // gets input from the user

						double area = pi * Math.Pow(radius, 2); // Calculates the area of a circle
						double totalCost = cost * area; // Multiples 2 variables and passes the value to another variable

						Console.WriteLine($"The circle of land will cost {totalCost, 4:C}"); // Displays the input from the user to the console
						Console.WriteLine();
					}

				static void Example8()
					{
						Console.Write("Enter a double: ");
						double myDouble = Double.Parse(Console.ReadLine());

						Console.WriteLine("Your value entered is " + string.Format("{0:N2}", myDouble));    // formats double value to 2 decimal places
						Console.WriteLine();
					}

				static void Example9()
					{
						// Method Maximum with three parameters. - Obtain 3 values and determine maximum value
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
					}

				static double Maximum(double x, double y, double z)		// returns the maximum of its three double parameters
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
					}

				static void Example10()
					{
						// Finding the hypotenuse of a right triangle
						Console.Write("Enter side A: ");
						double a = double.Parse(Console.ReadLine());

						Console.Write("Enter side B: ");
						double b = double.Parse(Console.ReadLine());

						double c = Math.Sqrt((a * a) + (b * b));

						Console.WriteLine($"The hypotenuse of this triangle is: {c:N2}");
						Console.WriteLine();	
					}

				static void Example11()
					{
						// Convert Fahrenheit to Celcius
						Console.Write("Please enter the amount in Fahrenheit? "); // Writes the string to the console and stays on the same line
						double fahrenheit = Convert.ToDouble(Console.ReadLine()); // gets input from the user

						double celsius = (fahrenheit - 32) * 5 / 9; // Calculates Fahrenheit to Celsius

						Console.WriteLine(fahrenheit + " Fahrenheit = " + celsius + " Celsius"); // Displays the input from the user to the console 
						Console.WriteLine();
					}

				static void Example12()
					{
						// Calculates the time it takes 2 trains to meet
						const int MINUTES_PER_HOUR = 60; // Assigns and declares a constant value to a variable

						Console.Write("What is the distance between trains in miles? "); // Writes the string to the console and stays on the same line
						double distance = Convert.ToDouble(Console.ReadLine()); // gets input from the user

						Console.Write("What is the speed of the first train in MPH? "); // Writes the string to the console and stays on the same line
						double speedTrain1 = Convert.ToDouble(Console.ReadLine()); // gets input from the user

						Console.Write("What is the speed of the second train in MPH? "); // Writes the string to the console and stays on the same line
						double speedTrain2 = Convert.ToDouble(Console.ReadLine()); // gets input from the user

						double hr_to_meet = distance / (speedTrain1 + speedTrain2); // Calculates the time to meet
						double minutes_to_meet = hr_to_meet * MINUTES_PER_HOUR; // Calculates the minutes to meet
						Console.WriteLine(); // Writes a blank line to the console

						Console.WriteLine("It will take " + minutes_to_meet + " minutes for the trains to meet"); // Displays the input from the user to the console
						Console.WriteLine("The first train will travel " + (speedTrain1 * hr_to_meet) + " miles"); // Displays the input from the user to the console
						Console.WriteLine("The second train will travel " + (speedTrain2 * hr_to_meet) + " miles"); // Displays the input from the user to the console
						Console.WriteLine();
					}

				static void Example13()
					{
						// Math operators with doubles
						Console.WriteLine(Math.Round(4.5));    // returns the nearest integral value from a double value
					}

				static void Example14()
					{
						Console.Write($"Enter a number: ");
						double number = double.Parse(Console.ReadLine());

						Console.WriteLine($"The ceiling value of the number entered is: {Math.Ceiling(number)}");  // Displays the ceiling value
					}

				static void Example15()
					{
						Console.Write($"Enter a number: ");
						double number = double.Parse(Console.ReadLine());

						Console.WriteLine(Math.Pow(3, 2));    // displays the result of 3 to the power of 2 aka 3 squared
						Console.WriteLine(Math.Sqrt(12345));    // displays the square root of a value
						Console.WriteLine($"The ceiling value of the number entered is: {Math.Floor(number)}");  // Displays the ceiling value
					}

				static void Example16()
					{
						decimal myDecimal = 4.5M;	// (128-bit) approximately 28-29 digits
						Console.WriteLine($"The value of decimal is {myDecimal}");// Displaying decimal value
						Console.WriteLine();						
					}

				static void Example17()
					{
						decimal decimalPI = 3.14159265358979323846M;
						Console.WriteLine(decimalPI); // 3.14159265358979323846
					}
			}
	}
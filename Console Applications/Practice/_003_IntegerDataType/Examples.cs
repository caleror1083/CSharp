using System;

// Namespaces
namespace _003_IntegerDataType
	{
		// Classes
		class Examples
			{
				// Methods(Parameters)
				public void ProcessExamples()
					{
						Start:
							Console.Write($"Please select an example from 1-30: ");
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
						Console.WriteLine($"{1}"); // Displaying an integer value
					}

				static void Example2()
					{
						Console.WriteLine($"The largest value for an integer is: {int.MaxValue:N0}");    // Returns the largest possible value of an integer
					}

				static void Example3()
					{
						Console.WriteLine($"The smallest value for an integer is: {int.MinValue:N0}");    // Returns the smallest possible value of an integer
					}

				static void Example4()
					{
						Console.WriteLine($"The sum of these integers is: {5 + 5}"); // Displaying the sum of 2 integer values
					}

				static void Example5()
					{
						Console.WriteLine($"The total is {(4 + 2) * 3}"); // Order of operations, parentheses first
					}

				static void Example6()
					{
						Console.WriteLine($"The total is {4 + 2 * 3}"); // Order of operations, multiplication
					}

				static void Example7()
					{
						int number = 1; // Integer variable declaration and initialization

						Console.WriteLine($"The integer value is: {number}");  // Displaying the value of the integer variable
					}

				static void Example8()
					{
						Console.Write($"Enter a number: ");
						int number = int.Parse(Console.ReadLine());  // Explicit conversion - string to int - Converts the string value entered into an integer

						Console.WriteLine($"The value entered is: {number}");
					}

				static void Example9()
					{
						Console.Write($"Enter a number: ");
						int number = int.Parse(Console.ReadLine()); 

						++number; // Prefix Incrementing the value of an integer by 1

						Console.WriteLine($"Incrementing the number entered by 1: {number}");
					}

				static void Example10()
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

				static void Example12()
					{
						Console.Write($"Enter a number: ");
						int number = int.Parse(Console.ReadLine());

						number--; // Decrementing the value of an integer by 1

						Console.WriteLine($"Decrementing the number entered by 1: {number}");
					}

				static void Example13()
					{
						Console.Write($"Enter a first number: ");
						int number1 = int.Parse(Console.ReadLine());

						Console.Write($"Enter a second number: ");
						int number2 = int.Parse(Console.ReadLine());

						Console.WriteLine($"The sum of the values entered is: {number1 + number2}"); // Arithmetic can also be done with -, *, /, %
					}

				static void Example14()
					{
						Console.Write($"Enter a number: ");
						int number = int.Parse(Console.ReadLine());

						Console.WriteLine($"The absolute value of the number entered is: {Math.Abs(number)}");  // Displays the absolute value
					}

				static void Example15()
					{
						Console.Write($"Enter a first number: ");
						int number1 = int.Parse(Console.ReadLine());

						Console.Write($"Enter a second number: ");
						int number2 = int.Parse(Console.ReadLine());

						Console.WriteLine($"The maximum value between the 2 numbers entered is: {Math.Max(number1, number2)}"); // Returns the maximum value of 2 integers
					}

				static void Example16()
					{
						Console.Write($"Enter a first number: ");
						int number1 = int.Parse(Console.ReadLine());

						Console.Write($"Enter a second number: ");
						int number2 = int.Parse(Console.ReadLine());

						Console.WriteLine($"The minimum value between the 2 numbers entered is: {Math.Min(number1, number2)}"); // Returns the minimum value of 2 integers
					}

				static void Example17()
					{
						Random numbers = new Random();
						Console.WriteLine($"Random integers between 1 to 10: {numbers.Next(1, 11)}"); // Returns random integers between 1 and 10
					}

				static void Example18()
					{
						Console.Write($"How much money you got? ");
						int valueEntered = int.Parse(Console.ReadLine());  

						Console.WriteLine($"You got: {valueEntered, 0:C}"); // Returns currency numeric format string - value in a currency format with 2 decimal places
					}

				static void Example19()
					{
						Console.Write($"Enter a number: ");
						int valueEntered = int.Parse(Console.ReadLine());

						Console.WriteLine($": {valueEntered, 0:D}"); // Returns the decimal numeric format string
					}

				static void Example20()
					{
						Console.Write($"Enter a number: ");
						int valueEntered = int.Parse(Console.ReadLine());

						Console.WriteLine($"Number entered with 2 decimal places is: {valueEntered, 0:F}"); // Returns the fixed-point numeric format string - value with 2 decimal places. If a double is used, it rounds to the next highest number
					}

				static void Example21()
					{
						Console.Write($"Enter a number: ");
						int valueEntered = int.Parse(Console.ReadLine());

						Console.WriteLine($"Number entered with 2 decimal places is: {valueEntered, 0:N}"); // Returns the number numeric string format - integer value with commas and 2 decimal places
					}

				static void Example22()
					{
						Console.Write($"Enter a number: ");
						double valueEntered = double.Parse(Console.ReadLine());  // Explicit conversion - string to double - Converts the string value entered into a double

						Console.WriteLine($"Number entered with 2 decimal places is: {valueEntered, 0:#.00}"); // Returns the digit placeholder numeric format string
					}

				static void Example23()
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

				static void Example24()
					{
						Console.WriteLine("Example 9: Implicit conversion from an int value to float");
						int num3 = 100;    // int variable declaration and instantiation
						float f = num3;    // implicit conversion - assign the value of the int to a float variable

						Console.WriteLine($"The integer value is {num3}");
						Console.WriteLine($"After conversion the float value is {f}");
					}


				static void Example25()
					{
						// ----- CASTING -----
						// If you want to cast from one type to another
						long num10 = 1234;
						int num20 = (int)num10;
 
						Console.WriteLine("Orig : {0} Cast : {1}", num10.GetType(), num20.GetType());
						Console.WriteLine("");
					}

				static void Example26()
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

				static void Example27()
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

				static void Example28()
					{
						Console.Write("Enter the value of the 1st number: ");
						int number1 = int.Parse(Console.ReadLine());
						Console.Write("Enter the value of the 2nd number: ");
						int number2 = int.Parse(Console.ReadLine());

						Console.WriteLine($"The initial values of the variables are: {number1}, {number2}");
						
						(number2, number1) = (number1, number2);  // swaps the values of 2 integers using tuple
						
						Console.WriteLine($"After swapping, the values of the variables are: {number1}, {number2}");
					}
			}
	}
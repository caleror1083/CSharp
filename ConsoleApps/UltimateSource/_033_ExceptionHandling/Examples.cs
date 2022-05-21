// Robert Calero - App displaying exception handling
using System;

namespace _033_ExceptionHandling
	{
		class Examples
			{
				public void ProcessExamples()
					{
						try
							{
								int choice;
								string decision;

								Start:
									Console.Write("Please select an example from 1-5: ");
									choice = int.Parse(Console.ReadLine());

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
											default:
												Console.WriteLine("Your choice is invalid");
												goto Start;
										}
									Decide:
										Console.Write("Do you want to do another example? - Yes or No: ");
										decision = Console.ReadLine();
										Console.WriteLine();

										switch (decision.ToUpper())
											{
												case "YES":
													goto Start;
												case "NO":
													break;
												default:
													Console.WriteLine("Your decision is invalid. Try again");
													goto Decide;
											}
								}
							catch (Exception ex)
								{
									Console.WriteLine(ex.Message);
								}
					}

				public void Example1()    // We use exception handling to catch errors that could crash our program
					{
						System.IO.StreamReader myReader = null;    // Create a StreamReader object initialized to null

						try    // code that can possibly throw an exception
							{
								myReader = new System.IO.StreamReader(@"C:\Users\Rob C\Desktop\Learning Notebooks\CPU Programming\C Sharp\NET Framework\Console Applications\UltimateSource\_033_ExceptionHandling\bin\Debug\data.txt");    // instance of the StreamReader class to reads the contents of a file and streams it to the console - // File name parameter using verbatim string literal
								Console.WriteLine(myReader.ReadToEnd());    // read the contents of the StreamReader to the end of the file to the console screen
							}
						catch (System.IO.FileNotFoundException myException)    // if any line of code in the try block throws an exception we catch the error and warn the user rather then crash the program
							{
								Console.WriteLine($"Please check if the file {myException.FileName} exists");    // prints an exception message to the console
							}
						catch (Exception myException)    // general Exception class goes in the final catch block. This is the default catch all for exceptions
							{
								Console.WriteLine(myException.Message);    // prints an exception message to the console
							}
						finally    // finally block is optional. Finally always runs and provides for clean up
							{
								if (myReader != null)    // checks if the StreamReader is open
									{
										myReader.Close();    // closes the StreamReader
									}
							}
					}

				public void Example2()    // Dividing by 0
					{
						try
							{
								Console.Write("Divide 10 by ");
								int num = int.Parse(Console.ReadLine());

								Console.WriteLine($"{10 / num}");    // exception will be thrown at this line if there is an error
							}
						catch (DivideByZeroException ex)    // if any line of code in the try block throws an exception we catch the error and warn the user rather then crash the program
							{
								Console.WriteLine($"{ex.Message} Try again - aka as {ex.GetType().Name}");
							}
						catch (Exception ex)
							{
								Console.WriteLine(ex.GetType().Name);
								Console.WriteLine(ex.Message);
							}
					}

				public void Example3()    // Inner Exceptions
					{
						try
							{
								try
									{
										Console.Write("Enter first number: ");     // prompt the user for first number
										int fn = int.Parse(Console.ReadLine());    // read from the console

										Console.Write("Enter second number: ");    // prompt the user for second number
										int sn = int.Parse(Console.ReadLine());    // read from console

										int quotient = (fn / sn);
										Console.WriteLine($"The result is {quotient}");    // Display the result in the console
									}
								catch (Exception ex)    // exception thrown if anything above is incorrect
									{
										string filePath = @"C:\Users\Rob C\Desktop\Learning Notebooks\CPU Programming\C Sharp\NET Framework\Console Applications\UltimateSource\_033_ExceptionHandling\bin\Debug\log1.txt";

										if (System.IO.File.Exists(filePath))    // if FilePath above exists write the exception information to the file
											{
												System.IO.StreamWriter myWriter = new System.IO.StreamWriter(filePath);

												myWriter.Write($"{ex.Message} Try again - aka as {ex.GetType().Name}");    // writes the type of exception
												myWriter.Close();
												Console.WriteLine("There is a problem, try again");
											}
										else    // if FilePath does not exist, throw a new exception but retain the original exception information above
											{
												throw new System.IO.FileNotFoundException($"{filePath} is not present", ex);
											}
									}
							}
						catch (Exception myException)
							{
								if (myException.InnerException != null)
									{
										Console.WriteLine($"Inner exception: {myException.InnerException.Message}");
									}
								Console.WriteLine($"Current exception: {myException.GetType().Name}");
							}
					}

				public void Example4()    // Preventing exception handling abuse
					{
						int numerator, denominator, result;
						bool isNumerator, isDenominator;
						try
							{
								Console.Write("Enter numerator: ");    // prompt the user for first number
								isNumerator = int.TryParse(Console.ReadLine(), out numerator);

								if (isNumerator)
									{
										Console.Write("Enter denominator: ");    // prompt the user for second number
										isDenominator = int.TryParse(Console.ReadLine(), out denominator);

										if (isDenominator && denominator != 0)
											{
												result = (numerator / denominator);
												Console.WriteLine($"The result is {result}");    // Display the result in the console
											}
										else
											{
												if (denominator == 0)    // DivideByZeroException prevention
													{
														Console.WriteLine("Denominator cannot be zero");
													}
												else    // FormatException and OverflowException prevention
													{
														Console.WriteLine($"Denominator should be a valid number between {int.MinValue:N0} and {int.MaxValue:N0}");
													}
											}
									}
								else    // FormatException and OverflowException prevention
									{
										Console.WriteLine($"Numerator should be a valid number between {int.MinValue:N0} and {int.MaxValue:N0}");
									}
							}
						catch (Exception ex)    // exception thrown if anything above is incorrect
							{
								Console.WriteLine(ex.Message);
							}
					}

				public void Example5()    // Custom Exceptions
					{
						throw new UserLoggedInException("User already logged in");
					}
			}
	}
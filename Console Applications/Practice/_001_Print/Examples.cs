using System;

// Namespaces
namespace _001_Print
	{
		// Classes
		internal class Examples
			{
				// Methods(Parameters)
				public void ProcessExamples()
					{
						Start:
							Console.Write($"Please select an example from 1-15: ");
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
						Console.Write($"Writes a string to the console followed by a newline escape sequence\n");    // alternate way to go to newline
					}

				static void Example2()
					{
						Console.WriteLine();    // displays blank line, goes to new line
					}

				static void Example3()
					{
						Console.WriteLine($"Writes a string to the console followed by a new line");    // a statement
					}

				static void Example4()
					{
						Console.WriteLine($"Displays \' in a string");    // display apostrophes in a string
					}

				static void Example5()
					{
						Console.WriteLine($"Displays \" in a string");    // displays double quotes in a string
					}

				static void Example6()
					{
						Console.WriteLine(@"Displays "" in a string without using an escape sequence instead using verbatim string literal");    // Verbatim string literal
					}

				static void Example7()
					{
						Console.WriteLine($"Makes \abell alert chime");    // makes bell alert chime
					}

				static void Example8()
					{
						Console.WriteLine($"Displays a \t horizontal tab in a string");    // displays a 4 space horizontal tab in a string
					}

				static void Example9()
					{
						Console.WriteLine($"Displays a \v vertical tab in a string");    // displays vertical tabs in a string
					}

				static void Example10()
					{
						Console.WriteLine($"Displays \\ in a string");    // Displays a forward slash in a string
					}

				static void Example11()
					{
						Console.WriteLine(@"Displays \ in a string without using an escape sequence instead using verbatim string literal");    // Verbatim string literal
					}

				static void Example12()
					{
						Console.Write($"This is a carriage return\r");    // carriage return
					}

				static void Example13()
					{
						Console.Write($"Something"); // print without a newline
						Console.WriteLine(" else");
					}

				static void Example14()
					{
						Console.WriteLine($"Something " +
						                   $"else");       // Display 1 line of text in multiple lines of code
					}

				static void Example15()
					{
						Console.WriteLine($"Good day!");
					}
			}
	}
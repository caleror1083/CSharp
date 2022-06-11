// Robert Calero - App displaying Character Data Type
using System;

// Namespaces
namespace _005_CharacterDataType
	{
		// Classes
		class Examples
			{
				// Methods(Parameters)
				public void ProcessExamples()
					{
						Start:
							Console.Write($"Please select an example from 1-2: ");
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
						char myChar = 'A';

						Console.WriteLine($"The value of char is {myChar}");
					}

				static void Example2()
					{
						/* Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) 
						 * using the '\u00XX' syntax, and then print it. Hint: first, use the Windows Calculator to find 
						 * the hexadecimal representation of 42. The output should be “*”. */	

						char unicodeChar = '\u002A';
						Console.WriteLine($"{unicodeChar}");
					}
			}
	}
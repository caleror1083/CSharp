using System;

// Namespaces
namespace _004_BooleanDataType
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
						bool x = true;    // (8-bit)

						Console.WriteLine($"This is {x}");
					}

				static void Example2()
					{
						// Declare some variables
						int a = 1;
						int b = 2;
						
						// Which one is greater?
						bool greaterAB = (a > b);
						
						// Is 'a' equal to 1?
						bool equalA1 = (a == 1);
						
						// Print the results on the console
						if (greaterAB)
							{
								Console.WriteLine("A > B");
							}
						else
							{
								Console.WriteLine("A <= B");
							}
						Console.WriteLine("greaterAB = " + greaterAB);
						Console.WriteLine("equalA1 = " + equalA1);
					}
			}
	}
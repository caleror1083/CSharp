using System;

namespace _038_EqualsMethod
	{
		internal class Examples
			{
				public void ProcessExamples()
					{
						bool check;
						string decision;

						Start:
							Console.Write("Please select an example from 1: ");
							check = int.TryParse(Console.ReadLine(), out int choice);

							if (check)
								{
									switch (choice)
										{
											case (int)ExamplesEnum.Example1:
												Example1();
												break;
											default:
												Console.WriteLine("Your choice is invalid");
												goto Start;
										}
								}
							else
								{
									Console.WriteLine($"Selection chosen is incorrect");
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

				public static void Example1()
					{
						ExamplesInfo customer1 = new ExamplesInfo();
						ExamplesInfo customer2 = new ExamplesInfo();

						Console.Write($"What is your first name? ");
						customer1.FirstName = Console.ReadLine();

						Console.Write($"What is your last name? ");
						customer1.LastName = Console.ReadLine();

						Console.Write($"What is your first name? ");
						customer2.FirstName = Console.ReadLine();

						Console.Write($"What is your last name? ");
						customer2.LastName = Console.ReadLine();

						Console.WriteLine(customer1 == customer2);       // Reference equality
						Console.WriteLine(customer1.Equals(customer2));  // Value equality
					}
			}
	}
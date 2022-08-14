using System;
using System.Collections;

// Namespaces
namespace _045_Collections_Objects_ArrayList
	{
		// Classes
		internal class Examples
			{
				// Methods(Parameters)
				public void ProcessExamples()
					{
						Start:
							Console.Write($"Please select an example from 1: ");
							bool check = int.TryParse(Console.ReadLine(), out int choice);

							if (check)
								{
									switch (choice)
										{
											case 1:
												Example1();
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
						int[] integers = new int[5];  // Create an array of type integer with 5 elements and add values later
						ArrayList employees = new ArrayList(3);

						for (int i = 0; i < employees.Capacity; i++)
							{
								employees.Add(i + 5);
							}

						for (int i = 0; i < integers.Length; i++)
							{
								Console.WriteLine(Convert.ToString(integers[i]));
							}

						for (int i = 0; i < employees.Capacity; i++)
							{
								Console.WriteLine(Convert.ToString(employees[i]));
							}
					}
			}
	}
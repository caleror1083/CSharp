using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_MultiDimensionalArrays_Jagged
	{
		internal class Examples
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
						// Dclaring and initializing a string array to stor employee names
						string[] employeeNames = new string[3] {
						                                           "Mark",
																   "Matt",
																   "John"
															   };

						// Declaring a jagged array
						string[][] qualifications = new string[3][];
						qualifications[0] = new string[3];
						qualifications[1] = new string[1];
						qualifications[2] = new string[2];

						// Initializing the jagged array
						qualifications[0][0] = "Bachelors";
						qualifications[0][1] = "Masters";
						qualifications[0][2] = "Doctorate";

						qualifications[1][0] = "Bachelors";

						qualifications[2][0] = "Bachelors";
						qualifications[2][1] = "Masters";

						// Iterate through the jagged array and print the values within each array
						for (int index = 0; index < qualifications.Length; index++)
							{
								Console.WriteLine(employeeNames[index]);
								Console.WriteLine("--------");
								string[] innerQualifications = qualifications[index];
								for (int innerIndex = 0; innerIndex < innerQualifications.Length; innerIndex++)
									{
										Console.WriteLine(innerQualifications[innerIndex]);
									}
								Console.WriteLine();
							}
					}

				static void Example2()
					{
						// Declaring and initializing a jagged array
						string[][] qualifications = new string[3][] {
						                                                new string[] {"Bachelors", "Masters", "Doctorate"},
														                new string[] {"Bachelors"},
														                new string[] {"Bachelors", "Masters"}
						                                             };

						// Iterate through the jagged array and print the values within each array
						for (int index = 0; index < qualifications.Length; index++)
							{
								string[] innerQualifications = qualifications[index];
								for (int innerIndex = 0; innerIndex < innerQualifications.Length; innerIndex++)
									{
										Console.WriteLine(innerQualifications[innerIndex]);
									}
								Console.WriteLine();
							}
					}

			}
	}
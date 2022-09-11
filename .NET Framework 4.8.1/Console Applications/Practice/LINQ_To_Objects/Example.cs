using System;
using System.Collections.Generic;
using System.Linq;

// Namespaces
namespace LINQ_To_Objects
	{
		// Classes
		internal class Example
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
						int[] numbersArray = new int[] { 3, 5, 7, 8, 9, 11, 16, 19, 23, 26 };

						// LINQ Query to retrieve a range of values from array
						IEnumerable<int> NumRange = from index in numbersArray
										            where (index > 8 && index < 23)
										            select index;

						// display array values greater than 8 and less than 23
						foreach (int numbers in NumRange)
							{
								Console.WriteLine(numbers);
							}
					}

				static void Example2()
					{
						int[] numbers = new int[] { 4, 2, 67, 1, 23, 6, 36, 7, 9, 10, 43, 29, 12, 65, 37 };  // create an array of integers

						// display original array values
						Console.Write("Original array:");
						foreach (int element in numbers)
							{
								Console.Write($" {element}");
							}

						// LINQ query to get values larger than 7 from the array
						IEnumerable<int> filtered = from value in numbers
						                            where value > 7
									                select value;

						// display filtered values of integers greater than 7
						Console.Write("\nArray values greater than seven:");
						foreach (int element in filtered)
							{
								Console.Write($" {element}");
							}

						// LINQ query to get values larger than 7 from the array
						IEnumerable<int> sorted = from value in numbers
						                          orderby value
									              select value;

						// display sorted integers
						Console.Write("\nSorted array:");
						foreach (int element in sorted)
							{
								Console.Write($" {element}");
							}

						// LINQ query to sort filtered in descending order
						IEnumerable<int> sortFilteredDesc = from value in filtered
						                                    orderby value descending
									                        select value;

						// display sorted integers
						Console.Write("\nIntegers greater than seven sorted in descending order:");
						foreach (int element in sortFilteredDesc)
							{
								Console.Write($" {element}");
							}

						// LINQ query to filter and sort original array
						IEnumerable<int> filterAndSort = from value in numbers
						                                 where value > 7
						                                 orderby value ascending
									                     select value;

						// display filtered and sorted integers
						Console.Write("\nIntegers greater than seven sorted in ascending order:");
						foreach (int element in filterAndSort)
							{
								Console.Write($" {element}");
							}
						Console.WriteLine();
					}
			}
	}
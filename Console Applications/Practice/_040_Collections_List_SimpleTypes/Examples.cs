// Robert Calero - App displaying arrays
using System;
using System.Collections.Generic;
using System.Linq;

namespace _040_Collections_List_SimpleTypes
	{
		class Examples
			{
				public void ProcessExamples()
						{
							bool check;
							string decision;

						Start:
							Console.Write("Please select an example from 1-9: ");
							check = int.TryParse(Console.ReadLine(), out int choice);

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

				static void Example1()
					{
						// Declaration and initialization of list
						List<int> numbers = new List<int>() { 5, 15, 25 };

						// Statements
						Console.WriteLine(numbers[0]);    // displays the value of the 1st element in the list
					}

				static void Example2()
					{
						List<int> numbers = new List<int>() { 5, 15, 25 };    // declaration and initialization of list

						numbers.Insert(1, 10);
						numbers.Remove(5);
						numbers.RemoveAt(2);

						Console.WriteLine($"5 in list? {numbers.Contains(5)}");
					}

				static void Example3()
					{
						List<int> numbers = new List<int>(new int[] { 1, 2, 3, 4 });

						Console.WriteLine($"The first occurence of the number 4 is at index {numbers.IndexOf(4)}");
					}

				static void Example4()
					{
						List<string> names = new List<string>(new string[] { "Tom", "Paul" });

						Console.WriteLine($"Tom in list {names.Contains("tom", StringComparer.OrdinalIgnoreCase)}");  // searches the list to find a specific value and compares it to a specific value
					}

				static void Example5()
					{
						List<int> numbers = new List<int>() { 5, 15, 25 };
						int[] randArray = new int[] { 1, 2, 3, 4, 5, 6 };

						numbers.AddRange(randArray);    // Adds the elements of the array to end end of the list

						for (int index  = 0; index < numbers.Count; index++)
							{
								Console.WriteLine(numbers[index]);
							}
					}

				static void Example6()
					{
						List<int> numbers = new List<int> { 1, 10, 100 };

						numbers.RemoveAt(2);    // remove element at index 2

						foreach (int index in numbers)    // loops through the integer list writing every element
							{
								Console.WriteLine(index);
							}
					}

				static void Example7()
					{
						List<int> integers = new List<int> { 1, 4, 7, 3, 4, 5, 0, 6 };
						List<string> strings = new List<string> { "F", "C", "B", "G", "A", "H", "D", "E" };

						integers.Sort();
						strings.Sort();
						
						Console.WriteLine($"{string.Join(", ", integers)}");
						Console.WriteLine($"{string.Join(", ", strings)}");
					}

				static void Example8()
					{
						List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };
						
						Console.WriteLine($"Numbers before sorting");
						foreach (int number in numbers)  // iterate through all the items in the collection
							{
								Console.Write($"{number} ");
							}
						Console.WriteLine();
						Console.WriteLine();
						numbers.Sort();  // sorts the elements in the entire list

						Console.WriteLine($"Numbers after sorting");
						foreach (int number in numbers)  // iterate through all the items in the collection
							{
								Console.Write($"{number} ");
							}
						Console.WriteLine();
						Console.WriteLine();
						numbers.Reverse();  // displays the elements in reverse order

						Console.WriteLine($"Numbers reversed");
						foreach (int number in numbers)  // iterate through all the items in the collection
							{
								Console.Write($"{number} ");
							}
						Console.WriteLine();
					}

				static void Example9()
					{
						List<string> alphabet = new List<string> { "B", "F", "D", "E", "A", "C" };
						
						Console.WriteLine($"Letters before sorting");
						foreach (string letter in alphabet)  // iterate through all the items in the collection
							{
								Console.Write($"{letter} ");
							}
						Console.WriteLine();
						Console.WriteLine();
						alphabet.Sort();  // sorts the elements in the entire list

						Console.WriteLine($"Letters after sorting");
						foreach (string letter in alphabet)  // iterate through all the items in the collection
							{
								Console.Write($"{letter} ");
							}
						Console.WriteLine();
						Console.WriteLine();
						alphabet.Reverse();  // displays the elements in reverse order

						Console.WriteLine($"Letters reversed");
						foreach (string letter in alphabet)  // iterate through all the items in the collection
							{
								Console.Write($"{letter} ");
							}
						Console.WriteLine();
					}
			}
	}
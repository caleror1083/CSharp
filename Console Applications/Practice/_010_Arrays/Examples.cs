// Robert Calero - App displaying arrays
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

// Namespace
namespace _010_Arrays
	{
		// Classes
		internal class Examples    // Class declaration - a class defines the variables and methods used by objects
			{
				// Methods(Parameters)
				public void ProcessExamples()
						{
							bool check;
							string decision;

						Start:
							Console.Write("Please select an example from 1-28: ");
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
						int[] integers = new int[5];  // Create an array of type integer with 5 elements and add values later
						Employee[] employees = new Employee[3];

						for (int i = 0; i < employees.Length; i++)
							{
								employees[i] = new Employee(i + 5);
							}

						for (int i = 0; i < integers.Length; i++)
							{
								Console.WriteLine(Convert.ToString(integers[i]));
							}

						for (int i = 0; i < employees.Length; i++)
							{
								Console.WriteLine(Convert.ToString(employees[i]));
							}
					}
					
				static void Example2()
					{
						int[] EvenNumbers = new int[3] { 0, 2, 4 };    // declaration and instantiation of an array holding 3 integers - Arrays have fixed sizes
						int[] OddNumbers = new int[3] { 1, 3, 5 };    // create an array of elements and adding values right away

						Console.WriteLine($"The value of the 2nd index of EvenNumbers array is {EvenNumbers[1]}");    // writes the value of an element of array
						Console.WriteLine($"The value of the last index of OddNumbers array is {OddNumbers[2]}");					}

				static void Example3()
					{
						var luckyNumbers = new[] { 1, 3, 5 };    // You can use var to create arrays, but the values must be of the same type

						Console.WriteLine($"Values for luckyNumbers array is: { luckyNumbers[0]}, {luckyNumbers[1]}, {luckyNumbers[2]}");    // prints the values of current index in the array
					}

				static void Example4()
					{
						int[] luckyNumbers = new int[5] { 10, 20, 30, 40, 50 };
						int indexCounter = 0;

						while (indexCounter < luckyNumbers.Length)    // checks the indexCounter to the total length of the array - index values printed using while loop
							{
								Console.WriteLine(luckyNumbers[indexCounter]);    // prints the value of the current index in the loop
								indexCounter++;
							}
					}
					
				static void Example5()
					{
						int[] luckyNumbers = new int[5] { 10, 20, 30, 40, 50 };

						for (int indexCounter = 0; indexCounter < luckyNumbers.Length; indexCounter++)    // index values printed using for loop
							{
								Console.WriteLine($"At index {indexCounter} the value of the array is {luckyNumbers[indexCounter]}");
							}
						Console.WriteLine();
					}

				static void Example6()
					{
						string[] peopleNames = new string[3] { "Bob", "Mary", "Lance" };

						foreach (string value in peopleNames)    // index values printed using foreach loop
							{
								Console.WriteLine(value);
							}
					}
				
				static void Example7()
					{
						string[] names = new string[3] { "Mark", "Steve", "Adam" };
						Console.WriteLine($"Name list: {string.Join(", ", names)}");   // concatenates all values in a string array
					}

				static void Example8()
					{
						int[] luckyNumbers = new int[5] { 10, 20, 30, 40, 50 };
						int indexCounter = 0;

						do                                                         // prints the values of the current index using do while loop
							{
								Console.WriteLine(luckyNumbers[indexCounter]);
								indexCounter++;
							}
						while (indexCounter < luckyNumbers.Length);
					}

				static void Example9()
					{
						int[] luckyNumbers = new int[5] { 10, 20, 30, 40, 50 };

						Console.WriteLine($"The length of the array is {luckyNumbers.Length}");    // writes the integer value of the length of array
						Console.WriteLine($"The value of the 1st index in array is {luckyNumbers[0]}");  // writes the value of the first element of array
						Console.WriteLine($"What index is the 3rd value located at in the array? Index {Array.IndexOf(luckyNumbers, 30)}");  // writes the index of the array if the value is found
					}

				static void Example10()
					{
						// Can you store different types in an array? Yes
						object[] randomArray = new object[3] { "Paul", 45, 1.234 };    // Create an array of base objects which is the base type of all other types
		
						foreach (object value in randomArray)    // displays the element, value and type for each index in the array using foreach loop
							{
								Console.WriteLine($"At index {Array.IndexOf(randomArray, value)} the value of the array is {value} with a type of {value.GetType()}");
							}
					}

				static void Example11()
					{
						int[] numbers = new int[4] { 1, 4, 9, 2 };

						PrintArray(numbers, $"Value is");    // You can pass an array to a method that displays the value of each element in an array
					}

				static void Example12()
					{
						int[] numbers = new int[4] { 9, 1, 4, 2 };

						Array.Sort(numbers);    // Method to sort an array

						foreach (int value in numbers)
							{
								Console.Write($"{value} ");
							}
					}

				static void Example13()
					{
						int[] numbers = new int[4] { 9, 1, 4, 2 };

						Array.Reverse(numbers); // Reverse array

 						foreach (int value in numbers)
							{
								Console.Write($"{value} ");
							}
						Console.WriteLine($"\nAfter reversing the array value 1 is at index {Array.IndexOf(numbers, 1)}");    // Get index of match or return -1
					}

				static void Example14()
					{
						int[] numbers = new int[4] { 9, 1, 4, 2 };

						numbers.SetValue(0, 1);    // Change value at index 1 to 0
  						
						foreach (int value in numbers)
							{
								Console.Write($"{value} ");
							}
						Console.WriteLine();
					}

				static void Example15()
					{
						// Copy part of an array to another
						int[] startingArray = new int[3] { 10, 20, 30 };
						int[] finishingArray = new int[2];
						int startIndex = 0;
						int length = 2;
 
						Array.Copy(startingArray, startIndex, finishingArray, startIndex, length);
						PrintArray(finishingArray, "Copied value");
						Console.WriteLine();
					}

				static void PrintArray(int[] intArray, string message)
					{
						foreach (int arrayValue in intArray)
							{
								Console.WriteLine($"{message} {arrayValue}");
							}
					}

				static void Example16()
					{
						int[] numbers = new int[3] { 10, 20, 30 };
						Array blankArray = Array.CreateInstance(typeof(int), 10);    // Create an array with CreateInstance, int array with 10 elements

						numbers.CopyTo(blankArray, 5);    // Copy values in numbers array to blankArray starting at index 5
 
						foreach (int value in blankArray)
							{
								Console.WriteLine($"Copied value {value}");
							}
						Console.WriteLine();
					}

				static void Example17()
					{
						int[] numbers = new int[3] { 1, 11, 22 };    // Search for an element that matches the conditions defined by the specified predicate
						Console.WriteLine($"Values greater than 10 in the array are: {Array.Find(numbers, ValuesGreaterThan10)}");    // FindAll returns an array with all values that match - FindIndex returns the index of the match
					}

				static bool ValuesGreaterThan10(int values)
					{
						return values > 10;
					}
					
				static void Example18()    // Insertion sort
					{
						int[] numbers = new int[5] { 12, 11, 13, 5, 6 };

						Console.WriteLine("Before sorting the array the values are: ");
						for (int index = 0; index < numbers.Length; index++)
							{
								Console.Write($"{numbers[index]} ");
							}
						Console.WriteLine();

						for (int insertion = 1; insertion < numbers.Length; insertion++)    // performs the insertion sort
							{
								int key = numbers[insertion];
								int index = insertion - 1;

								while (index >= 0 && numbers[index] > key)    // moves the elements of array that are greater than key to one position ahead of their current position
									{
										numbers[index + 1] = numbers[index];
										index--;
									}
								numbers[index + 1] = key;
							}

						Console.WriteLine("After sorting the array the values are: ");
						for (int index = 0; index < numbers.Length; index++)
							{
								Console.Write($"{numbers[index]} ");
							}
						Console.WriteLine();
					}

				static void Example19()    // Selection sort
					{
						int[] numbers = new int[5] { 120, 110, 130, 50, 60 };

						Console.WriteLine("Before sorting the array the values are: ");
						for (int index = 0; index < numbers.Length; index++)
							{
								Console.Write($"{numbers[index]} ");
							}
						Console.WriteLine();

						for (int tempIndex = 0; tempIndex < numbers.Length; tempIndex++)    // performs selection sort
							{
								int minimumIndex = tempIndex;

								for (int r = tempIndex + 1; r < numbers.Length; r++)
									{
										if (numbers[r] < numbers[minimumIndex])
											{
												minimumIndex = r;
											}
									}
								(numbers[tempIndex], numbers[minimumIndex]) = (numbers[minimumIndex], numbers[tempIndex]);
							}

						Console.WriteLine("After sorting the array the values are: ");
						for (int index = 0; index < numbers.Length; index++)
							{
								Console.Write($"{numbers[index]} ");
							}
						Console.WriteLine();
					}

				static void Example20()    // bubble sort
					{
						int[] numbers = new int[5] { 125, 115, 135, 500, 400 };
						
						Console.WriteLine("Before sorting the array the values are: ");
						for (int index = 0; index < numbers.Length; index++)
							{
								Console.Write($"{numbers[index]} ");
							}
						Console.WriteLine();

						for (int tempIndex = 0; tempIndex < numbers.Length - 1; tempIndex++)    // perform bubble sort
							{
								for (int h = 0; h < numbers.Length - tempIndex - 1; h++)
									{
										if (numbers[h] > numbers[h + 1])
											{
												(numbers[h + 1], numbers[h]) = (numbers[h], numbers[h + 1]);
											}
									}

							}

						Console.WriteLine("After sorting the array the values are: ");
						for (int index = 0; index < numbers.Length; index++)
							{
								Console.Write($"{numbers[index]} ");
							}
						Console.WriteLine();
					}
 
				static void Example21()
					{
						Customer[] myCustomers = new Customer[3];

						myCustomers[0] = new Customer { Name = "Mark", Gender = 1 };
						myCustomers[1] = new Customer { Name = "Mary", Gender = 2 };
						myCustomers[2] = new Customer { Name = "Sam", Gender = 0 };

						foreach (Customer value in myCustomers)
							{
								Console.WriteLine($"Name = {value.Name} & Gender = {GetGender(value.Gender)}");
							}
					}

				static string GetGender(int checkGender)
					{
						switch (checkGender)
							{
								case 0:
									return "Unknown";
								case 1:
									return "Male";
								case 2:
									return "Female";
								default:
									return "Invalid data entered";
							}
					}
					
				static void Example22()
					{
						ParamsMethod(1, 2, 3, 4, 5, 6);  // invoking a static method with a parameter array
					}

				static void ParamsMethod(params int[] numbersArray)
					{
						foreach (int element in numbersArray)
							{
								Console.Write($"{element} ");
							}
						Console.WriteLine();
						Console.WriteLine($"There are {numbersArray.Length} elements in this array");
					}

				static void Example23()
					{
						double total = CheckOut(3.99, 5.75, 15);
						Console.WriteLine($"The total price is {total}");
					}

				static double CheckOut(params double[] prices)
					{
						double total = 0;

						foreach(double price in prices)
							{
								total += price;
							}
						return total;
					}

				static void Example24()
					{
						Console.WriteLine($"The sum of the values in the array = {GetSum(1, 2, 3, 4)}");
						Console.WriteLine();
					}

				static int GetSum(params int[] numbersArray)    // The params array must be the last parameter in the list
					{
						int sum = 0;
						foreach (int index in numbersArray)
							{
								sum += index;
							}
						return sum;
					}

				static void Example25()
					{
						AddNumbers(10, 20);    // the params keyword makes the 3rd parameter optional
					}

				static void AddNumbers(int firstNumber, int secondNumber, params int[] restOfNumbers)
					{
						int result = firstNumber + secondNumber;

						if (restOfNumbers != null)
							{
								foreach (int index in restOfNumbers)
									{
										result += index;
									}
							}
						Console.WriteLine($"The sum of all numbers is: {result}");
					}

				static void Example26()
					{
						MultiplyNumbers(10, 20);    // the params keyword makes the 3rd parameter optional
					}

				static void MultiplyNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
					{
						int result = firstNumber * secondNumber;

						if (restOfNumbers != null)
							{
								foreach (int index in restOfNumbers)
									{
										result *= index;
									}
							}
						Console.WriteLine($"The sum of all numbers is: {result}");
					}

				static void Example27()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000 };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000 };
						Customer customer3 = new Customer() { ID = 104, Name = "Rob", Salary = 5500 };

						Customer[] customersArray = new Customer[] { customer1, customer2, customer3 };

						// To convert an array to a list
						List<Customer> customers = customersArray.ToList();

						foreach (Customer customer in customers)
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}");
							}
					}

				static void Example28()
					{
						/* Once Teodor played the following game: he started from a sequence of white and black balls and flipped the color of the 1st ball, then the color of the 4th ball,
						 * then the color of the 7th ball, etc. until the last ball. Flipping was performed by replacing a black b all with a white ball and vice versa.
						 * Teodor was a smart mathematician so he wanted to generalize his game in a formal way. This is what he invented.
						 
						 * You are given a sequence of bytes. Consider each byte as sequences of exactly 8 bits.
						 * You are given also a number step.
						 * Write a program to invert the bits at positions: 1, 1 + step, 1 + 2*step, ...
						 * Print the output as a sequence of bytes.
						 * Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 1. */

						int n = int.Parse(Console.ReadLine());
						int step = int.Parse(Console.ReadLine());
						int[] bytes = new int[n];

						for (int i = 0; i < n; i++)
							{
								bytes[i] = int.Parse(Console.ReadLine());
							}

						int position = 7;

						for (int i = 0; i < n; i++)
							{
								while (position >= 0)
									{
										int currentBit = (bytes[i] >> position) & 1;

										if (currentBit == 0)
											{
												bytes[i] = (1 << position) | bytes[i];
											}
										else
											{
												bytes[i] = ~(1 << position) & bytes[i];
											}
										position -= step;
									}
								Console.WriteLine(bytes[i]);
								position += 8;
							}
					}
			}
	}
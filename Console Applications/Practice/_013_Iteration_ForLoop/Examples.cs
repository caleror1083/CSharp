﻿using System;

// Namespaces
namespace _013_Iteration_ForLoop
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
											case 16:
												Example16();
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
						for (int i = 1; i <= 10; i++)  // printing ascending values 1-10 from an Integer type
							{
								Console.WriteLine(i);
							}
						Console.WriteLine();						
					}

				static void Example2()
					{
						for (int a = 10; a >= 1; a--)  // printing decending values 1-10 from an Integer type
							{
								Console.WriteLine(a);
							}
						Console.Write("HAPPY NEW YEAR!");
						Console.WriteLine("\n");						
					}

				static void Example3()
					{
						for (int b = 1; b <= 10; b++)  // This for loop prints out 1-10 on 1 line
							{
								Console.Write($"{b} ");
							}
						Console.WriteLine("\n");
					}

				static void Example4()
					{
						for (int c = 2; c <= 20; c += 3)  // This for loop varies the control variable over the sequence 2-20 with increments of 3
							{
								Console.Write($"{c} ");
							}
						Console.WriteLine("\n");						
					}

				static void Example5()
					{
						int totalSum = 0;

						for (int number = 2; number <= 20; number += 2)  // This for loop gives the sum the even integers from 2 to 20
							{
								totalSum += number;
							}
						Console.WriteLine($"Sum is {totalSum}");
						Console.WriteLine();						
					}

				static void Example6()
					{
						// Compound-interest calculations with for
						decimal principal = 1000;    // initial amount before interest
						double rate = 0.05;    // interest rate

						Console.WriteLine("Year Amount on deposit");  // display headers

						for (int year = 1; year <= 10; ++year)  // calculate amount on deposit for each of ten years 
							{
								decimal amount = principal * ((decimal)Math.Pow(1.0 + rate, year));  // calculate new amount for specified year 

								Console.WriteLine($"{year, -4} {amount:C}");  // display the year and the amount, the integer after the comma indicates that the value output should be displayed with a field width right-aligned, negative value is left-aligned
							}
						Console.WriteLine();						
					}

				static void Example7()
					{
						 // break statement exiting a for statement.
						int count; // control variable also used after loop terminates

						for (count = 1; count <= 10; ++count) // loop 10 times
							{
								Console.Write($"{count} ");
								if (count == 5) // if count is 5, 
									{
										break; // terminate loop
									}
							}
						Console.WriteLine($"\nBroke out of loop at count = {count}");
						Console.WriteLine();						
					}

				static void Example8()
					{
						// continue statement skipping an iteration of a for statement.						
						for (int count1 = 1; count1 <= 10; ++count1)
							{
								if (count1 == 5)	// if count is 5, 
									{
										continue;	// skip remaining code in loop
									}
								Console.Write($"{count1} ");
							}
						Console.WriteLine("\nUsed continue to skip displaying 5");
						Console.WriteLine();						
					}

				static void Example9()
					{
						//Printing even numbers to 10 using continue
						for (int number = 1; number <= 10; number++)
							{
								if (number % 2 == 1) // value is odd number skip displaying it
									{
										continue;	// skip remaining code in loop
									}
								Console.Write($"{number} ");
							}
						Console.WriteLine("\nUsed continue to skip displaying odd numbers");
						Console.WriteLine();						
					}

				static void Example10()
					{
						Console.Write("What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine("Your name spelled vertically is");
						for (int index = 0; index < name.Length; index++)
							{
								Console.WriteLine(name[index]);
							}
						Console.WriteLine();
					}

				static void Example11()
					{
						// Nested loops using for loops
						Console.Write("How many columns for your rectangle? ");
						int columns = int.Parse(Console.ReadLine());

						Console.Write("How many rows for your rectangle? ");
						int rows = int.Parse(Console.ReadLine());

						Console.Write("What symbol will be used? ");
						string symbol = Console.ReadLine();

						for (int rowIndex = 0; rowIndex < rows; rowIndex++)
							{
								for (int columnIndex = 0; columnIndex < columns; columnIndex++)
									{
										Console.Write($"{symbol}");
									}
								Console.WriteLine();
							}
						Console.WriteLine();
					}

				static void Example12()
					{
						Random randomNumbers = new Random(); // random-number generator

						for (int counter = 1; counter <= 20; ++counter)      // loop 20 times
							{
								int face = randomNumbers.Next(1, 7);		// pick random integer from 1 to 6
								Console.Write($"{face} ");					// display generated value
							}
						Console.WriteLine();
					}

				static void Example13()
					{
						Random randomNumbers = new Random();				// random-number generator

						int frequency1 = 0;									// count of 1s rolled
						int frequency2 = 0;									// count of 2s rolled
						int frequency3 = 0;									// count of 3s rolled
						int frequency4 = 0;									// count of 4s rolled
						int frequency5 = 0;									// count of 5s rolled
						int frequency6 = 0;									// count of 6s rolled
						int face;

						for (int roll = 1; roll <= 10; ++roll)			// summarize results of 60,000,000 rolls of a die
							{
								face = randomNumbers.Next(1, 7);			// number from 1 to 6

								switch (face)								// determine roll value 1-6 and increment appropriate counter
									{
										case 1:
											++frequency1;					// increment the 1s counter
											break;
										case 2:
											++frequency2;					// increment the 2s counter
											break;
										case 3:
											++frequency3;					// increment the 3s counter
											break;
										case 4:
											++frequency4;					// increment the 4s counter
											break;
										case 5:
											++frequency5;					// increment the 5s counter
											break;
										case 6:
											++frequency6;					// increment the 6s counter
											break;
									} 
								} 
						Console.WriteLine("Face\tFrequency"); // output headers
						Console.WriteLine($"1\t{frequency1}\n2\t{frequency2}");
						Console.WriteLine($"3\t{frequency3}\n4\t{frequency4}");
						Console.WriteLine($"5\t{frequency5}\n6\t{frequency6}");

						Console.WriteLine();
					}

				static void Example14()
					{
						// Star Pattern
						int ab = 1;
						int k = 6;
						int ib = 0;
						int jb = 0;

						int spaces = k - 1;

						for (ib = 1; ib < k * 2; ib++)
							{
								for (jb = 1; jb <= spaces; jb++)
									{
										Console.Write(" ");
									}
								for (jb = 1; jb < ab * 2; jb++)
									{
										Console.Write("*");
									}
								Console.WriteLine("");
						 
								if (ib < k)
									{
										spaces--;
										ab++;
									}
								else
									{
										spaces++;
										ab--;
									}
							}

						Console.WriteLine();
					}

				static void Example15()
					{
						int x;                                  // Variable declaration of type int
						int int2 = 0;                           // Variable declaration and initialization of type int
						int y;                                  // Variable declaration of type int
						string guess;                           // Variable declaration of type string
						string myName = "Rob";    // Variable declaration and initialization of type string

						// For loop
						for (x = 1; x <= 5; x++)
							{
								Console.WriteLine("This for loop is at iteration: " + x);
							}

						Console.WriteLine(); // Writes a blank line to the console

						// Exit the For loop before it is finished
						for (x = 1; x <= 5; x++)
							{
								Console.WriteLine("This for loop is at iteration: " + x);
								if (x == 3)
									{
										break;
									}
							}

						Console.WriteLine(); // Writes a blank line to the console

						// Continue statement
						for (x = 1; x <= 10; x++)
							{
								if (x == 5)
								{
									Console.WriteLine("The number equals: " + x);
									continue;
								}
							}

						Console.WriteLine(); // Writes a blank line to the console

						// For loop with Step Operator
						for (x = 0; x <= 20; x += 5)
							{
								Console.WriteLine("The number equals: " + x);
							}

						Console.WriteLine(); // Writes a blank line to the console

						for (x = 1; x <= 10; x++)
							{
								for (y = 1; y <= 5; y++)
									{
										Console.Write(y);
									}
								Console.WriteLine();
							}

						Console.WriteLine(); // Writes a blank line to the console

						// Foreach loop
						foreach (char ch in myName)
							{
								Console.WriteLine(ch);
							}

						// Do While loop aka Do Until in VB
						do
							{
								Console.WriteLine("The number equals: " + int2);
								int2 += 1;
							}
						while (int2 == 10);

						Console.WriteLine(); // Writes a blank line to the console

						// Exit the Do loop
						do
							{
								if (int2 == 5)
									{
										Console.WriteLine("The number equals: " + int2);
										int2 += 1;
										break;
									}
							}
						while (int2 == 10);

						Console.WriteLine(); // Writes a blank line to the console

						// While loop aka Do While in VB
						while (int2 <= 15)
							{
								Console.WriteLine("The number equals: " + int2);
								int2 += 1;
							}

						Console.WriteLine(); // Writes a blank line to the console

						do
							{
								Console.Write("Guess a number from 1 to 20: ");
								guess = Console.ReadLine();
							}
						while (!guess.Equals("17"));
					}

				static void Example16()
					{
						// Write a program that prints the first 100 members of the sequence: 2, -3, 4, -5, 6
					   for (int i = 2; i < 101; i++)
							{
								if (i % 2 == 0)
								{
									Console.WriteLine(i);
								}
            
								else
								{
									Console.WriteLine(-i);
								}
							}
					}
			}
	}
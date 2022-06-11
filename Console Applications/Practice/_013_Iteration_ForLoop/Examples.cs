using System;
using System.Text;

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
							Console.Write($"Please select an example from 1-20: ");
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

				static void Example17()
					{
						/* Find online more information about ASCII (American Standard Code for Information Interchange) and
						 * write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255).
						 * Note that some characters have a special purpose and will not be displayed as expected.
						 * You may skip them or display them differently. You may need to use for-loops (learn in Internet how). */

						Console.OutputEncoding = Encoding.UTF8; 
        
						for (int i = 0; i < 256; i++)
							{        
								char symbol = (char)i;
								Console.WriteLine(i + " --> " + symbol);
							}
					}

				static void Example18()
					{
						/* Nakov likes numbers. He often plays with their sums and differences. Once he invented the following game.
						 * He takes a sequence of numbers, splits them into two subsequences with the same number of elements and sums the left and right sub-sums, and compares the sub-sums. Please help him.

						 * You are given a number n and 2*n numbers. Write a program to check whether the sum of the first n numbers is equal to the sum of the second n numbers.
						 * Print as result “Yes” or “No”. In case of yes, print also the sum. In case of no, print also the difference between the left and the right sums. 
						 
						 * Input
						 * 4
						 
						 FirstSum
						 * 3
						 * 4
						 * -1
						 * -1
						 
						 SecondSum
						 * 2
						 * 1
						 * 1
						 * 1
						 
						 Output
						 * Yes, sum=5 */	

						int n = int.Parse(Console.ReadLine());
						int firstSum = 0;
						int secondSum = 0;
        
						for (int i = 0; i < n; i++)
							{
								firstSum += int.Parse(Console.ReadLine());
							}
       
						for (int i = 0; i < n; i++)
							{
								secondSum += int.Parse(Console.ReadLine());
							}
       
						if (firstSum == secondSum)
							{            
								Console.WriteLine("Yes, sum =" + firstSum);
							}

						else
							{            
								Console.WriteLine("No, diff=" + Math.Abs(firstSum - secondSum));
							}
					}

				static void Example19()
					{
						// Sunglasses
						int size = int.Parse(Console.ReadLine());
						string slash = new string('/', 2 * size - 2);
						string verticalLines = new string('|', size);
						string emptySpace = new string(' ', size);
						string asterisk = new string('*', 2 * size);        

						for (int i = 1; i <= size; i++)
							{
								if ((i == 1) || (i == size))
									{
										Console.WriteLine("{0}{1}{0}", asterisk, emptySpace); // first and last line
									}

								else if (i == size / 2 + 1)
									{
										Console.WriteLine("*{0}*{1}*{0}*", slash, verticalLines); // middle line
									}

								else
									{
										Console.WriteLine("*{0}*{1}*{0}*",slash, emptySpace); // all other lines
									}
							}
					}

				static void Example20()
					{            
						/* Petya often plays with numbers. Her recent game was to play with 9-digit numbers and calculate their sums of digits, as well as to split them into triples with special properties.
						 * Help her to calculate very special numbers called “nine-digit magic numbers”.
						 
						 * You are given two numbers: diff and sum.
						 * Using the digits from 1 to 7 generate all 9-digit numbers in format abcdefghi,
						 * such that their sub-numbers abc, def and ghi have a difference diff (ghi-def = def-abc = diff), their sum of digits is sum and abc ≤ def ≤ ghi.
						 * Numbers holding these properties are also called “nine-digit magic numbers”.
						 * Your task is to write a program to print these numbers in increasing order. */

						int sum = int.Parse(Console.ReadLine());
						int diff = int.Parse(Console.ReadLine());
						bool magicFound = false;
            
						for (int firstTriplet = 111; firstTriplet <= 777 - (2 * diff); firstTriplet++)
							{
								int secondTriplet = firstTriplet + diff;
								int thirdTriplet = secondTriplet + diff;
								int digitSum = GetDigitSum(firstTriplet) + GetDigitSum(secondTriplet) + GetDigitSum(thirdTriplet);

								if (NumberAllowed(firstTriplet) && NumberAllowed(secondTriplet) && NumberAllowed(thirdTriplet) && digitSum == sum)
									{
										Console.WriteLine($"{firstTriplet} {secondTriplet} {thirdTriplet}");
										magicFound = true;
									}                        
                
							}
            
						if (!magicFound)
							{
								Console.WriteLine("No");
							}
					}

				static int GetDigitSum(int triplet)
					{
						int sum = 0;
						sum += triplet / 100;       // add digit of hundreds
						sum += (triplet / 10) % 10; // tens
						sum += triplet % 10;        // ones

						return sum;
					}

				static bool NumberAllowed(int triplet)
					{
						bool isAllowed = false;

						if (triplet % 10 > 0 && (triplet / 10) % 10 > 0 && triplet % 10 < 8 && (triplet / 10) % 10 < 8)
							{
								isAllowed = true;
							}

						return isAllowed;
					}
			}
	}
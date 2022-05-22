using System;
using System.Collections.Generic;

namespace _036_Attributes
	{
		#region Classes
		internal class Calculator
			{
				#region  Fields
				#endregion

				#region Contructors
				#endregion

				#region Properties
				#endregion

				#region Methods
				internal void ProcessExamples()
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
											case 1:
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

				internal static void Example1()
					{
						Console.WriteLine($"The sum is {Add(new List<int>() { 10, 20, 30 })}");
					}

				[Obsolete("Use Add(List<int> numberList) Method", true)]    // Obsolete attribute to let user know this is an old method
				internal static int Add(int firstNumber, int secondNumber)
					{
						int sum = firstNumber + secondNumber;						
						return sum;
					}

				internal static int Add(List<int> numberList)
					{
						int sum = 0;

						foreach (int number in numberList)
							{
								sum += number;
							}
						return sum;
					}
				#endregion
			}
		#endregion
	}
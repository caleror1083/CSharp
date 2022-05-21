using System;

namespace _034_Enumerations
	{
		internal class Examples
			{
				#region Methods
				internal void ProcessExamples()
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
											case (int)EnumExamples.Example1:
												Example1();
												break;
											case (int)EnumExamples.Example2:
												Example2();
												break;
											case (int)EnumExamples.Example3:
												Example3();
												break;
											case (int)EnumExamples.Example4:
												Example4();
												break;
											case (int)EnumExamples.Example5:
												Example5();
												break;
											case (int)EnumExamples.Example6:
												Example6();
												break;
											case (int)EnumExamples.Example7:
												Example7();
												break;
											case (int)EnumExamples.Example8:
												Example8();
												break;
											case (int)EnumExamples.Example9:
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

				internal void Example1()
					{
						EnumCarColor car = EnumCarColor.Blue;
						Console.WriteLine($"The name of the color is {car} with the value of {(int)car}");
					}

				internal void Example2()
					{
						Customer[] myCustomers = new Customer[3];
						
						myCustomers[0] = new Customer { Name = "Mark", Gender = EnumGender.Male };
						myCustomers[1] = new Customer { Name = "Mary", Gender = EnumGender.Female };
						myCustomers[2] = new Customer { Name = "Sam", Gender = EnumGender.Unknown };

						foreach (Customer value in myCustomers)
							{
								Console.WriteLine($"Name = {value.Name} & Gender = {GetGender(value.Gender)}");
							}
					}

				internal void Example3()
					{
						EnumGender gender = (EnumGender)2;    // returns the name of the specific constant value in an enum
						Console.WriteLine(gender);
					}

				internal void Example4()
					{
						int number = (int)EnumGender.Unknown;
						Console.WriteLine(number);    // returns the value of the specific constant name in an enum
					}

				internal void Example5()
					{
						EnumGender season = (EnumGender)EnumSeason.Summer;
						Console.WriteLine(season);    // returns the value of the specific name in an enum
					}

				internal void Example6()
					{
						int[] gender = (int[])Enum.GetValues(typeof(EnumGender));    // retrieves an array of the values in an enum

						foreach (int value in gender)
							{
								Console.Write($"{value} ");
							}
						Console.WriteLine();
					}

				internal void Example7()
					{
						string[] gender = Enum.GetNames(typeof(EnumGender));  // retrieves an array of the names in an enum
						
						foreach (string value in gender)
							{
								Console.WriteLine($"{value}");
							}
					}

				internal void Example8()
					{
						EnumTemperature checkTemperature = EnumTemperature.Low;

						switch (checkTemperature)
							{
								case EnumTemperature.Freeze:
									Console.WriteLine("Temp on Freezing");
									break;
								case EnumTemperature.Low:
									Console.WriteLine("Temp on Low");
									break;
								case EnumTemperature.Warm:
									Console.WriteLine("Temp on Warm");
									break;
								case EnumTemperature.Boil:
									Console.WriteLine("Temp on Boil");
									break;
							}
						Console.WriteLine();
					}

				internal void Example9()
					{
						EnumGameStatus gameStatus;											// plays one game of craps, gameStatus can contain Continue, Won or Lost
						int myPoint = 0;													// point if no win or loss on first roll
						int checkSum = RollDice();											// first roll of the dice

						switch ((EnumDiceNames)checkSum)									// determine game status and point based on first roll 
							{
								case EnumDiceNames.Seven:									// win with 7 on first roll    
								case EnumDiceNames.YoLeven:									// win with 11 on first roll
									gameStatus = EnumGameStatus.Won;
									break;
								case EnumDiceNames.SnakeEyes:								// lose with 2 on first roll
								case EnumDiceNames.Trey:									// lose with 3 on first roll      
								case EnumDiceNames.BoxCars:									// lose with 12 on first roll 
									gameStatus = EnumGameStatus.Lost;
									break;
								default:													// did not win or lose, so remember point  
									gameStatus = EnumGameStatus.Continue;					// game is not over
									myPoint = checkSum;										// remember the point       
									Console.WriteLine($"Point is {myPoint}");
									break;
							}

						while (gameStatus == EnumGameStatus.Continue)							// while game is not complete, game not Won or Lost
							{
								checkSum = RollDice();										// roll dice again

								if (checkSum == myPoint)									// determine game status, win by making point
									{
										gameStatus = EnumGameStatus.Won;
									}
								else
									{
										if (checkSum == (int)EnumDiceNames.Seven)		// lose by rolling 7 before point
											{
												gameStatus = EnumGameStatus.Lost;
											}
									}
							}

						if (gameStatus == EnumGameStatus.Won)									// display won or lost message
							{
								Console.WriteLine("Player wins");
							}
						else
							{
								Console.WriteLine("Player loses");
							}
					}

				internal static int RollDice()								// roll dice, calculate sum and display results
					{
						Random randomNumbers = new Random();							// create random-number generator for use in RollDice method that picks random dice values
						
						int die1 = randomNumbers.Next(1, 7);							// first die roll
						int die2 = randomNumbers.Next(1, 7);							// second die roll
						int sum = die1 + die2;											// sum of die values

						Console.WriteLine($"Player rolled {sum}");						// display results of this roll
						return sum;														// return sum of dice
					}			

				internal static string GetGender(EnumGender checkGender)    // switch statement for EnumGender
					{
						switch (checkGender)
							{
								case EnumGender.Unknown:
									return "Unknown";
								case EnumGender.Male:
									return "Male";
								case EnumGender.Female:
									return "Female";
								default:
									return "Invalid data detected";
							}
					}
				#endregion
		}
	}
using System;
using System.Threading;

namespace _044_Thread
	{
		internal class Examples
			{
				public void ProcessExamples()
					{
						bool check;
						string decision;

						Start:
							Console.Write("Please select an example from 1-2: ");
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
							Console.WriteLine("Do you want to do another example? - Yes or No: ");
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
						Thread thread1 = new Thread(Number.PrintNumbers);  // Utilizing the ThreadStart delegate, passing the name of the PrintNumbers method that we want the thread to execute
						thread1.Start();  // When this line execute, the program will run PrintNumbers()
					}

				static void Example2()
					{
						Console.WriteLine($"Please enter the target number");
						object target = Console.ReadLine();

						Thread thread1 = new Thread(Number.PrintTargetNumbers); // Utilizing the ParameterizedThreadStart delegate
						thread1.Start(target);
					}
			}
	}
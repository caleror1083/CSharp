﻿using System;

// Namespaces
namespace _027_Properties_GetSetMethods
	{
		// Classes
		internal class Examples
			{
				// Methods(Parameters)
				public void ProcessExamples()
					{
						bool check;
						string decision;

						Start:
							Console.Write("Please select an example from 1-3: ");
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
						Student myStudent = new Student();
						myStudent.PrintInfo();
					}

				static void Example2()
					{
						Account myAccount = new Account();  // Create an instance of Account object
						myAccount.PrintName();
					}

				static void Example3()
					{
						Animal cat = new Animal("");

						// Call the setter
						cat.SetName("Whiskers");

						Console.WriteLine("The cat is named {0}", cat.GetName());

						// Test auto generated getters and setters
						cat.Owner = "Derek";

						Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);

						// Get the read-only id number
						Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);

						Animal frog = new Animal("Bob");

						// Test static property
						Console.WriteLine("# of Animals : {0}", Animal.NumOfAnimals2);
						Console.WriteLine();
					}
			}
	}
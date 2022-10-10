﻿using _051_DatabaseFirstEFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace _051_DatabaseFirstEFCore
	{
		internal class Examples
			{
				public void ProcessExamples()
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

				static void Example1()
					{						
						var config = new ConfigurationBuilder().AddJsonFile("appconfig.json", optional: false).Build();

						var options = new DbContextOptionsBuilder<CompanyContext>().UseSqlServer(config.GetConnectionString("DefaultConnection")).Options;
						
						using var db = new CompanyContext(options);

						Console.WriteLine("Getting Connection ...");

						try
							{
								Console.WriteLine("Opening Connection ...");

								Console.WriteLine("Connection successful!");
							}
						catch (Exception e)
							{
								Console.WriteLine("Error: " + e.Message);
							}
					}
			}
	}
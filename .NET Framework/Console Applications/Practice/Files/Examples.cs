// Robert Calero - App displaying arrays
using System;
using System.IO;

namespace Files
	{
		#region Classes
		internal class Examples
			{
				#region Methods
				internal void ProcessExamples()
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
						string[] custs = new string[] { "Rob", "Paul", "Greg" };

						using (StreamWriter sw = new StreamWriter(@"C:\Users\Rob C\source\repos\CSharp\Console Applications\Practice\Files\bin\Debug\customers.txt"))
							{
								foreach (string cust in custs)
									{
										sw.WriteLine(cust);
									}
							}

						string custName = "";
						using (StreamReader sr = new StreamReader(@"C:\Users\Rob C\source\repos\CSharp\Console Applications\Practice\Files\bin\Debug\customers.txt"))
							{
								while ((custName = sr.ReadLine()) != null)
									{
										Console.WriteLine(custName);
									}
							}
					}

				internal void Example2()
					{
						string write = "Hello";
						string read;

						File.WriteAllText(@"C:\Users\Rob C\source\repos\CSharp\Console Applications\Practice\Files\bin\Debug\test.txt", write);    // create a file and write content to it

						read = File.ReadAllText(@"C:\Users\Rob C\source\repos\CSharp\Console Applications\Practice\Files\bin\Debug\test.txt");    // read the contents of the file

						Console.WriteLine(read);    // output the content
					}
				#endregion
			}
		#endregion
	}
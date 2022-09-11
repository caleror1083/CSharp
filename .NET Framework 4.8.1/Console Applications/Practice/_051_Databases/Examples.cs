using System;
using System.Data.SqlClient;

namespace _051_Databases
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
						Console.WriteLine("Getting Connection ...");
						SqlConnection myConnection = new SqlConnection(@"Data Source=ROB-DESKTOP\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True");    // Creates an instance of the database connection

						try
							{
								Console.WriteLine("Opening Connection ...");
								myConnection.Open();    // Open connection to database

								Console.WriteLine("Connection successful!");
						
								// Create a new SQL Query using StringBuilder
								//StringBuilder myStringBuilder = new StringBuilder();
								//myStringBuilder.Append("INSERT INTO StudentDetails (Name, Email, Class) VALUES");
								//myStringBuilder.Append("('Robert', 'caleror1083@gmail.com', 'Software I'),");
								//myStringBuilder.Append("('Lance', 'lance84@gmail.com', 'Software II')");

								//string sqlQuery = myStringBuilder.ToString();

								//using (SqlCommand myCommand = new SqlCommand(sqlQuery, myConnection))
								//	{
								//		myCommand.ExecuteNonQuery();
								//		Console.WriteLine("Query Executed!");
								//	}
							}
						catch (Exception e)
							{
								Console.WriteLine("Error: " + e.Message);
							}
					}
			}
	}
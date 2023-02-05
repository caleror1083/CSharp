using _051_DatabaseFirstEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
						Console.WriteLine("Getting Connection ...");
						using (var results = new CompanyContext())
							{
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

				static void SelectandReadData()
					{
						using (var results = new CompanyContext())
							{
								// SELECT * FROM Employees
								List<Employees> select = results.Employees.ToList();
						
								foreach (Employees selectObj in select)
									{
										Console.WriteLine($"{selectObj.EmployeeId} {selectObj.EmployeeName} {selectObj.Department} {selectObj.DateofJoining} {selectObj.PhotoFileName}");
									}
							}
					}

				static void CreateData()
					{
						string employeeName, department, photoFileName;
						Console.Write("Enter employee name: ");
						employeeName = Console.ReadLine();

						Console.Write("Enter department: ");
						department = Console.ReadLine();

						DateTime dateofJoining;
						Console.Write("Enter date of joining");
						dateofJoining = DateTime.Parse(Console.ReadLine());

						Console.Write("Enter photo file name: ");
						photoFileName = Console.ReadLine();

						using (var results = new CompanyContext())
							{
								Employees emp = new Employees();
								emp.EmployeeName = employeeName.ToString();
								emp.Department = department.ToString();
								emp.DateofJoining = dateofJoining.ToLocalTime();
								emp.PhotoFileName = photoFileName.ToString();

								results.Add(emp);
								results.SaveChanges();
							}
					}

				static void UpdateData()
					{
					}

				static void DeleteData()
					{
					}
			}
	}
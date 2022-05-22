using System;
using System.Reflection;

namespace _037_Reflection
	{
		#region Classes
		class Customer
			{
				#region  Fields
				#endregion

				#region Contructors
				public Customer()
					{
						ID = -1;
						Name = string.Empty;
					}

				public Customer(int paramID, string paramName)
					{
						ID = paramID;
						Name = paramName;
					}
				#endregion

				#region Properties
				public int ID { get; set; }
				public string Name { get; set; }
				#endregion

				#region Methods
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

				public static void Example1()
					{
						Type myTypes = typeof(Customer);
						Console.WriteLine($"Fully qualified name = {myTypes.FullName}");
						Console.WriteLine($"Namespace name = {myTypes.Namespace}");
						Console.WriteLine($"Class name = {myTypes.Name}");
						Console.WriteLine();

						Console.WriteLine("Constructors in Customer class");
						ConstructorInfo[] myConstructors = myTypes.GetConstructors();

						foreach (ConstructorInfo constructor in myConstructors)
							{
								Console.WriteLine($"{constructor}");
							}
						Console.WriteLine();

						Console.WriteLine("Properties in Customer class");
						PropertyInfo[] myProperties = myTypes.GetProperties();
						foreach (PropertyInfo property in myProperties)
							{
								Console.WriteLine($"{property.PropertyType.Name} {property.Name}");
							}
						Console.WriteLine();

						Console.WriteLine("Methods in Customer class");
						MethodInfo[] myMethods = myTypes.GetMethods();
						foreach (MethodInfo method in myMethods)
							{
								Console.WriteLine($"{method.ReturnType.Name} {method.Name}");
							}
					}

				public void PrintID()
					{
						Console.WriteLine($"ID = {ID}");
					}

				public void PrintName()
					{
						Console.WriteLine($"Name = {Name}");
					}

				#endregion
			}
		#endregion
	}
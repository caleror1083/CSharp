using System;
using System.Collections.Generic;

namespace _043_Collections_Stack
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
						// Creating instances of objects from the Customer class
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Gender = "Male" };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Gender = "Female" };
						Customer customer3 = new Customer() { ID = 103, Name = "John", Gender = "Male" };
						Customer customer4 = new Customer() { ID = 104, Name = "Ken", Gender = "Male" };
						Customer customer5 = new Customer() { ID = 105, Name = "Valerie", Gender = "Female" };

						Stack<Customer> customers = new Stack<Customer>();  // Creating a stack of customer objects
						customers.Push(customer1);  // Adding customers to the stack
						customers.Push(customer2);  // customer2 object gets placed above customer1 object in the stack
						customers.Push(customer3);
						customers.Push(customer4);
						customers.Push(customer5);  // customer5 currently at the top of the stack

						Customer cust1 = customers.Pop();  // Removing objects from the stack
						Console.WriteLine($"{cust1.ID} - {cust1.Name}");
						Console.WriteLine($"Total items remaining in the stack = {customers.Count}");  // Returns the number of objects remaining in the stack

						Customer cust2 = customers.Pop();
						Console.WriteLine($"{cust2.ID} - {cust2.Name}");
						Console.WriteLine($"Total items remaining in the stack = {customers.Count}");

						Customer cust3 = customers.Pop();
						Console.WriteLine($"{cust3.ID} - {cust3.Name}");
						Console.WriteLine($"Total items remaining in the stack = {customers.Count}");

						Customer cust4 = customers.Pop();
						Console.WriteLine($"{cust4.ID} - {cust4.Name}");
						Console.WriteLine($"Total items remaining in the stack = {customers.Count}");

						Customer cust5 = customers.Pop();
						Console.WriteLine($"{cust5.ID} - {cust5.Name}");
						Console.WriteLine($"Total items remaining in the stack = {customers.Count}");
					}
			}
	}
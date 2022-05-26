using System;
using System.Collections.Generic;

namespace _042_Collections_Queue
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
						// Object instances from Customer class
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Gender = "Male" };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Gender = "Female" };
						Customer customer3 = new Customer() { ID = 103, Name = "John", Gender = "Male" };
						Customer customer4 = new Customer() { ID = 104, Name = "Ken", Gender = "Male" };
						Customer customer5 = new Customer() { ID = 105, Name = "Valerie", Gender = "Female" };

						// Variable initializations
						Queue<Customer> customers = new Queue<Customer>();  // Creating an instance of a queue class that represents a FIFO collection of customer objects
						customers.Enqueue(customer1);  // Adding customer objects to the end of the queue
						customers.Enqueue(customer2);
						customers.Enqueue(customer3);
						customers.Enqueue(customer4);
						customers.Enqueue(customer5);

						// Input process and output
						Customer cust1 = customers.Dequeue();  // Removing the customer object and returning them to the beginning of the queue
						Console.WriteLine($"{cust1.ID} - {cust1.Name}");
						Console.WriteLine($"Total items in the queue = {customers.Count}");  // Returning the number of objects remaining in the queue

						Customer cust2 = customers.Dequeue();
						Console.WriteLine($"{cust2.ID} - {cust2.Name}");
						Console.WriteLine($"Total items in the queue = {customers.Count}");

						Customer cust3 = customers.Dequeue();
						Console.WriteLine($"{cust3.ID} - {cust3.Name}");
						Console.WriteLine($"Total items in the queue = {customers.Count}");

						Customer cust4 = customers.Dequeue();
						Console.WriteLine($"{cust4.ID} - {cust4.Name}");
						Console.WriteLine($"Total items in the queue = {customers.Count}");

						Customer cust5 = customers.Dequeue();
						Console.WriteLine($"{cust5.ID} - {cust5.Name}");
						Console.WriteLine($"Total items in the queue = {customers.Count}");
					}
			}
	}
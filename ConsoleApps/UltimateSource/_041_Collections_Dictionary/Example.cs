using System;
using System.Collections.Generic;
using System.Linq;

namespace _041_Collections_Dictionary
	{
		internal class Examples
			{
				public void ProcessExamples()
						{
							bool check;
							string decision;

						Start:
							Console.Write("Please select an example from 1-7: ");
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
											case 4:
												Example4();
												break;
											case 6:
												Example6();
												break;
											case 7:
												Example7();
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
						Dictionary<string, string> fruitDefinitions = new Dictionary<string, string>
							{
								{ "Watermelon", "a fruit" }
							};

						Console.WriteLine($"Watermelon - {fruitDefinitions["Watermelon"]}");    // outputs the integer value of Watermelon
					}

				static void Example2()
					{
						Customer customer1 = new Customer()
							{
								ID = 101, Name = "Mark", Salary = 5000
							};
						Customer customer2 = new Customer()
							{
								ID = 111, Name = "Pam", Salary = 6500
							};
						Customer customer3 = new Customer()
							{
								ID = 119, Name = "John", Salary = 3500
							};

						Dictionary<int, Customer> customerRecords = new Dictionary<int, Customer>
							{
								{ customer1.ID, customer1 },
								{ customer2.ID, customer2 },
								{ customer3.ID, customer3 }
							};

						foreach (KeyValuePair<int, Customer> customer in customerRecords)
							{
								Console.WriteLine($"The key for the Customer is: {customer.Key}");    // displays the key from the dictionary collection
								// displays the values of the properties for each customer in the dictionary collection
								Console.WriteLine($"ID: {customer.Value.ID}\nName: {customer.Value.Name}\nSalary: {customer.Value.Salary} {customer.Value.Salary}");     
								Console.WriteLine($"-------------------------------------");
							}
					}

				static void Example3()
					{
						Customer customer1 = new Customer()
							{
								ID = 101, Name = "Mark", Salary = 5000
							};
						Customer customer2 = new Customer()
							{
								ID = 111, Name = "Pam", Salary = 6500
							};
						Customer customer3 = new Customer()
							{
								ID = 119, Name = "John", Salary = 3500
							};

						Dictionary<int, Customer> customerRecords = new Dictionary<int, Customer>
							{
								{ customer1.ID, customer1 },
								{ customer2.ID, customer2 },
								{ customer3.ID, customer3 }
							};

						// Statements - when you are not sure in the dictionary contains a specific key utilize TryGetValue()
						Console.Write($"Enter a key to search for in the dictionary? ");
						int keySearch = int.Parse(Console.ReadLine());

						if (customerRecords.TryGetValue(keySearch, out Customer customers))
							{
								Console.WriteLine($"ID = {customers.ID}, Name = {customers.Name}, Salary = {customers.Salary}");
							}
						else
							{
								Console.WriteLine("That key does not exist");
							}
					}

				static void Example4()
					{
						Customer customer1 = new Customer()
							{
								ID = 101, Name = "Mark", Salary = 5000
							};
						Customer customer2 = new Customer()
							{
								ID = 111, Name = "Pam", Salary = 6500
							};
						Customer customer3 = new Customer()
							{
								ID = 119, Name = "John", Salary = 3500
							};

						Dictionary<int, Customer> customerRecords = new Dictionary<int, Customer>
							{
								{ customer1.ID, customer1 },
								{ customer2.ID, customer2 },
								{ customer3.ID, customer3 }
							};

						// Statements - when you are not sure in the dictionary contains a specific key utilize TryGetValue()
						Console.WriteLine($"Total items in dictionary are {customerRecords.Count}");
						Console.WriteLine($"Total items in dictionary are {customerRecords.Count()}");
						Console.WriteLine($"Customers with salaries greater than 4000 are: {customerRecords.Count(kvp => kvp.Value.Salary > 4000)}");
					}

				static void Example5()
					{
						Customer customer1 = new Customer()
							{
								ID = 101, Name = "Mark", Salary = 5000
							};
						Customer customer2 = new Customer()
							{
								ID = 111, Name = "Pam", Salary = 6500
							};
						Customer customer3 = new Customer()
							{
								ID = 119, Name = "John", Salary = 3500
							};

						Dictionary<int, Customer> customerRecords = new Dictionary<int, Customer>
							{
								{ customer1.ID, customer1 },
								{ customer2.ID, customer2 },
								{ customer3.ID, customer3 }
							};

						// Statements - when you want to remove 1 item from the dictionary via the key
						customerRecords.Remove(119);
						customerRecords.Clear();  // removes all items from the dictionary
					}

				static void Example6()
					{
						Customer customer1 = new Customer()
							{
								ID = 101, Name = "Mark", Salary = 5000
							};
						Customer customer2 = new Customer()
							{
								ID = 111, Name = "Pam", Salary = 6500
							};
						Customer customer3 = new Customer()
							{
								ID = 119, Name = "John", Salary = 3500
							};
						
						// Statements - when you want to remove 1 item from the dictionary via the key
						Customer[] customers = new Customer[3] { customer1, customer2, customer3 };

						foreach (KeyValuePair<int, Customer> kvp in customers.ToDictionary(cust => cust.ID, cust => cust))
							{
								Console.WriteLine($"Key = {kvp.Key}");
								Console.WriteLine($"ID = {kvp.Value.ID}, Name = {kvp.Value.Name}, Salary = {kvp.Value.Salary}");
							}


					}

				static void Example7()
					{
						Customer customer1 = new Customer()
							{
								ID = 101, Name = "Mark", Salary = 5000
							};
						Customer customer2 = new Customer()
							{
								ID = 111, Name = "Pam", Salary = 6500
							};
						Customer customer3 = new Customer()
							{
								ID = 119, Name = "John", Salary = 3500
							};

						// Statements - when you want to remove 1 item from the dictionary via the key
						List<Customer> customers = new List<Customer>
							{
								customer1, customer2, customer3
							};

						foreach (KeyValuePair<int, Customer> kvp in customers.ToDictionary(cust => cust.ID, cust => cust))
							{
								Console.WriteLine($"Key = {kvp.Key}");
								Console.WriteLine($"ID = {kvp.Value.ID}, Name = {kvp.Value.Name}, Salary = {kvp.Value.Salary}");
							}
					}
			}
	}
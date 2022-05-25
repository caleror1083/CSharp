using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace _039_Collections_List_ComplexTypes
	{
		internal class Examples
			{
				public void ProcessExamples()
					{
						bool check;
						string decision;

						Start:
							Console.Write("Please select an example from 1-28: ");
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
											case 5:
												Example5();
												break;
											case 6:
												Example6();
												break;
											case 7:
												Example7();
												break;
											case 8:
												Example8();
												break;
											case 9:
												Example9();
												break;
											case 10:
												Example10();
												break;
											case 11:
												Example11();
												break;
											case 12:
												Example12();
												break;
											case 13:
												Example13();
												break;
											case 14:
												Example14();
												break;
											case 15:
												Example15();
												break;
											case 16:
												Example16();
												break;
											case 17:
												Example17();
												break;
											case 18:
												Example18();
												break;
											case 19:
												Example19();
												break;
											case 20:
												Example20();
												break;
											case 21:
												Example21();
												break;
											case 22:
												Example22();
												break;
											case 23:
												Example23();
												break;
											case 24:
												Example24();
												break;
											case 25:
												Example25();
												break;
											case 26:
												Example26();
												break;
											case 27:
												Example27();
												break;
											case 28:
												Example28();
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
						List<Customer> customers = new List<Customer>
							{
								new Customer() { ID = 101, Name = "Mark", Salary = 5000 },
								new Customer() { ID = 111, Name = "Pam", Salary = 6500 },
								new Customer() { ID = 119, Name = "John", Salary = 3500 }
							};

						Console.WriteLine($"ID = {customers[0].ID}, Name = {customers[0].Name}, Salary = {customers[0].Salary}");  // Retrieves the 1st object element from the list
					}

				static void Example2()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 5000 };
						Customer customer2 = new Customer() { ID = 111, Name = "Pam", Salary = 6500 };
						Customer customer3 = new Customer() { ID = 119, Name = "John", Salary = 3500 };
						
						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
						
						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}");
							}
					}

				static void Example3()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 5000 };
						Customer customer2 = new Customer() { ID = 111, Name = "Pam", Salary = 6500 };
						Customer customer3 = new Customer() { ID = 119, Name = "John", Salary = 3500 };
						
						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
						
						for (int index = 0; index < customers.Count; index++)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customers[index].ID}, Name = {customers[index].Name}, Salary = {customers[index].Salary}");
							}
					}

				static void Example4()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 5000 };
						Customer customer2 = new Customer() { ID = 111, Name = "Pam", Salary = 6500 };
						Customer customer3 = new Customer() { ID = 119, Name = "John", Salary = 3500 };
						
						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
						
						customers.Insert(0, customer3);    // push customer 3 object information to the beginning of the list
						
						Console.WriteLine($"{customers.IndexOf(customer3)}");  // returns the index of the first occurence of the customer 3 object in the list
						Console.WriteLine($"{customers.IndexOf(customer3, 1)}");  // returns the index of the first occurence of the customer 3 object in the list within a starting range from index 1
					}

				static void Example5()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 5000 };
						Customer customer2 = new Customer() { ID = 111, Name = "Pam", Salary = 6500 };
						Customer customer3 = new Customer() { ID = 119, Name = "John", Salary = 3500 };
						
						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

						if (customers.Contains(customer3))  // checks if an item is in the list
							{
								Console.WriteLine($"Customer3 object exists in the list");
							}
						else
							{
								Console.WriteLine($"Object does not exist in the list");
							}
					}

				static void Example6()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 5000 };
						Customer customer2 = new Customer() { ID = 111, Name = "Pam", Salary = 6500 };
						Customer customer3 = new Customer() { ID = 119, Name = "John", Salary = 3500 };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

						if (customers.Exists(customer => customer.Name.StartsWith("P")))    // Searches the entire list for customers whose name starts with the letter P
							{
								Console.WriteLine($"Customer3 object exists in the list");
							}
						else
							{
								Console.WriteLine($"Object does not exist in the list");
							}
					}

				static void Example7()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000 };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000 };
						Customer customer3 = new Customer() { ID = 104, Name = "Rob", Salary = 5500 };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

						// Searches the list and returns the first instance based on a given condition
						Console.WriteLine($"ID = {customers.Find(customer => customer.Salary > 5000).ID}, " +
						                  $"Name = {customers.Find(customer => customer.Salary > 5000).Name}, " +
										  $"Salary = {customers.Find(customer => customer.Salary > 5000).Salary}");
					}

				static void Example8()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000 };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000 };
						Customer customer3 = new Customer() { ID = 104, Name = "Rob", Salary = 5500 };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

						// Searches the list and returns the last instance based on a given condition
						Console.WriteLine($"ID = {customers.FindLast(customer => customer.Salary > 5000).ID}, " +
						                  $"Name = {customers.FindLast(customer => customer.Salary > 5000).Name}, " +
										  $"Salary = {customers.FindLast(customer => customer.Salary > 5000).Salary}");
					}

				static void Example9()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000 };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000 };
						Customer customer3 = new Customer() { ID = 104, Name = "Rob", Salary = 5500 };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

						// Searches the entire list and returns all the instances based on a given condition
						foreach (Customer customerObject in customers.FindAll(customer => customer.Salary > 5000))
							{
								Console.WriteLine($"ID = {customerObject.ID}, Name = {customerObject.Name}, Salary = {customerObject.Salary}");
							}
					}

				static void Example10()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 };
						Customer customer2 = new Customer() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 };
						Customer customer3 = new Customer() { ID = 103, Name = "John", Salary = 6000, Experience = 6 };
						Customer customer4 = new Customer() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 };

						List<Customer> EmpList = new List<Customer> { customer1, customer2, customer3, customer4 };

						// Search the entire list and return all the instances based on a given condition - PromoteEmployess() + Lambda from Delegate example
						foreach (Customer EmployeeInfo in EmpList.FindAll(Employee => Employee.Experience >= 5))
							{
								Console.WriteLine($"{EmployeeInfo.Name} promoted");
							}
					}

				static void Example11()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000 };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000 };
						Customer customer3 = new Customer() { ID = 104, Name = "Rob", Salary = 5500 };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

						// Returns the index of the first instance based on a given condition
						int index = customers.FindIndex(customer => customer.Salary > 5000);
						Console.WriteLine($"Index = {index}");
						
					}

				static void Example12()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000 };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000 };
						Customer customer3 = new Customer() { ID = 104, Name = "Rob", Salary = 5500 };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

						// Returns the index of the first instance based on a given condition based on a starting point
						int index = customers.FindIndex(2, customer => customer.Salary > 5000);
						Console.WriteLine($"Index = {index}");
						
					}

				static void Example13()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000 };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000 };
						Customer customer3 = new Customer() { ID = 104, Name = "Rob", Salary = 5500 };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

						// Returns the index of the last instance based on a given condition
						int index = customers.FindLastIndex(customer => customer.Salary > 5000);
						Console.WriteLine($"Index = {index}");
						
					}

				static void Example14()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000 };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000 };
						Customer customer3 = new Customer() { ID = 104, Name = "Rob", Salary = 5500 };

						// To convert an list to an array
						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
						Customer[] customersArray = customers.ToArray();    

						foreach (Customer customer in customersArray)
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}");
							}
						
					}

				static void Example15()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000 };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000 };
						Customer customer3 = new Customer() { ID = 104, Name = "Rob", Salary = 5500 };

						// To convert an list to a dictionary
						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
						Dictionary<int, Customer> dictionary = customers.ToDictionary(key => key.ID);

						foreach (KeyValuePair<int, Customer> pair in dictionary)
							{
								Console.WriteLine($"ID = {pair.Value.ID}, Name = {pair.Value.Name}, Salary = {pair.Value.Salary}");
							}
					}

				static void Example16()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 103, Name = "Rob", Salary = 5500, Type = "Retail" };

						// To add 1 new item to the list
						List<Customer> customers = new List<Customer> { customer1, customer2, customer3, new Customer() { ID = 104, Name = "Man", Salary = 8500, Type = "Corporate" } };

						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
					}

				static void Example17()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 103, Name = "Rob", Salary = 5500, Type = "Retail" };
						Customer customer4 = new Customer() { ID = 104, Name = "John", Salary = 6500, Type = "Corporate" };
						Customer customer5 = new Customer() { ID = 105, Name = "Sam", Salary = 3500, Type = "Corporate" };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
						List<Customer> corporateCustomers = new List<Customer> { customer4, customer5 };

						// To add a list of items to the existing list
						customers.AddRange(corporateCustomers);

						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
					}

				static void Example18()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 103, Name = "Rob", Salary = 5500, Type = "Retail" };
						Customer customer4 = new Customer() { ID = 104, Name = "John", Salary = 6500, Type = "Corporate" };
						Customer customer5 = new Customer() { ID = 105, Name = "Sam", Salary = 3500, Type = "Corporate" };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
						List<Customer> corporateCustomers = new List<Customer> { customer4, customer5 };

						// To add a list of items to the existing list
						customers.AddRange(corporateCustomers);

						// To return a range of elements
						foreach (Customer customer in customers.GetRange(3, 2))  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
					}

				static void Example19()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 103, Name = "Rob", Salary = 5500, Type = "Retail" };
						Customer customer4 = new Customer() { ID = 104, Name = "John", Salary = 6500, Type = "Corporate" };
						Customer customer5 = new Customer() { ID = 105, Name = "Sam", Salary = 3500, Type = "Corporate" };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
						List<Customer> corporateCustomers = new List<Customer> { customer4, customer5 };

						// Insert a range of items to the top of the list
						customers.InsertRange(0, corporateCustomers);

						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
					}

				static void Example20()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 103, Name = "Rob", Salary = 5500, Type = "Retail" };
						Customer customer4 = new Customer() { ID = 104, Name = "John", Salary = 6500, Type = "Corporate" };
						Customer customer5 = new Customer() { ID = 105, Name = "Sam", Salary = 3500, Type = "Corporate" };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
						List<Customer> corporateCustomers = new List<Customer> { customer4, customer5 };

						customers.AddRange(corporateCustomers);

						// To remove a specific item from the list
						customers.Remove(customer1);

						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
					}

				static void Example21()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 103, Name = "Rob", Salary = 5500, Type = "Retail" };
						Customer customer4 = new Customer() { ID = 104, Name = "John", Salary = 6500, Type = "Corporate" };
						Customer customer5 = new Customer() { ID = 105, Name = "Sam", Salary = 3500, Type = "Corporate" };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
						List<Customer> corporateCustomers = new List<Customer> { customer4, customer5 };

						customers.AddRange(corporateCustomers);

						// To remove a specific item from the list from a specific index
						customers.RemoveAt(0);

						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
					}

				static void Example22()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 103, Name = "Rob", Salary = 5500, Type = "Retail" };
						Customer customer4 = new Customer() { ID = 104, Name = "John", Salary = 6500, Type = "Corporate" };
						Customer customer5 = new Customer() { ID = 105, Name = "Sam", Salary = 3500, Type = "Corporate" };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
						List<Customer> corporateCustomers = new List<Customer> { customer4, customer5 };

						customers.AddRange(corporateCustomers);

						// To remove all customers based on a condition
						customers.RemoveAll(customer => customer.Type == "Corporate");

						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
					}

				static void Example23()
					{
						Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 103, Name = "Rob", Salary = 5500, Type = "Retail" };
						Customer customer4 = new Customer() { ID = 104, Name = "John", Salary = 6500, Type = "Corporate" };
						Customer customer5 = new Customer() { ID = 105, Name = "Sam", Salary = 3500, Type = "Corporate" };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
						List<Customer> corporateCustomers = new List<Customer> { customer4, customer5 };

						customers.AddRange(corporateCustomers);

						// To remove a range of elements from the list
						customers.RemoveRange(3, 2);

						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
					}

				static void Example24()
					{
						// Object instances from Customer class
						Customer customer1 = new Customer() { ID = 181, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 152, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 193, Name = "Rob", Salary = 5500, Type = "Retail" };
						Customer customer4 = new Customer() { ID = 124, Name = "John", Salary = 6500, Type = "Corporate" };
						Customer customer5 = new Customer() { ID = 135, Name = "Sam", Salary = 3500, Type = "Corporate" };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3, customer4, customer5 };

						Console.WriteLine($"Customers before sorting");
						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
						Console.WriteLine();
						customers.Sort();  // Sorts the customer objects based on Property name

						Console.WriteLine($"Customers sorted based on Salary");
						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
						Console.WriteLine();
						customers.Reverse();  // sorts the customer objects in descending order based on salary

						Console.WriteLine($"Customers in reverse order based on Salary");
						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
						Console.WriteLine();
						SortByName sortName = new SortByName();
						customers.Sort(sortName);
						Console.WriteLine($"Customers sorted based on Name");
						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
					}

				static void Example25()
					{
						// Object instances from Customer class
						Customer customer1 = new Customer() { ID = 181, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 152, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 193, Name = "Rob", Salary = 5500, Type = "Retail" };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

						Console.WriteLine($"Customers before sorting");
						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
						Console.WriteLine();

						customers.Sort((cust1, cust2) => cust1.ID.CompareTo(cust2.ID));  // Sorts the customer objects using lambda expression

						Console.WriteLine($"Customers after sorting");
						foreach (Customer customer in customers)  // iterate through all the items in the collection
							{
								Console.WriteLine($"ID = {customer.ID}, Name = {customer.Name}, Salary = {customer.Salary}, Type = {customer.Type}");
							}
					}

				static void Example26()
					{
						// Object instances from Customer class
						Customer customer1 = new Customer() { ID = 181, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 152, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 193, Name = "Rob", Salary = 5500, Type = "Retail" };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

						// Check to see if all the customer objects within the list have a salary of 5000
						Console.WriteLine($"Are all salaries greater than 5000? {customers.TrueForAll(x => x.Salary > 5000)}");  // Predicate such that Predicate.Condition
					}

				static void Example27()
					{
						// Object instances from Customer class
						Customer customer1 = new Customer() { ID = 181, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 152, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 193, Name = "Rob", Salary = 5500, Type = "Retail" };

						List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

						ReadOnlyCollection<Customer> readOnlyCust = customers.AsReadOnly();  // User is unable to add or remove objects from the class
						Console.WriteLine($"Items = {readOnlyCust.Count}");  // Retrieves the total count of items within the list
					}

				static void Example28()
					{
						// Object instances from Customer class
						Customer customer1 = new Customer() { ID = 181, Name = "Mark", Salary = 4000, Type = "Retail" };
						Customer customer2 = new Customer() { ID = 152, Name = "Pam", Salary = 7000, Type = "Retail" };
						Customer customer3 = new Customer() { ID = 193, Name = "Rob", Salary = 5500, Type = "Retail" };

						// Specifies a list with an initial capcity of 100 elements
						List<Customer> customers = new List<Customer>(100) { customer1, customer2, customer3 };

						Console.WriteLine($"Capacity before trimming = {customers.Capacity}");
						customers.TrimExcess();
						Console.WriteLine($"Capacity after trimming = {customers.Capacity}");  // Returns the number of elements in the list
					}
			}
	}
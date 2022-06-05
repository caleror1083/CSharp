using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
						myStudent.PrintID();
						myStudent.PrintName();
						myStudent.PrintPassMark();
					}

				static void Example2()
					{
						Account myAccount = new Account();  // Create an instance of Account object
						myAccount.PrintName();
					}

				static void Example3()
					{
						decimal depositAmount;

						// create two Account objects
						Account2 account1 = new Account2("Jane Green", 50.00m);
						Account2 account2 = new Account2("John Blue", -7.53m);

						// display initial balance of each object
						Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
						Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

						// prompt for then read input
						Console.Write("\nEnter deposit amount for account1: "); 
						depositAmount = decimal.Parse(Console.ReadLine());
						Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
						account1.Deposit(depositAmount); // add to account1's balance

						// display balances
						Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
						Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

						// prompt for then read input
						Console.Write("\nEnter deposit amount for account2: ");
						depositAmount = decimal.Parse(Console.ReadLine());
						Console.WriteLine($"adding {depositAmount:C} to account2 balance\n");
						account2.Deposit(depositAmount); // add to account2's balance

						// display balances
						Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
						Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

					}
			}
	}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespaces
namespace _028_Properties
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
							Console.Write("Please select an example from 1-5: ");
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
						myStudent.PrintInfo();
					}

				static void Example2()
					{
						Account myAccount = new Account();									// create an Account object and assign it to myAccount
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

				static void Example4()
					{
						Student2 student1 = new Student2("Jane Green", 93);
						Student2 student2 = new Student2("John Blue", 72);

						Console.Write($"{student1.Name}'s letter grade equivalent of ");
						Console.WriteLine($"{student1.Average} is {student1.LetterGrade}");
						Console.Write($"{student2.Name}'s letter grade equivalent of ");
						Console.WriteLine($"{student2.Average} is {student2.LetterGrade}");
					}

				static void Example5()
					{
						// create two AutoPolicy objects
						AutoPolicy policy1 = new AutoPolicy(11111111, "Toyota Camry", "NJ");
						AutoPolicy policy2 = new AutoPolicy(22222222, "Ford Fusion", "ME");

						// display whether each policy is in a no-fault state
						PolicyInNoFaultState(policy1);
						PolicyInNoFaultState(policy2);

						void PolicyInNoFaultState(AutoPolicy policy)					// method that displays whether an AutoPolicy is in a state with no-fault auto insurance 
							{
								Console.WriteLine("The auto policy:");
								Console.Write($"Account #: {policy.AccountNumber}; ");
								Console.WriteLine($"Car: {policy.MakeAndModel};");
								Console.Write($"State {policy.State}; ");
								Console.Write($"{(policy.IsNoFaultState ? "is": " is not")}");
								Console.Write(" a no-fault state\n");
							}
					}

				static void Example6()
					{
						Player tom = new Player();
						Console.WriteLine("The player's health starts at " + tom.Health);
						tom.Health -= 300;
						Console.WriteLine("After getting damaged, the player's health is now at " + tom.Health);
						tom.Health += 400;
						Console.WriteLine("After gaining health, the player's health is now at " + tom.Health);

						Console.WriteLine();
					}
			}
	}
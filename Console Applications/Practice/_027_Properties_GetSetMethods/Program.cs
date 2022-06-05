// Robert Calero - App demonstrating how to protect class fields using get and set methods
using System;

// Namespaces
namespace _027_Properties_GetSetMethods
	{
		// Classes
		internal class Program
			{
				// Methods(Parameters)
				static void Main()    // Main method begins execution of C# app
					{
						Examples myExamples = new Examples();
						myExamples.ProcessExamples();

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

							Player tom = new Player();
							Console.WriteLine("The player's health starts at " + tom.health);
							tom.health -= 300;
							Console.WriteLine("After getting damaged, the player's health is now at " + tom.health);
							tom.health += 400;
							Console.WriteLine("After gaining health, the player's health is now at " + tom.health);

							Console.WriteLine();

							/*
							Bob Attacks Maximus and Deals 74 Damage
							Maximus Has 69 Health
 
							Maximus Attacks Bob and Deals 6 Damage
							Bob Has 6 Health
 
							Bob Attacks Maximus and Deals 48 Damage
							Maximus Has 21 Health
 
							Maximus Attacks Bob and Deals 48 Damage
							Bob Has -42 Health
 
							Bob has Died and Maximus is Victorious
 
							Game Over
							*/

							Warrior maximus = new Warrior("Maximus", 100, 120, 40);
							Warrior bob = new Warrior("Bob", 100, 120, 40);

							Battle.StartFight(maximus, bob);

							Console.WriteLine();

								   Animal2 cat = new Animal2();

					// Call the setter
					cat.SetName("Whiskers");

					// Set the property
					cat.Sound = "Meow";

					Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);

					// Test auto generated getters and setters
					cat.Owner = "Derek";

					Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);

					// Get the read-only id number
					Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);

						Animal2 frog = new Animal2("Bob", "Ribbit");

						// Test static property
						Console.WriteLine("# of Animals : {0}", Animal2.NumOfAnimals2);
						Console.WriteLine();
					}
			}
	}
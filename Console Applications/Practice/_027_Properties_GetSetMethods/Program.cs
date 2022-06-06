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
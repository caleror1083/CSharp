// Robert Calero - App demonstrating how to protect class fields using get and set methods
using System;

class Program
	{
		static void Main()    // Main method begins execution of C# app
			{
				Student myStudent = new Student();
				myStudent.PrintID();
				myStudent.PrintName();
				myStudent.PrintPassMark();

				Account myAccount = new Account();									// create an Account object and assign it to myAccount
				string theName;

				Console.WriteLine($"Initial name is: {myAccount.GetName()}");		// display myAccount's initial name (there isn't one)

				Console.Write("Enter the name: ");									// prompt for the name
				theName = Console.ReadLine();										// read the name
				myAccount.SetName(theName);											// put theName in the myAccount object

				Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");	// display the name stored in the myAccount object

				Account myAccount2 = new Account();									// create an Account object and assign it to myAccount

				Console.WriteLine($"Initial name is: {myAccount.Name2}");			// display myAccount's initial name 

				Console.Write("Enter the name: ");									// prompt for the name
				string theName2 = Console.ReadLine();										// read the name
				myAccount2.Name2 = theName;											// put theName in the myAccount object

				Console.WriteLine($"myAccount's name is: {myAccount2.Name2}");		// display the name stored in the myAccount object

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

				Student2 student1 = new Student2("Jane Green", 93);
				Student2 student2 = new Student2("John Blue", 72);

				Console.Write($"{student1.Name}'s letter grade equivalent of ");
				Console.WriteLine($"{student1.Average} is {student1.LetterGrade}");
				Console.Write($"{student2.Name}'s letter grade equivalent of ");
				Console.WriteLine($"{student2.Average} is {student2.LetterGrade}");

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
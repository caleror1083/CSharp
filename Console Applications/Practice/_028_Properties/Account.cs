using System;

// Namespaces
namespace _028_Properties
	{
		// Classes
		internal class Account
			{
				// Properties
				public string Name { get; set; }  // Property to get and set the name instance variable


				// Methods(Parameters)
				public void PrintName()
					{
						Console.Write("Enter the name: ");									// prompt for the name
						Name = Console.ReadLine();										// read the name

						Console.WriteLine($"myAccount's name is: {Name}");		// display the name stored in the myAccount object
					}
			}
	}
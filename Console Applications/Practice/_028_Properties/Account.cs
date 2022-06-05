using System;

// Namespaces
namespace _028_Properties
	{
		// Classes
		internal class Account
			{
				// Fields
				private string _Name;                    // instance variable

				// Properties
				public string Name                      // property to get and set the name instance variable
					{
						get                               // returns the corresponding instance variable's value
							{
								return _Name;              // returns the value of name to the client code
							}
						set                               // assigns a new value to the corresponding instance variable
							{
								_Name = value;             // value is implicitly declared and initialized
							}
					}

				// Methods(Parameters)
				public void PrintName()
					{
						Console.WriteLine($"Initial name is: {Name}");			// display myAccount's initial name

						Console.Write("Enter the name: ");									// prompt for the name
						string theName = Console.ReadLine();										// read the name
						Name = theName;											// put theName in the myAccount object

						Console.WriteLine($"myAccount's name is: {Name}");		// display the name stored in the myAccount object
					}
			}
	}
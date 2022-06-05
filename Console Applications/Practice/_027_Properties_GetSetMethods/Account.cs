using System;

// Namespaces
namespace _027_Properties_GetSetMethods
    {
        // Classes
        internal class Account                                   // A simple Account class that contains a private instance variable name and public methods to Set and Get name's value.
            {
                // Fields
                private string _Name;                     // instance variable

                // Methods(Parameters)
                public string GetName()                  // method that retrieves the account name from the object
                    {
                        return _Name;                      // returns name's value to this method's caller
                    }

                public void SetName(string accountName)  // method that sets the account name in the object
                    {
                        _Name = accountName;               // store the account name
                    }

                public void PrintName()
                    {
                        Console.WriteLine($"Initial name is: {GetName()}");		// display myAccount's initial name (there isn't one)

						Console.Write("Enter the name: ");									// prompt for the name
						string theName = Console.ReadLine();										// read the name
						SetName(theName);											// put theName in the myAccount object

						Console.WriteLine($"myAccount's name is: {GetName()}");	// display the name stored in the myAccount object
                    }
            }
    }
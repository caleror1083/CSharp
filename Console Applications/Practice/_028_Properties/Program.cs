// Robert Calero - App demonstrating how to protect and encapsulate class fields using properties
namespace _028_Properties
	{
		class Program
			{
				static void Main()    // Main method begins execution of C# app
					{
						Student myStudent = new Student();
						myStudent.PrintInfo();
					}
					                private string _Name2;                    // instance variable
				                public string Name2                      // property to get and set the name instance variable
                    {
                        get                               // returns the corresponding instance variable's value
                            {
                                return _Name2;              // returns the value of name to the client code
                            }
                        set                               // assigns a new value to the corresponding instance variable
                            {
                                _Name2 = value;             // value is implicitly declared and initialized
                            }
                    }

					Account myAccount2 = new Account();									// create an Account object and assign it to myAccount

						Console.WriteLine($"Initial name is: {myAccount.Name2}");			// display myAccount's initial name 

						Console.Write("Enter the name: ");									// prompt for the name
						string theName2 = Console.ReadLine();										// read the name
						myAccount2.Name2 = theName;											// put theName in the myAccount object

						Console.WriteLine($"myAccount's name is: {myAccount2.Name2}");		// display the name stored in the myAccount object
			}
	}
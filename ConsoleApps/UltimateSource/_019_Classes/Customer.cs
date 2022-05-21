// Robert Calero - App demonstrating classes
using System;

class Customer
	{
		public string FirstName { get; set; }    // property to protect the value of _FirstName
		public string LastName { get; set; }    // property to protect the value of _LastName

		public Customer() {}

		public Customer(string firstName, string lastName)    // constructor to initialize the class fields
			{
				FirstName = firstName;    // you can utilize this to refer to an object of the class
				LastName = lastName;
			}

		public void PrintFullName()
			{
				Console.WriteLine("Full Name = {0}", FirstName + " " + LastName);
			}

		~Customer()    // Destructor used to cleanup and resources that the class was holding on to
			{
			}
	}
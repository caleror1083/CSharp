// Robert Calero - App demonstrating instance class memberss
using System;

class Program
	{
		static void Main()    // Main method begins execution of C# app
			{
				Person thePerson = new Person("Rob", "Calero");
				Console.WriteLine(thePerson.GetFullName());

			}
	}
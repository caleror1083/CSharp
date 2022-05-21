// Robert Calero - App demonstrating method hiding
using System;

public class Employee
	{
		public string FirstName;    // instance field
		public string LastName;    // instance field

		public void PrintFullName()
			{
				Console.WriteLine(FirstName + " " + LastName);
			}
	}
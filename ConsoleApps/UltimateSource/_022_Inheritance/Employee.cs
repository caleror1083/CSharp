// Robert Calero - App demonstrating inheritance
using System;

public class Employee
	{
		// Fields
		public string _FirstName;    // instance field
		public string _LastName;     // instance field
		public string _Email;

		// Methods
		public void PrintFullName()
			{
				Console.WriteLine($"{_FirstName} {_LastName} {_Email}");
			}
	}
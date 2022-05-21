// Robert Calero - App demonstrating polymorphism
using System;

public class Employee
	{
		private readonly string _FirstName;    // instance field
		private readonly string _LastName = "LN";    // initializing the instance field without the use of a constructor

		public Employee()
			{
				_FirstName = "FN";    // initializing the instance field using a constructor
			}

		public string FirstName    // FirstName property
			{
				get { return _FirstName; }
			}
		
		public string GetLastName()    // Using Get method to encapsulate the field instead of using Property
			{
				return _LastName;
			}

		public virtual void PrintFullName()    // virtual keyword indicates that this method can be overridden in any derived class
			{
				Console.WriteLine($"{FirstName} {GetLastName()}");
			}
	}
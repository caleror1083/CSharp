// Robert Calero - App demonstrating polymorphism
using System;

public class FullTimeEmployee : Employee  // DerivedClass : BaseClass - inheritance
	{
		public override void PrintFullName()    // overrides the base class method at runtime
			{
				Console.WriteLine(FirstName + " " + GetLastName() + " - Full Time");
			}
	}
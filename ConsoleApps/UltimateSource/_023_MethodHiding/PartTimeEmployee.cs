// Robert Calero - App demonstrating method hiding
using System;

public class PartTimeEmployee : Employee  // DerivedClass : BaseClass - inheritance
	{
		public new void PrintFullName()    // this method hides the base class method
			{
				base.PrintFullName();    // invokes the hidden base class method
				Console.WriteLine(FirstName + " " + LastName + " - Contractor");
			}
	}
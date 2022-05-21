// Robert Calero - App demonstrating abstract classes
using System;

class Customer : ACustomer
	{
		public override void Print()    // derived class must provide implementation for all abtract members.
			{
				Console.WriteLine("Abstract class Print method");
				Console.WriteLine();
			}
	}
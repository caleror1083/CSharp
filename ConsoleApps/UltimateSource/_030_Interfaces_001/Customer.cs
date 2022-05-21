// Robert Calero - App demonstrating interfaces
using System;

class Customer : ICustomer, ICustomer2    // class inheriting from the interfaces
	{
		public void Print()    // Default interface method implementation
			{
				Console.WriteLine("Interface print method");
			}

		void ICustomer2.Print()    // Explicit Interface Implementation due to same method name inside multiple interfaces
			{
				Console.WriteLine("Interface2 print method");				
			}

		public void Print2()    // implementation of the 2nd interface method
			{
				Console.WriteLine("Interface2 print2 method");
			}
	}
// Robert Calero - App demonstrating interfaces
class Program
	{
		static void Main()    // Main method begins execution of C# app
			{
				Customer myCustomer = new Customer();    // interface reference variable pointing to a derived class object
				myCustomer.Print();    // invoking the default interface method
				((ICustomer2)myCustomer).Print();    // invoking the explict interface method
				myCustomer.Print2();    // invoking the interface method
			}
	}
// Robert Calero - App demonstrating method hiding
class Program
	{
		static void Main()    // Main method begins execution of C# app
			{
				FullTimeEmployee FTE = new FullTimeEmployee();
				FTE.FirstName = "Rob";
				FTE.LastName = "Calero";
				FTE.PrintFullName();

				PartTimeEmployee PTE = new PartTimeEmployee();
				PTE.FirstName = "Lance";
				PTE.LastName = "Isku";
				((Employee)PTE).PrintFullName();    // alternate way to invoke the hidden base class method

				Employee PTE2 = new PartTimeEmployee();    // alternate way to invoke the hidden base class method
				PTE2.FirstName = "Lance";
				PTE2.LastName = "Isku";
				PTE2.PrintFullName();

				PartTimeEmployee PTE3 = new PartTimeEmployee();
				PTE3.FirstName = "Lance";
				PTE3.LastName = "Isku";
				PTE3.PrintFullName();
			}
	}
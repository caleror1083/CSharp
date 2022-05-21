// Robert Calero - App demonstrating structs
using System;

class Program
	{
		static void Main()    // Main method begins execution of C# app
			{
				Customer myStudent = new Customer();
				myStudent.ID = 101;
				myStudent.Name = "Bob";
				myStudent.PrintID();
				myStudent.PrintName();

				Console.WriteLine();

				Customer c1 = new Customer(102, "Mark");
				c1.PrintID();
				c1.PrintName();

				Console.WriteLine();

				Customer c2 = new Customer { ID = 103, Name = "Rob" };
				c2.PrintID();
				c2.PrintName();
			}
	}
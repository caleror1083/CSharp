// Robert Calero - App demonstrating abstract classes
using System;

class Program
	{
		static void Main()    // Main method begins execution of C# app
			{
				Customer myCustomer = new Customer();    // abstract reference variable pointing to a derived class object
				myCustomer.Print();

				Shape rect = new Rectangle(5, 5);    // abstract reference variable pointing to a derived class object
				Console.WriteLine($"Rectangle Area {rect.Area()}");

				Shape tri = new Triangle(5, 5);    // abstract reference variable pointing to a derived class object
				Console.WriteLine("Tri Area " + tri.Area());

				Rectangle combRect = new Rectangle(2, 3) + new Rectangle(2, 3);
				Console.WriteLine("Combined Rectangle Area " + combRect.Area());
			}
	}
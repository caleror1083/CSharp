using System;

// Namespaces
namespace _015_Methods_Static
	{
		// Classes
		public class Employees<Type1, Type2>	// Generic class declaration with different types
			{
				// Properties
				public Type1 Name { get; set; }
				public Type2 Age { get; set; }

				// Constructors(Parameters)
				public Employees(Type1 name, Type2 age)
					{
						Name = name;
						Age = age;
					}

				// Methods(Parameters)
				public void DisplayGenericTypes()
					{
						Console.WriteLine($"Name: {Name}");
						Console.WriteLine($"Age: {Age}");
					}
			}
	}
using System;

namespace _015_Methods_Static
{
		public class Employee<Type1, Type2>	// Generic class declaration with different types
			{
				// Properties
				public Type1 Name { get; set; }
				public Type2 Age { get; set; }

				// Constructors(Parameters)
				public Employee(Type1 nameParameter, Type2 ageParameter)
					{
						Name = nameParameter;
						Age = ageParameter;
					}

				// Methods(Parameters)
				public void DisplayGenericTypes()
					{
						Console.WriteLine($"Name: {Name}");
						Console.WriteLine($"Age: {Age}");
					}
			}
}

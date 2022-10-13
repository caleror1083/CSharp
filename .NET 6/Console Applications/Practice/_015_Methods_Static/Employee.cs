using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Methods_Static
{
		public class Employee<Type1, Type2>	// Generic class declaration with different types
			{
				// Properties
				public Type1 Name { get; set; }
				public Type2 Age { get; set; }

				// Constructors(Parameters)
				public Employee(Type1 name, Type2 age)
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

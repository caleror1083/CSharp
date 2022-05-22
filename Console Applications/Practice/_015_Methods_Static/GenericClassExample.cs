using System;

// Namespaces
namespace _015_Methods_Static
	{
		// Classes
		public class GenericClassExample<TypeName, TypeValue>	// Generic class declaration with types
			{
				// Fields
				private readonly TypeName _name;
				private readonly TypeValue _value;
				
				// Constructors(Parameters)
				public GenericClassExample(TypeName nameParameter, TypeValue valueParameter)
					{
						_name = nameParameter;
						_value = valueParameter;
					}

				// Methods
				public void DisplayGenericTypes()
					{
						Console.WriteLine($"Name: {_name}");
						Console.WriteLine($"Age: {_value}");
					}
			}
	}
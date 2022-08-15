// Namespaces
namespace _031_AbstractClasses
	{
		// Abstract classes
		public abstract class Employee
			{
				// Properties
				public string FirstName { get; }
				public string LastName { get; }
				public string SocialSecurityNumber { get; }

				// Constructors(Parameters)
				public Employee(string firstName, string lastName, string socialSecurityNumber)
					{
						FirstName = firstName;
						LastName = lastName;
						SocialSecurityNumber = socialSecurityNumber;
					}

				// return the string representation of Employee object, using properties
				public override string ToString() => $"{FirstName} {LastName}\n" + $"Social Security Number: {SocialSecurityNumber}";

				// Abstract methods that will be overriden by derived classes
				public abstract decimal Earnings();
			}
	}
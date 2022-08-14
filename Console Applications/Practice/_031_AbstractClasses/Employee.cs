// Namespaces
namespace _031_AbstractClasses
	{
		// Abstract classes
		internal abstract class Employee
			{
				// Properties
				public int ID { get; set; }
				public string FirstName { get; set; }
				public string LastName { get; set; }

				// Abstract methods
				public abstract int GetMonthlySalary();

				// Methods(Parameters)
				public string FullName()
					{
						return $"{FirstName} {LastName}";
					}
			}
	}
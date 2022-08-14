// Namespaces
namespace _031_AbstractClasses
	{
		// Abstract classes
		internal class FullTimeEmployee : Employee
			{
				// Properties
				public int AnnualSalary { get; set; }

				// Overriden methods
				public override int GetMonthlySalary()
					{
						return AnnualSalary / 12;
					}
			}
	}
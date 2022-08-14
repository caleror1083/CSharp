// Namespaces
namespace _031_AbstractClasses
	{
		// Abstract classes
		internal class ContractEmployee : Employee
			{
				// Properties
				public int HourlyPay { get; set; }

				// Overriden methods
				public override int GetMonthlySalary()
					{
						return HourlyPay * 173;
					}
			}
	}
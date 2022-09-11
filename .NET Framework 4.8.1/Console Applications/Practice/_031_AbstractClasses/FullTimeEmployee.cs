using System;

// Namespaces
namespace _031_AbstractClasses
	{
		// Classes
		public class FullTimeEmployee : Employee
			{
				// Fields
				private decimal weeklySalary;

				// Properties
				public decimal WeeklySalary
					{
						get { return weeklySalary; }
						set
							{
								if (value < 0)
									{
										throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(WeeklySalary)} must be greater than 0");
									}
								weeklySalary = value;
							}
					}

				// Constructors(Parameters)
				public FullTimeEmployee(string firstName, string lastName, string socialSecurityNumber, decimal weeklySalary) : base(firstName, lastName, socialSecurityNumber)
					{
						WeeklySalary = weeklySalary;
					}

				// Overriden methods
				public override decimal Earnings() => WeeklySalary;  // calculate earnings
				public override string ToString() => $"Salaried employee: {base.ToString()}\n" + $"Weekly salary: {WeeklySalary:C}";
			}
	}
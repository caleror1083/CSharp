using System;

// Namespaces
namespace _031_AbstractClasses
	{
		// Classes
		public class BasePlusCommissionEmployee : CommissionEmployee
			{
				// Fields
				private decimal baseSalary;

				// Properties
				public decimal BaseSalary  // base salary per week
					{
						get { return baseSalary; }
						set
							{
								if (value < 0)
									{
										throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(BaseSalary)} must be greater than 0");
									}
								baseSalary = value;
							}
					}

				// Constructors(Parameters)
				public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate, decimal baseSalary) : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
					{
						BaseSalary = baseSalary;
					}

				// Overriden methods
				public override decimal Earnings() => BaseSalary + base.Earnings();  // calculate earnings
				public override string ToString() => $"Base-salaried: {base.ToString()}\n" +
				                                     $"Base salary: {BaseSalary:C}";
			}
	}
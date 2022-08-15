using System;

// Namespaces
namespace _031_AbstractClasses
	{
		// Classes
		public class CommissionEmployee : Employee
			{
				//Fields
				private decimal grossSales;
				private decimal commissionRate;

				// Properties
				public decimal GrossSales  // gross weekly sales
					{
						get { return grossSales; }
						set
							{
								if (value < 0)
									{
										throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GrossSales)} must be greater than 0");
									}
								grossSales = value;
							}
					}

				public decimal CommissionRate  // commission percentage
					{
						get { return commissionRate; }
						set
							{
								if (value <= 0 || value >= 1)
									{
										throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(CommissionRate)} must be greater than or equal to 0 and less than or equal to 1");
									}
								commissionRate = value;
							}
					}

				// Constructors(Parameters)
				public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate) : base(firstName, lastName, socialSecurityNumber)
					{
						GrossSales = grossSales;
						CommissionRate = commissionRate;
					}

				// Overriden methods
				public override decimal Earnings() => CommissionRate * GrossSales;  // calculate earnings
				public override string ToString() => $"Commission employee: {base.ToString()}\n" +
				                                     $"Gross sales: {GrossSales:C}\n" +
													 $"Commission rate: {CommissionRate:F2}";
			}
	}
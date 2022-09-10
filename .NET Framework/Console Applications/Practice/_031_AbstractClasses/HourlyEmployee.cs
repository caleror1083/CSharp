using System;

// Namespaces
namespace _031_AbstractClasses
	{
		// Classes
		public class HourlyEmployee : Employee
			{
				// Fields
				private decimal wage;
				private decimal hours;

				// Properties
				public decimal Wage  // wage per hour
					{
						get { return wage; }
						set
							{
								if (value < 0)
									{
										throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Wage)} must be greater than 0");
									}
								wage = value;
							}
					}

				public decimal Hours  // hours worked for the week
					{
						get { return hours; }
						set
							{
								if (value < 0 || value > 168)
									{
										throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Hours)} must be greater than 0 and <= 168");
									}
								hours = value;
							}
					}

				// Constructors(Parameters)
				public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber, decimal hourlyWage, decimal hoursWorked) : base(firstName, lastName, socialSecurityNumber)
					{
						Wage = hourlyWage;
						Hours = hoursWorked;
					}

				// Overriden methods
				public override decimal Earnings()
					{
						if (Hours <= 40) // no overtime
							{
								return Wage * Hours;
							}
						else
							{
								return (Wage * Hours) + ((Hours - 40) * 1.5M);  // overtime
							}
					}
				public override string ToString() => $"Hourly employee: {base.ToString()}\n" + $"Hourly wage: {Wage:C}\nHours Worked: {Hours:F2}";
			}
	}
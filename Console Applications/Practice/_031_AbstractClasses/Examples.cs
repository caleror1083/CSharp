using System;
using System.Collections.Generic;

// Namespaces
namespace _031_AbstractClasses
	{
		// Classes
		internal class Examples
			{
				// Methods(Parameters)
				public void ProcessExamples()
					{
						Start:
							Console.Write($"Please select an example from 1-5: ");
							bool check = int.TryParse(Console.ReadLine(), out int choice);

							if (check)
								{
									switch (choice)
										{
											case 1:
												Example1();
												break;
											case 2:
												Example2();
												break;
											case 3:
												Example3();
												break;
											case 4:
												Example4();
												break;
											case 5:
												Example5();
												break;
											default:
												Console.WriteLine($"Your choice is invalid");
												goto Start;
										}
								}
							else
								{
									Console.WriteLine($"Selection chosen is incorrect");
									goto Start;
								}

						Decide:
							Console.Write($"Do you want to do another example? - Yes or No: ");
							string decision = Console.ReadLine();
							Console.WriteLine();

							switch (decision.ToUpper())
								{
									case "YES":
										goto Start;
									case "NO":
										break;
									default:
										Console.WriteLine($"Your decision is invalid. Try again");
										goto Decide;
								}
					}

				static void Example1()
					{
						FullTimeEmployee ftEmployee = new FullTimeEmployee("Programmer", "Rob", "111-11-1111", 800.00M);
						HourlyEmployee hourlyEmployee = new HourlyEmployee("IT", "Rob", "222-22-2222", 16.35M, 40.0M);
						CommissionEmployee commissionEmployee = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
						BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

						Console.WriteLine("Employees processed individually:\n");
						Console.WriteLine($"{ftEmployee}\nEarned: " + $"{ftEmployee.Earnings():C}\n");
						Console.WriteLine($"{hourlyEmployee}\nEarned: " + $"{hourlyEmployee.Earnings():C}\n");
						Console.WriteLine($"{commissionEmployee}\nEarned: " + $"{commissionEmployee.Earnings():C}\n");
						Console.WriteLine($"{basePlusCommissionEmployee}\nEarned: " + $"{basePlusCommissionEmployee.Earnings():C}\n");

						List<Employee> employees = new List<Employee> { ftEmployee, hourlyEmployee, commissionEmployee, basePlusCommissionEmployee };  // create List<Employee> and initialize with employee objects

						Console.WriteLine("Employees process polymorphically:\n");
						foreach (Employee currentEmployee in employees)
							{
								Console.WriteLine(currentEmployee);  // invokes ToString

								// determine whether element is a BasePlusCommissionEmployee
								if (currentEmployee is BasePlusCommissionEmployee employee)  // downcast Employee reference to BasePlusCommissionEmployee reference
									{ 
										employee.BaseSalary *= 1.10M;
										Console.WriteLine("New base salary with 10% increase is: " + $"{employee.BaseSalary:C}");
									}
								Console.WriteLine($"Earned: {currentEmployee.Earnings():C}\n");
							}

						// get type name of each object in employees
						for (int typeName = 0; typeName < employees.Count; typeName++)
							{
								Console.WriteLine($"Employee {typeName} is a {employees[typeName].GetType().Name}");
							}
					}

				static void Example2()
					{
						Shape triangle = new Triangle(5, 5);    // abstract reference variable pointing to a derived class object
						Console.WriteLine($"Triangle area: {triangle.Area()}");
					}

				static void Example3()
					{
						Shape rectangle = new Rectangle(5, 5);    // abstract reference variable pointing to a derived class object
						Console.WriteLine($"Rectangle area: {rectangle.Area()}");
					}

				static void Example4()
					{
						Rectangle multipleRectangles = new Rectangle(2, 3) + new Rectangle(2, 3);
						Console.WriteLine($"The combined rectangle area is {multipleRectangles.Area()}");
					}

				static void Example5()
					{
						
					}
			}
	}
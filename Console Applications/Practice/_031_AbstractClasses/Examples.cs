using System;

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
						FullTimeEmployee ftEmployee = new FullTimeEmployee()
							{
								ID = 101,
								FirstName = "Mark",
								LastName = "May",
								AnnualSalary = 41616
							};
						Console.WriteLine($"{ftEmployee.FullName()}");
						Console.WriteLine($"{ftEmployee.GetMonthlySalary()}");

						Console.WriteLine("----------");

						ContractEmployee hrlyEmployee = new ContractEmployee()
							{
								ID = 102,
								FirstName = "Sara",
								LastName = "S",
								HourlyPay = 16
							};
						Console.WriteLine($"{hrlyEmployee.FullName()}");
						Console.WriteLine($"{hrlyEmployee.GetMonthlySalary()}");
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
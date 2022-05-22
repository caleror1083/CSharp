// Robert Calero - App demonstrating polymorphism
class Program
	{
		static void Main()    // Main method begins execution of C# app
			{
				Employee[] employees = new Employee[4];

				employees[0] = new Employee();
				employees[1] = new FullTimeEmployee();
				employees[2] = new PartTimeEmployee();
				employees[3] = new TemporaryEmployee();

				foreach(Employee e in employees)
					{
						e.PrintFullName();
					}
			}
	}
// Robert Calero - App demonstrating inheritance
using System;

class Program
	{
		static void Main()    // Main method begins execution of C# app
			{
				FullTimeEmployee FTE = new FullTimeEmployee();
				FTE._FirstName = "Rob";
				FTE._LastName = "Calero";
				FTE._Email = "caleror1083@gmail.com";
				FTE._YearlySalary = 500000F;
				FTE.PrintFullName();
				Console.WriteLine(FTE._YearlySalary);

				PartTimeEmployee PTE = new PartTimeEmployee();
				PTE._FirstName = "Lance";
				PTE._LastName = "Isku";
				PTE._Email = "hbkid084@gmail.com";
				PTE._HourlyRate = 25.00F;
				PTE.PrintFullName();
				Console.WriteLine(PTE._HourlyRate);
			}
	}
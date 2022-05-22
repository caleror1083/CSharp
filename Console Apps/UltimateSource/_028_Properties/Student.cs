// Robert Calero - App demonstrating how to protect and encapsulate class fields using properties
using System;

namespace _028_Properties
	{
		public class Student
			{
				public void PrintInfo()
					{
						// Object instantiations
						StudentData student = new StudentData();
						
						Console.Write("Whats is the ID? ");
						student.ID = int.Parse(Console.ReadLine());

						Console.Write("Whats is the name? ");
						student.Name = Console.ReadLine();

						if (student.Name.StartsWith("M"))    // Searches a specific instance of the student class
							{
								Console.WriteLine($"Student exists");
							}
						else
							{
								Console.WriteLine($"Student does not exists");
							}

						Console.Write("Whats is the Passmark? ");
						student.PassMark = int.Parse(Console.ReadLine());

						Console.Write("Whats is the City? ");
						student.City = Console.ReadLine();

						Console.WriteLine();

						Console.WriteLine($"ID = {student.ID}");
						Console.WriteLine($"Name = {student.Name}");
						Console.Write($"PassMark = {student.PassMark}");

						if (student.PassMark <= 60)
							{
								Console.WriteLine(" Try harder please");
							}

						Console.WriteLine($"City = {student.City}");
					}
			}
	}
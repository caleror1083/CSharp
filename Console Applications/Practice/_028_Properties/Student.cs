// Robert Calero - App demonstrating how to protect and encapsulate class fields using properties
using System;

// Namespaces
namespace _028_Properties
	{
		// Classes
		internal class Student
			{
				// Fields
				private int _ID;
				private string _Name;

				// Properties
				public int ID    // ID read/write property
					{
						set
							{
								if (value <= 0)
									{
										throw new Exception("Student ID cannot be 0 or negative");
									}
								_ID = value;
							}
						get
							{
								return _ID;
							}
				
					}

				public string Name    // Name read/write property
					{
						set
							{
								if (string.IsNullOrEmpty(value))
									{
										throw new Exception("Name cannot be null or empty");
									}
								_Name = value;
							}
						get
							{
								return string.IsNullOrEmpty(_Name) ? "No Name" : _Name;
							}
				
					}

				public int PassMark { get; set; }    // auto implemented PassMark property
				public string City { get; set; }    // auto implemented City property

				// Methods(Parameters)
				public void PrintInfo()
					{
						// Object instantiations					
						Console.Write("Whats is the ID? ");
						ID = int.Parse(Console.ReadLine());

						Console.Write("Whats is the name? ");
						Name = Console.ReadLine();

						if (Name.StartsWith("M"))    // Searches a specific instance of the student class
							{
								Console.WriteLine($"Student exists");
							}
						else
							{
								Console.WriteLine($"Student does not exists");
							}

						Console.Write("Whats is the Passmark? ");
						PassMark = int.Parse(Console.ReadLine());

						Console.Write("Whats is the City? ");
						City = Console.ReadLine();

						Console.WriteLine();

						Console.WriteLine($"ID = {ID}");
						Console.WriteLine($"Name = {Name}");
						Console.Write($"PassMark = {PassMark}");

						if (PassMark <= 60)
							{
								Console.WriteLine(" Try harder please");
							}

						Console.WriteLine($"City = {City}");
					}
			}
	}
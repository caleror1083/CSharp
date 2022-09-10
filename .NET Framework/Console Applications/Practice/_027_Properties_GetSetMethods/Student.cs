using System;

// Namespaces
namespace _027_Properties_GetSetMethods
	{
		// Classes
		internal class Student
			{
				// Fields
				private int _ID;
				private string _Name;
				private int _PassMark;

				// Methods(Parameters)
				public int GetID()
					{
						return _ID;
					}

				public void SetID(int paramID)
					{
						if (paramID <= 0)
							{
								throw new Exception("Student ID cannot be negative");
							}
						_ID = paramID;
					}

				public string GetName()
					{
						return string.IsNullOrEmpty(_Name) ? "No Name" : _Name;
					}

				public void SetName(string paramName)
					{
						if (string.IsNullOrEmpty(paramName))
							{
								throw new Exception("Name cannot be null or empty");
							}
						_Name = paramName;
					}

				public int GetPassMark()
					{
						return _PassMark;
					}

				public void SetPassMark(int paramPassMark)
					{
						if (paramPassMark <= 0)
							{
								throw new Exception("Student ID cannot be negative");
							}
						_PassMark = paramPassMark;
					}

				public void PrintInfo()
					{
						Console.Write($"What is your student ID? ");
						_ID = int.Parse(Console.ReadLine());
						SetID(_ID);

						Console.Write($"What is the name? ");
						_Name = Console.ReadLine();
						SetName(_Name);

						if (_Name.StartsWith("M"))    // Searches a specific instance of the student class
							{
								Console.Write("Whats is the Passmark? ");
								_PassMark = int.Parse(Console.ReadLine());
								SetPassMark(_PassMark);

								Console.WriteLine($"Student ID = {GetID()}");
								Console.WriteLine($"Student Name = {GetName()}");
								Console.Write($"PassMark = {GetPassMark()}");

								if (_PassMark <= 60)
									{
										Console.WriteLine(" - Try harder please");
									}
							}
						else
							{
								Console.Write($"Student does not exists");
							}
						Console.WriteLine();
					}
			}
	}
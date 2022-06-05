// Robert Calero - App demonstrating how to protect class fields using get and set methods
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
				private readonly int _PassMark = 60;

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

				public void PrintID()
					{
						SetID(101);
						Console.WriteLine($"Student ID = {GetID()}");
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

				public void PrintName()
					{
						SetName("Rob");
						Console.WriteLine($"Student Name = {GetName()}");
					}

				public int GetPassMark()
					{
						return _PassMark;
					}

				public void PrintPassMark()
					{
						Console.WriteLine($"PassMark = {GetPassMark()}");
					}
			}
	}
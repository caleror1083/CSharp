// Robert Calero - App displaying a roster of students in a given class
using System;

namespace StudentRoster
	{
		class Program
			{
				static void Main()
					{
						Console.WriteLine("C++ C867 Scripting and Programming - Applications Project rewritten in C#");
						Console.WriteLine("Programming language used: C#");
						Console.WriteLine("Student ID: 000998416, Robert Calero");
						Console.WriteLine();

						Roster classRoster = new Roster();
						classRoster.RunRoster();
					}
			}
	}
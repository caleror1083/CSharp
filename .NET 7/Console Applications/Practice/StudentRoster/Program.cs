// Robert Calero - App displaying a roster of students in a given class
using System;

namespace StudentRoster;

internal class Program
{
    internal static void Main()
    {
        Console.WriteLine("C++ C867 Scripting and Programming Applications");
		Console.WriteLine("Programming language used: C#");
		Console.WriteLine("Student ID: 000998416, Robert Calero");
		Console.WriteLine();

		var classRoster = new Roster();
		Degree degree;
		
		string[] studentData =
		{
		    "A1,John,Smith,John1989@gm ail.com,20,30,35,40,SECURITY",
		    "A2,Suzan,Erickson,Erickson_1990@gmailcom,19,50,30,40,NETWORK",
		    "A3,Jack,Napoli,The_lawyer99yahoo.com,19,20,40,33,SOFTWARE",
		    "A4,Erin,Black,Erin.black@comcast.net,22,50,58,40,SECURITY",
		    "A5,Robert,Calero,rcalero@wgu.edu,36,15,20,25,SOFTWARE"
		};

		var DATA_COLUMNS = 9;
		var NUMBER_OF_STUDENTS = studentData.Length;
		string output;
		var col = new string[DATA_COLUMNS];

		for (var i = 0; i < NUMBER_OF_STUDENTS; i++)
		{
            var studentInfo = studentData[i].Split(',');

			for (var x = 0; x < DATA_COLUMNS; x++)
			{
                col[x] = studentInfo[x];
			}

			switch (col[8].Trim())
			{
                case "NETWORK":
				    degree = Degree.NETWORK;
					break;
                case "SECURITY":
				    degree = Degree.SECURITY;
					break;
                case "SOFTWARE":
				    degree = Degree.SOFTWARE;
					break;
				default:
				    degree = Degree.NETWORK;
					break;
			}

			classRoster.Add(col[0], col[1], col[2], col[3], int.Parse(col[4]), int.Parse(col[5]), int.Parse(col[6]), int.Parse(col[7]), degree);
		}

		Console.WriteLine("\nClass Roster:");
		classRoster.PrintAll();
		Console.WriteLine();

		Console.WriteLine("Invalid emails are:");
		classRoster.PrintInvalidEmails();
		Console.WriteLine();

		Console.WriteLine("Average number of days in the 3 courses by Student ID:");

		for (var i = 0; i < NUMBER_OF_STUDENTS; i++)
		{
			classRoster.PrintAverageDaysInCourse(classRoster.classRosterList[i].StudentId);
		}

		Console.WriteLine();

		Console.WriteLine("Students in Degree Program SOFTWARE:");
		classRoster.PrintByDegreeProgram(Degree.SOFTWARE);
		Console.WriteLine();

		classRoster.Remove("A3");
		classRoster.Remove("A3");
		Console.WriteLine();

		Console.WriteLine("Updated Class Roster");
		classRoster.PrintAll();
		Console.WriteLine();
		Console.ReadKey();
	}
}
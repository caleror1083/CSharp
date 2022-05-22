// Robert Calero - App displaying a roster of students in a given class
using System;

// Namespace
namespace StudentRoster
	{
		// Classes
		class Roster
			{
				// Fields
				// Constructors
				// Properties

				// Methods(Parameters)
				public void RunRoster()
					{
						object[,] studentData = {
													{ "A1", "John",   "Smith",    "John1989@gm ail.com",    20, 30, 35, 40, (int)EnumDegree.SECURITY },
												    { "A2", "Suzan",  "Erickson", "Erickson_1990@gmailcom", 19, 50, 30, 40, (int)EnumDegree.NETWORK },
												    { "A3", "Jack",   "Napoli",   "The_lawyer99yahoo.com",  19, 20, 40, 33, (int)EnumDegree.SOFTWARE },
												    { "A4", "Erin",   "Black",    "Erin.black@comcast.net", 22, 50, 58, 40, (int)EnumDegree.SECURITY },
												    { "A5", "Robert", "Calero",   "rcalero@wgu.edu",        36, 15, 20, 25, (int)EnumDegree.SOFTWARE }
												};
						
						
						for (int row = 0; row < studentData.GetLength(0); row++)
							{
								for (int column = 0; column < studentData.GetLength(1); column++)
									{
										Console.Write($"{studentData[row, column]} ");
									}
								Console.WriteLine();
							}
					}

				// Methods
				public virtual void Print()
					{
						Console.WriteLine($"Student ID: {StudentID} \t");
						Console.WriteLine($"First Name: {FirstName} \t");
						Console.WriteLine($"Last Name: {LastName} \t");
						Console.WriteLine($"Age: {Age} \t");

						int* days = DaysToComplete;
						Console.WriteLine($"Days In Course: {(int)days}, {(int)days}, {(int)days} \t");

						string degreeString = "";
						switch (Degree)
							{
								case (int)EnumDegree.NETWORK:
									degreeString = "Network";
									break;
								case (int)EnumDegree.SECURITY:
									degreeString = "Security";
									break;
								case (int)EnumDegree.SOFTWARE:
									degreeString = "Software";
									break;
							}
						Console.WriteLine($"Degree Program: {degreeString}");
					}

				static void Add()
					{}

				static void PrintAll()
					{
					}

				static void PrintInvalidEmails()
					{}

				static void PrintAverageDaysInCourse()
					{}

				static void PrintByDegreeProgram()
					{}

				static void Remove()
					{}

				~Roster()    // Destructor used to cleanup and resources that the class was holding on to
					{
					}
			}
	}
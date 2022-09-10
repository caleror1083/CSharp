// Robert Calero - App displaying a roster of students in a given class
using System;

namespace StudentRoster
	{
		public unsafe class Student
			{
				// Fields
				private int* _daysToComplete;
				private readonly int[] _daysInCourse = new int[3];

				// Properties
				public string StudentID { get; set; }
				public string FirstName { get; set; }
				public string LastName { get; set; }
				public string EmailAddress { get; set; }
				public int Age { get; set; }

				public int* DaysToComplete
					{
						set
							{
								_daysToComplete = value;

								for (int i = 0; i < _daysInCourse.Length; i++)
									{
										
									}
							}
						get
							{
								return _daysToComplete;
							}
					}

				public int Degree { get; set; }

				// Constructors
				public Student() {}

				public Student(string studentID, string firstName, string lastName, string emailAddress, int age, int* daysToComplete, int degree)
					{
						StudentID = studentID;
						FirstName = firstName;
						LastName = lastName;
						EmailAddress = emailAddress;
						Age = age;
						DaysToComplete = daysToComplete;
						Degree = degree;

						for (int i = 0; i < _daysInCourse.Length; i++)
							{
								_daysInCourse[i] = 0;
							}

						for (int i = 0; i < _daysInCourse.Length; ++i)
							{
								_daysInCourse[i] = _daysInCourse[i];
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

				~Student()    // Destructor used to cleanup and resources that the class was holding on to
					{
					}
			}
	}
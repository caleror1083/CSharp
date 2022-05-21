// Robert Calero - App displaying a roster of students in a given class
using System;

namespace StudentRoster
	{
		public unsafe class Student
			{
				// Fields
				private int* _daysToComplete;
				private readonly int[] _daysInCourse = new int[3];

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

				~Student()    // Destructor used to cleanup and resources that the class was holding on to
					{
					}
			}
	}
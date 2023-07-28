// Robert Calero - App displaying a roster of students in a given class
using System;

namespace StudentRoster;

public class Student
{
	// Fields
	protected string studentId, firstName, lastName, emailAddress;
	protected int age;
	protected int[] daysToComplete;
	protected Degree degree;
	public const int daysInCourseArraySize = 3;

	// Properties
	public string StudentId
	{
		get { return studentId; }
		set { studentId = value; }
	}

	public string FirstName
	{
		get { return firstName; }
		set { firstName = value; }
	}

	// Constructors
	public Student()
	{
		studentId = "";
		firstName = "";
		lastName = "";
		emailAddress = "";
		age = -1;

		daysToComplete = new int[daysInCourseArraySize];
		for (int i = 0; i < daysInCourseArraySize; i++)
		{
			daysToComplete[i] = 0;
		}
	}

	public Student(string studentId, string firstName, string lastName, string emailAddress, int age, int[] daysToComplete, Degree degree)
		{
			this.studentId = studentId;
			this.firstName = firstName;
			this.lastName = lastName;
			this.emailAddress = emailAddress;
			this.age = age;

			this.daysToComplete = new int[daysInCourseArraySize];
			for (int i = 0; i < daysInCourseArraySize; i++)
			{
				this.daysToComplete[i] = daysToComplete[i];
			}

			this.degree = degree;
		}

	// Methods
	public virtual void Print()
		{
			Console.WriteLine($"Student ID: {StudentID} \t");
			Console.WriteLine($"First Name: {FirstName} \t");
			Console.WriteLine($"Last Name: {LastName} \t");
			Console.WriteLine($"Age: {Age} \t");

			int days = DaysToComplete;
			Console.WriteLine($"Days In Course: {(int)days}, {(int)days}, {(int)days} \t");

			string degreeString = "";
			switch (Degree)
				{
					case (int)Degree.NETWORK:
						degreeString = "Network";
						break;
					case (int)Degree.SECURITY:
						degreeString = "Security";
						break;
					case (int)Degree.SOFTWARE:
						degreeString = "Software";
						break;
				}
			Console.WriteLine($"Degree Program: {degreeString}");
		}

	~Student()    // Destructor used to cleanup and resources that the class was holding on to
		{
		}
}
using System;

namespace StudentRoster;

// this is the stundent base class
public class Student
{
	protected string studentId, firstName, lastName, emailAddress;
	protected int age;
	protected int[] daysToComplete;
	protected Degree degree;
	public const int daysInCourseArraySize = 3;

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

	public string LastName
	{
		get { return lastName; }
		set { lastName = value; }
	}

	public string EmailAddress
	{
		get { return emailAddress; }
		set { emailAddress = value; }
	}

	public int Age
	{
		get { return age; }
		set { age = value; }
	}

	public int[] DaysToComplete
	{
		get { return daysToComplete; }
		set { daysToComplete = value; }
	}

	public virtual Degree Degree
	{
		get { return degree; }
		set { degree = value; }
	}

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

	public virtual void Print()
	{
		Console.WriteLine($"Student ID: {StudentId} \tFirst Name: {FirstName} \tLast Name: {LastName} \tAge: {Age} \tDays In Course: {{{DaysToComplete[0]}, {DaysToComplete[1]}, {DaysToComplete[2]}}}\tDegree Program: {DegreeString(Degree)}");
	}

	private static string DegreeString(Degree degree)
	{
		switch (degree)
		{
			case Degree.NETWORK:
            {
				return "NETWORK";
            }
			case Degree.SECURITY:
            {
				return "SECURITY";
            }
			case Degree.SOFTWARE:
            {
				return "SOFTWARE";
            }
			default:
            {
				return "UNKNOWN";
            }
		}
	}
}
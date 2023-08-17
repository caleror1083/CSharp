using System;

namespace StudentRoster;

public class Roster
{
    private const int NUMBER_OF_STUDENTS = 5;
    public Student[] classRosterArray = new Student[NUMBER_OF_STUDENTS];

    public static void ProcessRoster()
    {
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
        var col = new string[DATA_COLUMNS];

        for (var i = 0; i < NUMBER_OF_STUDENTS; i++)
        {
            var studentInfo = studentData[i].Split(',');
            for (int x = 0; x < DATA_COLUMNS; x++)
            {
                col[x] = studentInfo[x];
            }

            switch (col[8].Trim().ToUpper())
            {
                case "SECURITY":
                    degree = Degree.SECURITY;
                    break;
                case "NETWORK":
                    degree = Degree.NETWORK;
                    break;
                case "SOFTWARE":
                    degree = Degree.SOFTWARE;
                    break;
                default:
                    // Set a default degree here if needed
                    degree = Degree.NETWORK;
                    break;
            }

            classRoster.Add(col[0], col[1], col[2], col[3], int.Parse(col[4]), int.Parse(col[5]), int.Parse(col[6]), int.Parse(col[7]), degree);
        }

        Console.WriteLine("Class Roster:");
        classRoster.PrintAll();
        Console.WriteLine();

        Console.WriteLine("Invalid emails are:");
        classRoster.PrintInvalidEmails();
        Console.WriteLine();

        Console.WriteLine("Average number of days in the 3 courses by Student ID:");
        for (int i = 0; i < NUMBER_OF_STUDENTS; i++)
        {
            classRoster.PrintAverageDaysInCourse(classRoster.classRosterArray[i].StudentId);
        }
        Console.WriteLine();

        Console.WriteLine("Students in Degree Program SOFTWARE:");
        classRoster.PrintByDegreeProgram(Degree.SOFTWARE);
        Console.WriteLine();

        classRoster.Remove("A3");
        classRoster.Remove("A3");
        Console.WriteLine();

        Console.WriteLine("Updated Roster:");
        classRoster.PrintAll();
        Console.WriteLine();
    }

    public void Add(string studentId, string firstName, string lastName, string emailAddress, int age, int daysInCourse1, int daysInCourse2, int daysInCourse3, Degree degree)
    {
        int[] daysToComplete = { daysInCourse1, daysInCourse2, daysInCourse3 };
        Student student;

        switch (degree)
        {
            case Degree.NETWORK:
                student = new NetworkStudent(studentId, firstName, lastName, emailAddress, age, daysToComplete);
                break;
            case Degree.SECURITY:
                student = new SecurityStudent(studentId, firstName, lastName, emailAddress, age, daysToComplete);
                break;
            case Degree.SOFTWARE:
                student = new SoftwareStudent(studentId, firstName, lastName, emailAddress, age, daysToComplete);
                break;
            default:
                student = new NetworkStudent(studentId, firstName, lastName, emailAddress, age, daysToComplete);
                break;
        }

        for (int i = 0; i < NUMBER_OF_STUDENTS; i++)
        {
            if (classRosterArray[i] == null)
            {
                classRosterArray[i] = student;
                break;
            }
        }
    }

    public void PrintAll()
    {
        foreach (var student in classRosterArray)
        {
            if (student != null)
            {
                student.Print();
            }
        }
    }

    public void PrintInvalidEmails()
    {
        bool valid;
        foreach (var student in classRosterArray)
        {
            if (student == null)
            {
                continue;
            }

            valid = false;
            var email = student.EmailAddress;
            var emailLength = email.Length;
            var x = 0;

            while (x < emailLength && email[x] != ' ' && email[x] != '@')
            {
                x++;
                if (x < emailLength && email[x] == '@')
                {
                    x++;
                    while (x < emailLength && email[x] != ' ' && email[x] != '@' && email[x] != '.')
                    {
                        x++;
                        if (x < emailLength && email[x] == '.')
                        {
                            x++;
                            while (x < emailLength && email[x] != ' ' && email[x] != '@' && email[x] != '.')
                            {
                                x++;
                                if (x == emailLength)
                                {
                                    valid = true;
                                }
                            }
                        }
                    }
                }
            }

            if (!valid)
            {
                Console.WriteLine(email);
            }
        }
    }

    public void PrintAverageDaysInCourse(string studentId)
    {
        foreach (var student in classRosterArray)
        {
            if (student != null && student.StudentId == studentId)
            {
                var days = student.DaysToComplete;
                Console.Write($"{studentId}\t");
                Console.WriteLine($"{(days[0] + (float)days[1] + days[2]) / 3:F0}");
                return;
            }
        }
    }

    public void PrintByDegreeProgram(Degree degree)
    {
        foreach (Student student in classRosterArray)
        {
            if (student != null && student.Degree == degree)
            {
                student.Print();
            }
        }
    }

    public void Remove(string studentId)
    {
        Console.Write($"Removing student with ID {studentId}... ");

        for (var i = 0; i < NUMBER_OF_STUDENTS; i++)
        {
            if (classRosterArray[i] == null)
            {
                Console.WriteLine("ERROR: Student with this ID not found");
                break;
            }
            else if (classRosterArray[i].StudentId == studentId)
            {
                classRosterArray[i] = null;
                Console.WriteLine("Student removed");
                break;
            }
        }
    }
}
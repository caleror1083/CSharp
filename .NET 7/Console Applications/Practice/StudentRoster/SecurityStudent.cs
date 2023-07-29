namespace StudentRoster;

public class SecurityStudent : Student
{
    private new Degree degree = Degree.SECURITY;

    public SecurityStudent() : base() {}
    public SecurityStudent(string studentId, string firstName, string lastName, string emailAddress, int age, int[] daysToComplete) : base(studentId, firstName, lastName, emailAddress, age, daysToComplete, Degree.SECURITY) {}

    public override Degree Degree
    {
        get { return degree; }
        set { degree = value; }
    }
}
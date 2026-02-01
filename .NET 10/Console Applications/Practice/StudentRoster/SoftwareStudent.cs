namespace StudentRoster;

public class SoftwareStudent : Student
{
    private new Degree degree = Degree.SOFTWARE;

    public SoftwareStudent() : base() {}
    public SoftwareStudent(string studentId, string firstName, string lastName, string emailAddress, int age, int[] daysToComplete) : base(studentId, firstName, lastName, emailAddress, age, daysToComplete, Degree.SOFTWARE) {}

    public override Degree Degree
    {
        get { return degree; }
        set { degree = value; }
    }
}
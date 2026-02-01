namespace StudentRoster;
	
public class NetworkStudent : Student
{
    private new Degree degree = Degree.NETWORK;

    public NetworkStudent() : base() {}
    public NetworkStudent(string studentId, string firstName, string lastName, string emailAddress, int age, int[] daysToComplete) : base(studentId, firstName, lastName, emailAddress, age, daysToComplete, Degree.NETWORK) {}

    public override Degree Degree
    {
        get { return degree; }
        set { degree = value; }
    }
}
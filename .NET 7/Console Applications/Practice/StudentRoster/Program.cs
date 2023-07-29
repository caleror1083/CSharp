// Robert Calero - App displaying a roster of students in a given class
using System;

namespace StudentRoster;

public class Program
{
    internal static void Main()
    {
        Roster.PrintHeaders();
        Roster.ProcessRoster();
        Console.ReadKey();
	}
}
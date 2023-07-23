using System;

namespace _051_DatabaseFirstEFCore.Models;
	
public partial class Employee
{
	public int EmployeeID { get; set; }
	public string EmployeeName { get; set; } = null!;
	public string DepartmentName { get; set; } = null!;
	public DateTime DateofJoining { get; set; }
	public string PhotoFileName { get; set; }
    public int? DepartmentID { get; set; }
    public string? SSN { get; set; }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace _051_DatabaseFirstEFCore.Models;
	
public partial class Employees
{
	[Key] public int EmployeeId { get; set; }
	public string EmployeeName { get; set; } = null!;
	public string DepartmentName { get; set; } = null!;
	public DateTime DateofJoining { get; set; }
	public string PhotoFileName { get; set; }
}
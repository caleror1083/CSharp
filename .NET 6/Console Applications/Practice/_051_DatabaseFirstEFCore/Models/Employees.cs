using System;

namespace _051_DatabaseFirstEFCore.Models
	{
		public partial class Employees
			{
				public int EmployeeId { get; set; }
				public string EmployeeName { get; set; } = null!;
				public string Department { get; set; } = null!;
				public DateTime? DateofJoining { get; set; }
				public string? PhotoFileName { get; set; }
			}
	}
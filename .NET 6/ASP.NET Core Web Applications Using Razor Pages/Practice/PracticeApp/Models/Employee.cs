using System;
using System.ComponentModel.DataAnnotations;

// Namespaces
namespace PracticeApp.Models
{
	// Classes
    public partial class Employee
    {
		// Properties
        [Key] public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string Department { get; set; } = null!;
        public DateTime DateofJoining { get; set; }
        public string PhotoFileName { get; set; }

		public Employee() {}
    }
}
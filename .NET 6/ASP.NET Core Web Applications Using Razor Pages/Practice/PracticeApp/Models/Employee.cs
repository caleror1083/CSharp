using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticeApp.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        [Display(Name = "Department")] public string DepartmentName { get; set; } = null!;
        public DateTime? DateofJoining { get; set; }
        public string? PhotoFileName { get; set; }
        public int? DepartmentId { get; set; }
        public string? Ssn { get; set; }
    }
}

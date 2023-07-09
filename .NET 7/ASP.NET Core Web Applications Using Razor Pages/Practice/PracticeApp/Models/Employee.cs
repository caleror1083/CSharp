using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticeApp.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        [Display(Name = "Name")] public string? EmployeeName { get; set; }
        [Display(Name = "Department")] public string DepartmentName { get; set; } = null!;
        [Display(Name = "Date Joined")] public DateTime? DateofJoining { get; set; }
        public string? PhotoFileName { get; set; }
        public int? DepartmentId { get; set; }
        public string? Ssn { get; set; }
    }
}

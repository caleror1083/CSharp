using System;
using System.ComponentModel.DataAnnotations;

namespace PracticeApp.Models
{
    public partial class Employee
    {
        [Display(Name = "Employee ID")] public int EmployeeId { get; set; }
        [Display(Name = "Department ID")] public int DepartmentId { get; set; }
        [Display(Name = "Name")] public string EmployeeName { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public DateTime DateofJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}
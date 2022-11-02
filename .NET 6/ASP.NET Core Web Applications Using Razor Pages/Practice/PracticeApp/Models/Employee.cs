using System;
using System.ComponentModel.DataAnnotations;

namespace PracticeApp.Models
{
    public partial class Employee
    {
        [Key] public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public DateTime DateofJoining { get; set; }
        public string PhotoFileName { get; set; }
        public int DepartmentId { get; set; }
    }
}
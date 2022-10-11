using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticeApp.Models
{
    public partial class Department
    {
        [Key] public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
    }
}

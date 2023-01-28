using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PracticeApp.Models
{
    public partial class Department
	{
		public int DepartmentId { get; set; }
        [Display(Name = "Department")] public string DepartmentName { get; set; } = null!;
    }
}

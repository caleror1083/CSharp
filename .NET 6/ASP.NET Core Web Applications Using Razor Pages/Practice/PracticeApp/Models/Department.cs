using System.ComponentModel.DataAnnotations;

namespace PracticeApp.Models
{
    public partial class Department
    {
        [Display(Name = "ID")] public int DepartmentId { get; set; }
        [Display(Name = "Name")] public string DepartmentName { get; set; } = null!;
    }
}
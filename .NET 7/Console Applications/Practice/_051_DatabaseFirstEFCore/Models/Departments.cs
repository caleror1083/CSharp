using System.ComponentModel.DataAnnotations;

namespace _051_DatabaseFirstEFCore.Models
{
	public partial class Departments
	{
		[Key] public int DepartmentId { get; set; }
		public string DepartmentName { get; set; } = null!;
	}
}
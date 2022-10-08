using System;
using System.Collections.Generic;

namespace _051_DatabaseFirstEFCore.Models
	{
		public partial class Departments
			{
				public int DepartmentId { get; set; }
				public string DepartmentName { get; set; } = null!;
			}
	}
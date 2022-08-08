using System.ComponentModel.DataAnnotations.Schema;

// Namespaces
namespace Practice.Models
	{
		// Attributes
		[Table("Employee")]

		// Classes
		public class Employee
			{
				// Properties
				// These properties will encapsulate the database columns from the Employee table
				public int ID { get; set; }
				public string Name { get; set; }
				public int Salary { get; set; }
				public string Gender { get; set; }
				public int DepartmentID { get; set; }
			}
	}
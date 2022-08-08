using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Namespaces
namespace Practice.Models
	{
		// Classes
		// Establish a connection to the database
		public class EmployeeContext : DbContext
			{
				// Properties
				public DbSet<Employee> Employees { get; set; }
			}
	}
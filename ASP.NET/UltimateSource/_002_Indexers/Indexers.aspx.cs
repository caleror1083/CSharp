using System;
using System.Web.UI;

namespace _002_Indexers
	{
		public partial class Indexers : Page
			{
				protected void Page_Load(object sender, EventArgs e)
					{
						Company myCompany = new Company();

						Response.Write($"Current employees are");
						Response.Write($"<br />");
						Response.Write($"Name of employee with ID 2: {myCompany[2]}");
						Response.Write($"<br />");
						Response.Write($"Name of employee with ID 5: {myCompany[5]}");
						Response.Write($"<br />");
						Response.Write($"Name of employee with ID 8: {myCompany[8]}");
						Response.Write($"<br />");
						Response.Write($"<br />");

						Response.Write($"Changing names of employees with ID of 2, 5, & 8");
						Response.Write($"<br />");
						myCompany[2] = $"Rob";
						myCompany[5] = $"Lance";
						myCompany[8] = $"Dean";
						Response.Write($"Name of employee with ID 2: {myCompany[2]}");
						Response.Write($"<br />");
						Response.Write($"Name of employee with ID 5: {myCompany[5]}");
						Response.Write($"<br />");
						Response.Write($"Name of employee with ID 8: {myCompany[8]}");	
						Response.Write($"<br />");
						Response.Write($"<br />");

						Response.Write($"Before update current employees are");
						Response.Write($"<br />");
						Response.Write($"Total male employees: {myCompany["Male"]}");
						Response.Write($"<br />");
						Response.Write($"Total female employees: {myCompany["Female"]}");
						Response.Write($"<br />");
						Response.Write($"<br />");

						Response.Write($"After update new employees are");
						Response.Write($"<br />");
						myCompany["Male"] = "Female";						
						Response.Write($"Total male employees: {myCompany["Male"]}");
						Response.Write($"<br />");
						Response.Write($"Total female employees: {myCompany["Female"]}");
					}
			}
	}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ2SQL
	{
		public partial class Company : Page
			{
				protected void Page_Load(object sender, EventArgs e)
					{
						CompanyDataContext dbContext = new CompanyDataContext();
						GridView1.DataSource = dbContext.Employees;
						GridView1.DataBind();
			
					}
			}
	}
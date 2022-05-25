using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_Collections_Dictionary
{
	public partial class WebForm : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// Object instances from Country class
			Country country1 = new Country() { Code = "AUS", Name = "Australia", Capital = "Canberra" };
			Country country2 = new Country() { Code = "IND", Name = "India", Capital = "New Delhi" };
			Country country3 = new Country() { Code = "USA", Name = "United States", Capital = "Washington D.C." };
			Country country4 = new Country() { Code = "GBR", Name = "United Kingdom", Capital = "London" };
			Country country5 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };

			// Variable initializations
			Dictionary<string, Country> countries = new Dictionary<string, Country>
				{
					{country1.Code, country1},
					{country2.Code, country2},
					{country3.Code, country3},
					{country4.Code, country4},
					{country5.Code, country5}
				};
		}

		protected void TxtCountryCode_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
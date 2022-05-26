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
			if (Session["CountriesData"] == null)
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
					Session["CountriesData"] = countries; // To prevent the dictionary to be built every time the page is loaded
				}
		}

		protected void TxtCountryCode_TextChanged(object sender, EventArgs e)
			{
				Dictionary<string, Country> countries = (Dictionary<string, Country>)Session["CountriesData"];

				Country countryCodeResult = countries.ContainsKey(TxtCountryCode.Text.ToUpper()) ? countries[TxtCountryCode.Text.ToUpper()] : null;

				// The country code that the user entered did not match what is in the dictionary and alerts the user
				if (countryCodeResult == null)
					{
						LblMessage.Text = "Country code not valid";
					}
				else  // The country code was found and prints country name and capital
					{
						TxtName.Text = countryCodeResult.Name;
						TxtCapital.Text = countryCodeResult.Capital;
						LblMessage.Text = "";
					}
			}
	}
}
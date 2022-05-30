//  C969 Software II - Advanced C# - Robert Calero - Student ID# 000998416

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SoftwareCompanySchedulingApp
	{
		public partial class UpdateCustomer : Form
			{
				public static Dictionary<string, string> _CustForm = new Dictionary<string, string>();

				public UpdateCustomer()
					{
						InitializeComponent();
					}

				private void UpdateCustomer_Load(object sender, EventArgs e)
					{
						CountryDD.Items.Add("United States");
						CountryDD.Items.Add("England");
						CountryDD.Items.Add("Nicaragua");
					}

                private void SearchBtn_Click(object sender, EventArgs e)
                    {
						int custId = LoginControl.FindCust(SearchTxt.Text);

						if (custId != 0)
							{
								_CustForm = LoginControl.CustDetails(custId);
								NameTxt.Text = _CustForm["customerName"];
								PhoneTxt.Text = _CustForm["phone"];
								AddressTxt.Text = _CustForm["address"];
								CityTxt.Text = _CustForm["city"];
								PostalCodeTxt.Text = _CustForm["postalCode"];
								CountryDD.Text = _CustForm["country"];

								if (_CustForm["active"] == "True")
									{
										YesRadio.Checked = true;
									}
								else
									{
										YesRadio.Checked = false;
									}
							}
						else
							{
								MessageBox.Show("Full customer name not found, try again.");
							}
                    }

				private void UpdateBtn_Click(object sender, EventArgs e)
					{
						if (string.IsNullOrEmpty(NameTxt.Text) ||
							string.IsNullOrEmpty(PhoneTxt.Text) ||
							string.IsNullOrEmpty(AddressTxt.Text) ||
							string.IsNullOrEmpty(CityTxt.Text) ||
							string.IsNullOrEmpty(PostalCodeTxt.Text) ||
							string.IsNullOrEmpty(CountryDD.Text) ||
							(YesRadio.Checked == false &&
							 NoRadio.Checked == false))
							{
								MessageBox.Show("You must search for a customer before updating a record");
							}
						else
							{
								Dictionary<string, string> update = new Dictionary<string, string>();
								update.Add("customerName", NameTxt.Text);
								update.Add("phone", PhoneTxt.Text);
								update.Add("address", AddressTxt.Text);
								update.Add("city", CityTxt.Text);
								update.Add("postalCode", PostalCodeTxt.Text);
								update.Add("country", CountryDD.Text);
								update.Add("active", YesRadio.Checked ? "1" : "0");

								if (UpdateCustomerInfo(update))
									{
										MessageBox.Show("Customer information has been updated");
										this.Close();
									}
								else
									{
										MessageBox.Show("Error, try again");
									}
							}
					}

				public bool UpdateCustomerInfo(Dictionary<string, string> updateCust)
					{
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						// Edit Customer Table
						string edit = $"UPDATE customer SET customerName = '{updateCust["customerName"]}', active = '{updateCust["active"]}', lastUpdate = '{LoginControl.CreateStamp()}', lastUpdateBy = '{LoginControl.GetUserName()}' WHERE customerName = '{_CustForm["customerName"]}'";
						SqlCommand myCommand = new SqlCommand(edit, myConnection);
						int editCust = myCommand.ExecuteNonQuery();

						// Edit Address Table
						edit = $"UPDATE address SET address = '{updateCust["address"]}', postalCode = '{updateCust["postalCode"]}', phone = '{updateCust["phone"]}', lastUpdate = '{LoginControl.CreateStamp()}', lastUpdateBy = '{LoginControl.GetUserName()}' WHERE address = '{_CustForm["address"]}'";
						myCommand = new SqlCommand(edit, myConnection);
						int editAddress = myCommand.ExecuteNonQuery();

						// Edit City Table
						edit = $"UPDATE city SET city = '{updateCust["city"]}', lastUpdate = '{LoginControl.CreateStamp()}', lastUpdateBy = '{LoginControl.GetUserName()}' WHERE city = '{_CustForm["city"]}'";
						myCommand = new SqlCommand(edit, myConnection);
						int editCity = myCommand.ExecuteNonQuery();

						// Edit Country Table
						edit = $"UPDATE country SET country = '{updateCust["country"]}', lastUpdate = '{LoginControl.CreateStamp()}', lastUpdateBy = '{LoginControl.GetUserName()}' WHERE country = '{_CustForm["country"]}'";
						myCommand = new SqlCommand(edit, myConnection);
						int editCountry = myCommand.ExecuteNonQuery();
						myConnection.Close();

						if (editCust != 0 && editAddress != 0 && editCity != 0 && editCountry != 0)
							{
								return true;
							}
						else
							{
								return false;
							}
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Close();
					}
			}
	}
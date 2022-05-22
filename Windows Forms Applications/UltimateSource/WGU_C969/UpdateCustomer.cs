/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WGU_C969
	{
		public partial class UpdateCustomer : Form
			{
				public static Dictionary<string, string> custForm = new Dictionary<string, string>();

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
								custForm = LoginControl.CustDetails(custId);
								NameTxt.Text = custForm["customerName"];
								PhoneTxt.Text = custForm["phone"];
								AddressTxt.Text = custForm["address"];
								CityTxt.Text = custForm["city"];
								PostalCodeTxt.Text = custForm["postalCode"];
								CountryDD.Text = custForm["country"];

								if (custForm["active"] == "True")
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

								if (updateCustomer(update))
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

				public bool updateCustomer(Dictionary<string, string> updateCust)
					{
						MySqlConnection myConnection = new MySqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						// Edit Customer Table
						string edit = $"UPDATE customer SET customerName = '{updateCust["customerName"]}', active = '{updateCust["active"]}', lastUpdate = '{LoginControl.CreateStamp()}', lastUpdateBy = '{LoginControl.GetUserName()}' WHERE customerName = '{custForm["customerName"]}'";
						MySqlCommand myCommand = new MySqlCommand(edit, myConnection);
						int editCust = myCommand.ExecuteNonQuery();

						// Edit Address Table
						edit = $"UPDATE address SET address = '{updateCust["address"]}', postalCode = '{updateCust["postalCode"]}', phone = '{updateCust["phone"]}', lastUpdate = '{LoginControl.CreateStamp()}', lastUpdateBy = '{LoginControl.GetUserName()}' WHERE address = '{custForm["address"]}'";
						myCommand = new MySqlCommand(edit, myConnection);
						int editAddress = myCommand.ExecuteNonQuery();

						// Edit City Table
						edit = $"UPDATE city SET city = '{updateCust["city"]}', lastUpdate = '{LoginControl.CreateStamp()}', lastUpdateBy = '{LoginControl.GetUserName()}' WHERE city = '{custForm["city"]}'";
						myCommand = new MySqlCommand(edit, myConnection);
						int editCity = myCommand.ExecuteNonQuery();

						// Edit Country Table
						edit = $"UPDATE country SET country = '{updateCust["country"]}', lastUpdate = '{LoginControl.CreateStamp()}', lastUpdateBy = '{LoginControl.GetUserName()}' WHERE country = '{custForm["country"]}'";
						myCommand = new MySqlCommand(edit, myConnection);
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
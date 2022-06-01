/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SoftwareCompanySchedulingApp
	{
		public partial class DeleteCustomer : Form
			{
				public static Dictionary<string, string> custForm = new Dictionary<string, string>();

				public DeleteCustomer()
					{
						InitializeComponent();
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
								CountryTxt.Text = custForm["country"];
								
								if (custForm["active"] == "True")
									{
										ActiveTxt.Text = "true";
									}
								else
									{
										ActiveTxt.Text = "False";
									}
							}
						else
							{
								MessageBox.Show("Full customer name not found, try again.");
							}
					}

				private void DeleteBtn_Click(object sender, EventArgs e)
					{
						if (string.IsNullOrEmpty(NameTxt.Text) ||
							string.IsNullOrEmpty(PhoneTxt.Text) ||
							string.IsNullOrEmpty(AddressTxt.Text) ||
							string.IsNullOrEmpty(CityTxt.Text) ||
							string.IsNullOrEmpty(PostalCodeTxt.Text) ||
							string.IsNullOrEmpty(CountryTxt.Text) ||
							string.IsNullOrEmpty(ActiveTxt.Text))
							{
								MessageBox.Show("You must search for a customer before deleting a record");
							}
						else
							{
								Dictionary<string, string> update = new Dictionary<string, string>();
								update.Add("customerName", NameTxt.Text);
								update.Add("phone", PhoneTxt.Text);
								update.Add("address", AddressTxt.Text);
								update.Add("city", CityTxt.Text);
								update.Add("postalCode", PostalCodeTxt.Text);
								update.Add("country", CountryTxt.Text);
								update.Add("active", ActiveTxt.Text);

								if (Delete(update))
									{
										MessageBox.Show("Customer information has been deleted");
										this.Close();
									}
								else
									{
										MessageBox.Show("Error, try again");
									}
							}
					}
				
				public bool Delete(Dictionary<string, string> deleteCust)
					{
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						// Edit Customer Table
						string edit = $"DELETE FROM [customer] WHERE [customerName] = @CustomerName";
						SqlCommand myCommand = new SqlCommand(edit, myConnection);
						myCommand.Parameters.AddWithValue("@CustomerName", $"{custForm["customerName"]}");
						int editCust = myCommand.ExecuteNonQuery();

						// Edit Address Table
						edit = $"DELETE FROM [address] WHERE [address] = @Address";
						myCommand = new SqlCommand(edit, myConnection);
						myCommand.Parameters.AddWithValue("@Address", $"{custForm["address"]}");
						int editAddress = myCommand.ExecuteNonQuery();

						// Edit City Table
						edit = $"DELETE FROM [city] WHERE [city] = @City";
						myCommand = new SqlCommand(edit, myConnection);
						myCommand.Parameters.AddWithValue("@City", $"{custForm["city"]}");
						int editCity = myCommand.ExecuteNonQuery();

						// Edit Country Table
						edit = $"DELETE FROM [country] WHERE [country] = @Country";
						myCommand = new SqlCommand(edit, myConnection);
						myCommand.Parameters.AddWithValue("@Country", $"{custForm["country"]}");
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
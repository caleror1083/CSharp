/*
	C868 Software Development Capstone
	Robert Calero
	Student ID# 000998416
*/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp
	{
		public partial class UpdateCustomer : Form
			{
				public static List<KeyValuePair<string, object>> myCustomerList;

				public UpdateCustomer()
					{
						InitializeComponent();
						ShowCustomerList();
						ComboBoxSettings();
					}

				public void SetCustomerList(List<KeyValuePair<string, object>> myList)
					{
						myCustomerList = myList;
					}

				public static List<KeyValuePair<string, object>> GetCustomerList()
					{
						return myCustomerList;
					}

				// Sets the form as locke and provides initial values for the combobox
				public void ComboBoxSettings()
					{
						SelectCombo.SelectedItem = null;
						SelectCombo.Text = "--Select--";
						NameTxt.Text = null;
						AddressTxt.Text = null;
						CityTxt.Text = null;
						ZipCodeTxt.Text = null;
						CountryTxt.Text = null;
						PhoneTxt.Text = null;
						YesRadio.Checked = false;
						NoRadio.Checked = false;
						NameTxt.Enabled = false;
						AddressTxt.Enabled = false;
						CityTxt.Enabled = false;
						ZipCodeTxt.Enabled = false;
						CountryTxt.Enabled = false;
						PhoneTxt.Enabled = false;
						YesRadio.Enabled = false;
						NoRadio.Enabled = false;
						UpdateBtn.Enabled = false;
					}

				public void ShowCustomerList()
					{
						MySqlConnection myConnection = new MySqlConnection(Database.GetConnectionString());

						try
							{
								string myQuery = "SELECT customerId, concat(customerName, ' --ID: ', customerId) as Display FROM customer;";
								MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(myQuery, myConnection);
								myConnection.Open();

								DataSet myDataSet = new DataSet();
								mySqlDataAdapter.Fill(myDataSet, "Cust");
								SelectCombo.DisplayMember = "Display";
								SelectCombo.ValueMember = "customerId";
								SelectCombo.DataSource = myDataSet.Tables["Cust"];
							}
						catch (Exception myException)
							{
								MessageBox.Show("Error! " + myException);
							}
					}

				public void DisplayFields(List<KeyValuePair<string, object>> myCustomerList)
					{
						// Lambda expressions to get values from the CustomerList
						NameTxt.Text = myCustomerList.First(myKeyValuePair => myKeyValuePair.Key == "customerName").Value.ToString();
						AddressTxt.Text = myCustomerList.First(myKeyValuePair => myKeyValuePair.Key == "address").Value.ToString();
						CityTxt.Text = myCustomerList.First(myKeyValuePair => myKeyValuePair.Key == "city").Value.ToString();
						ZipCodeTxt.Text = myCustomerList.First(myKeyValuePair => myKeyValuePair.Key == "postalCode").Value.ToString();
						CountryTxt.Text = myCustomerList.First(myKeyValuePair => myKeyValuePair.Key == "country").Value.ToString();
						PhoneTxt.Text = myCustomerList.First(myKeyValuePair => myKeyValuePair.Key == "phone").Value.ToString();

						if (Convert.ToInt32(myCustomerList.First(myKeyValuePair => myKeyValuePair.Key == "active").Value) == 1)
							{
								YesRadio.Checked = true;
							}
						else
							{
								NoRadio.Checked = true;
							}
					}

				// Shows currently selected customer information in textboxes
				private void SelectCombo_SelectedValueChanged(object sender, EventArgs e)
					{
						DataRowView myDataRowView = SelectCombo.SelectedItem as DataRowView;
						int myID = Convert.ToInt32(SelectCombo.SelectedValue);
						var myCustomerList = Database.FindCustomer(myID);
						SetCustomerList(myCustomerList);

						if (myCustomerList != null)
							{
								DisplayFields(myCustomerList);
								NameTxt.Enabled = true;
								AddressTxt.Enabled = true;
								CityTxt.Enabled = true;
								ZipCodeTxt.Enabled = true;
								CountryTxt.Enabled = true;
								PhoneTxt.Enabled = true;
								YesRadio.Enabled = true;
								NoRadio.Enabled = true;
								UpdateBtn.Enabled = true;
							}
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Owner.Show();
						this.Close();
					}

				private void UpdateBtn_Click(object sender, EventArgs e)
					{
						bool passed = CheckEmpty();

						if (passed == true)
							{
								DialogResult myConfirmation = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
								
								if (myConfirmation == DialogResult.Yes)
									{
										try
											{
												var myCustomerList = GetCustomerList();

												// Lambda expression converting CustomerList to dictionary
												IDictionary<string, object> myDictionary = myCustomerList.ToDictionary(myPair => myPair.Key, myPair => myPair.Value);
												myDictionary["customerName"] = NameTxt.Text;
												myDictionary["address"] = AddressTxt.Text;
												myDictionary["city"] = CityTxt.Text;
												myDictionary["postalCode"] = ZipCodeTxt.Text;
												myDictionary["country"] = CountryTxt.Text;
												myDictionary["phone"] = PhoneTxt.Text;
												myDictionary["active"] = YesRadio.Checked ? 1 : 0;
												Database.UpdateCustomer(myDictionary);
											}
										catch (Exception myException)
											{
												Console.WriteLine(myException);
											}
										finally
											{
												MessageBox.Show("Customer updated successfully!");
												this.Owner.Show();
												this.Close();
											}
									}
							}
						else
							{
								MessageBox.Show("You must fill out all information");
							}
					}

				// Prevents user from entering invalid characters
				private void NameTxt_KeyPress(object sender, KeyPressEventArgs e)
					{
						if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
							{
								e.Handled = true;
							}
					}

				private void PhoneTxt_KeyPress(object sender, KeyPressEventArgs e)
					{
						if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
							{
								e.Handled = true;
							}
					}

				private void AddressTxt_KeyPress(object sender, KeyPressEventArgs e)
					{
						if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
							{
								e.Handled = true;
							}
					}

				private void CityTxt_KeyPress(object sender, KeyPressEventArgs e)
					{
						if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
							{
								e.Handled = true;
							}
					}

				private void ZipCodeTxt_KeyPress(object sender, KeyPressEventArgs e)
					{
						if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
							{
								e.Handled = true;
							}
					}

				private void CountryTxt_KeyPress(object sender, KeyPressEventArgs e)
					{
						if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
							{
								e.Handled = true;
							}
					}

				private bool CheckEmpty()
					{
						foreach (Control myControl in this.Controls)
							{
								if (myControl is TextBox)
									{
										TextBox myTextBox = myControl as TextBox;
										if (myTextBox.Text == string.Empty)
											{
												return false;
											}
									}
							}
						return true;
					}
			}
	}
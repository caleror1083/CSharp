/*
	C868 Software Development Capstone
	Robert Calero
	Student ID# 000998416
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp
	{
		public partial class DeleteCustomer : Form
			{
				public static List<KeyValuePair<string, object>> myCustomerList;

				public DeleteCustomer()
					{
						InitializeComponent();
						ShowCustomerList();
						ComboBoxSettings();
					}

				// Fills combobox with customer information deom database
				public void ShowCustomerList()
					{
						SqlConnection myConnection = new SqlConnection(Database.GetConnectionString());

						try
							{
								string myQuery = "SELECT customerId, concat(customerName, ' --ID: ', customerId) as Display FROM customer;";
								SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(myQuery, myConnection);
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

				public void SetCustomerList(List<KeyValuePair<string, object>> myList)
					{
						myCustomerList = myList;
					}

				public static List<KeyValuePair<string, object>> GetCustomerList()
					{
						return myCustomerList;
					}

				// Once customer has been selected, text boxes are filled with customer information
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

				private void SelectCombo_SelectedValueChanged(object sender, EventArgs e)
					{
						DataRowView myDataRowView = SelectCombo.SelectedItem as DataRowView;
						int myID = Convert.ToInt32(SelectCombo.SelectedValue);
						var myCustomerList = Database.FindCustomer(myID);
						SetCustomerList(myCustomerList);

						if (myCustomerList != null)
							{
								DisplayFields(myCustomerList);
							}
					}

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
					}

				// Prevents users from entering incorrect characters
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

				private void DeleteBtn_Click(object sender, EventArgs e)
					{
						DialogResult myConfirmation = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);

						if (myConfirmation == DialogResult.Yes)
							{
								try
									{
										var myList = GetCustomerList();

										// Lambda expression converting CustomerList to dictionary
										IDictionary<string, object> myDictionary = myList.ToDictionary(myPair => myPair.Key, myPair => myPair.Value);
										bool myAppointments = Database.CheckAppointments(myDictionary["customerId"].ToString());
										
										if (myAppointments == false)
											{
												Database.DeleteCustomer(myDictionary);
											}
										else
											{
												DialogResult myConfirmation2 = MessageBox.Show("Deleting customer will remove all appointments, continue?", "", MessageBoxButtons.YesNo);

												if (myConfirmation2 == DialogResult.Yes)
													{
														Database.DeleteCustomerAppointments(myDictionary["customerId"].ToString());
														Database.DeleteCustomer(myDictionary);
													}
												else
													{
														return;
													}
											}
										MessageBox.Show("Customer deleted successfully!");
										this.Owner.Show();
										this.Close();
									}
								catch (Exception myException)
									{
										Console.WriteLine(myException);
									}
							}
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Owner.Show();
						this.Close();
					}
			}
}

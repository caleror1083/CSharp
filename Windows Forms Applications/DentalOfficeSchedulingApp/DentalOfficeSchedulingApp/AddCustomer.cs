/*
	C868 Software Development Capstone
	Robert Calero
	Student ID# 000998416
*/

using System;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp
	{
		public partial class AddCustomer : Form
			{
				public AddCustomer()
					{
						InitializeComponent();
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

				// Prevents user from entering invalid characters
				private void NameTxt_KeyPress(object sender, KeyPressEventArgs e)
					{
						if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
							{
								e.Handled = true;
							}
					}

				private void AddressTxt_KeyPress(object sender, KeyPressEventArgs e)
					{
						if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
							{
								e.Handled = true;
							}
					}

				private void CityTxt_KeyPress(object sender, KeyPressEventArgs e)
					{
						if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
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

				private void PhoneTxt_KeyPress(object sender, KeyPressEventArgs e)
					{
						if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
							{
								e.Handled = true;
							}
					}

				private void AddBtn_Click(object sender, EventArgs e)
					{
						bool passed = CheckEmpty();

						if (passed == true)
							{
								int myCountry = Database.CreateCountry(CountryTxt.Text);
								int myCity = Database.CreateCity(myCountry, CityTxt.Text);
								int myAddress = Database.CreateAddress(myCity, AddressTxt.Text, ZipCodeTxt.Text, PhoneTxt.Text);
								Database.CreateCustomer(Database.GetID("customer", "customerId") + 1, NameTxt.Text, myAddress, YesRadio.Checked ? 1 : 0, Database.GetTime(), Database.GetUserName());
								MessageBox.Show("Customer created successfully!");
								this.Owner.Show();
								this.Close();
							}
						else
							{
								MessageBox.Show("You must fill out all information");
							}
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Owner.Show();
						this.Close();

					}
			}
	}
/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using System;
using System.Windows.Forms;

namespace SoftwareCompanySchedulingApp
	{
		public partial class AddCustomer : Form
			{
				public AddCustomer()
					{
						InitializeComponent();
					}

				private void AddCustomer_Load(object sender, EventArgs e)
					{
						CountryDD.Items.Add("England");
						CountryDD.Items.Add("Nicaragua");
						CountryDD.Items.Add("United States");
						YesRadio.Checked = true;
					}

				private void AddBtn_Click(object sender, EventArgs e)
					{
						string stamp = LoginControl.CreateStamp();
						string userName = LoginControl.UserName;

						if (string.IsNullOrEmpty(NameTxt.Text) ||
							string.IsNullOrEmpty(PhoneTxt.Text) ||
							string.IsNullOrEmpty(AddressTxt.Text) ||
							string.IsNullOrEmpty(CityTxt.Text) ||
							string.IsNullOrEmpty(PostalCodeTxt.Text) ||
							string.IsNullOrEmpty(CountryDD.Text) ||
							(YesRadio.Checked == false &&
							 NoRadio.Checked == false))
							{
								MessageBox.Show("You must fill out all information before you can add an appointment");
							}
						else
							{
								int country = LoginControl.CreateRec(stamp, userName, "country", CountryDD.Text);
								int city = LoginControl.CreateRec(stamp, userName, "city", CityTxt.Text, country);
								int address = LoginControl.CreateRec(stamp, userName, "address", $"{AddressTxt.Text}, {city}, {PostalCodeTxt.Text}, {PhoneTxt.Text}");
								LoginControl.CreateRec(stamp, userName, "customer", $"{NameTxt.Text}, {address}, {(YesRadio.Checked ? 1 : 0)}");
								MessageBox.Show("Customer added successfully");
								this.Close();
							}
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Close();
					}
			}
	}
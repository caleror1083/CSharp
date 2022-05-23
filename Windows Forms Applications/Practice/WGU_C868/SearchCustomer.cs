/*
	C868 Software Development Capstone
	Robert Calero
	Student ID# 000998416
*/

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WGU_C868
	{
		public partial class SearchCustomer : Form
			{
				public SearchCustomer()
					{
						InitializeComponent();
						ShowCustomerList();
						CustomerCombo.SelectedItem = null;
						SearchResults.Visible = false;
						CustomerCombo.Text = "--Select--";
						DateTimeLbl.Text = DateTime.Now.ToString();
					}

				public void ShowCustomerList()
					{
						MySqlConnection myConnection = new MySqlConnection(Database.GetConnectionString());

						try
							{
								string myQuery = "SELECT customerId, concat(customerName, ' --ID: ', customerId) as Display FROM customer;";
								MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(myQuery, myConnection);
								myConnection.Open();

								DataSet myDataSet = new DataSet();
								myDataAdapter.Fill(myDataSet, "Cust");
								CustomerCombo.DisplayMember = "Display";
								CustomerCombo.ValueMember = "customerId";
								CustomerCombo.DataSource = myDataSet.Tables["Cust"];
							}
						catch (Exception myException)
							{
								MessageBox.Show("Error! " + myException);
							}
					}

				private void CustomerCombo_SelectedValueChanged(object sender, EventArgs e)
					{
						if (CustomerCombo.SelectedIndex != -1)
							{
								int myID = Convert.ToInt32(CustomerCombo.SelectedValue);
								DataTable myDataTableRecord = Database.GetAppointmentListByCustomer(myID.ToString());
								SearchResults.DataSource = myDataTableRecord;
								SearchResults.Visible = true;
							}
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Owner.Show();
						this.Close();
					}
			}
	}
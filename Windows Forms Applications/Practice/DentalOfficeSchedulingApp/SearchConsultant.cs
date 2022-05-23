/*
	C868 Software Development Capstone
	Robert Calero
	Student ID# 000998416
*/

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp
	{
		public partial class SearchConsultant : Form
			{
				public SearchConsultant()
					{
						InitializeComponent();
						ShowUserList();
						UserCombo.SelectedItem = null;
						SearchResults.Visible = false;
						UserCombo.Text = "--Select--";
						DateTimeLbl.Text = DateTime.Now.ToString();
					}

				public void ShowUserList()
					{
						MySqlConnection myConnection = new MySqlConnection(Database.GetConnectionString());

						try
							{
								string myQuery = "SELECT userId, concat(userName, ' --ID: ', userId) as Display FROM user;";
								MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(myQuery, myConnection);
								myConnection.Open();

								DataSet myDataSet = new DataSet();
								myDataAdapter.Fill(myDataSet, "User");
								UserCombo.DisplayMember = "Display";
								UserCombo.ValueMember = "userId";
								UserCombo.DataSource = myDataSet.Tables["User"];
							}
						catch (Exception myException)
							{
								MessageBox.Show("Error! " + myException);
							}
					}

				private void UserCombo_SelectedValueChanged(object sender, EventArgs e)
					{
						if (UserCombo.SelectedIndex != -1)
							{
								int myID = Convert.ToInt32(UserCombo.SelectedValue);
								DataTable myDataTableRecord = Database.GetAppointmentListByUser(myID.ToString());
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
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

// Namespaces
namespace DentalOfficeSchedulingApp
	{
		// Partial classes
		public partial class DeleteUser : Form
			{
				// Fields
				public static List<KeyValuePair<string, object>> myUserList;				

				// Constructors
				public DeleteUser()
					{
						InitializeComponent();
						ShowUserList();
						ComboBoxSettings();
					}

				// Methods(Parameters)
				public static List<KeyValuePair<string,object>> GetUserList() => myUserList;
				public void SetUserList(List<KeyValuePair<string, object>> myList) => myUserList = myList;

				public void ShowUserList()
					{
						SqlConnection myConnection = new SqlConnection(Database.GetConnectionString());

						try
							{
								string myQuery = "SELECT userId, concat(userName, ' --ID: ', userId) as Display FROM user;";
								SqlDataAdapter myDataAdapter = new SqlDataAdapter(myQuery, myConnection);
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

				public void ComboBoxSettings()
					{
						UserCombo.SelectedItem = null;
						UserCombo.Text = "--Select--";
						DeleteBtn.Enabled = false;
					}

				private void UserCombo_SelectedValueChanged(object sender, EventArgs e)
					{
						if (UserCombo.ValueMember == Database.GetUserID().ToString())
							{
								MessageBox.Show("The current logged in user cannot be deleted. Logout, switch user and try again");
								return;
							}
						else
							{
								DataRowView myDataRow = UserCombo.SelectedItem as DataRowView;
								int myID = Convert.ToInt32(UserCombo.SelectedValue);
								List<KeyValuePair<string, object>> myUserList = Database.GetUserList(myID);
								SetUserList(myUserList);

								if (UserCombo.SelectedIndex != -1)
									{
										DeleteBtn.Enabled = true;
									}
							}
					}

				private void DeleteBtn_Click(object sender, EventArgs e)
					{
						bool myParseOK = int.TryParse(UserCombo.SelectedValue.ToString(), out int myUserID);

						if (myUserID == Database.GetUserID())
							{
								MessageBox.Show("The current logged in user cannot be deleted. Logout, switch user and try again");
								return;								
							}
						else
							{
								DialogResult myConfirmation = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
								if (myConfirmation == DialogResult.Yes)
									{
										try
											{
												List<KeyValuePair<string, object>> myList = GetUserList();

												// Lambda expression converting UserList to dictionary
												IDictionary<string, object> myDictionary = myList.ToDictionary(myKeyValuePair => myKeyValuePair.Key, myKeyValuePair => myKeyValuePair.Value);
												Database.DeleteUser(myDictionary["userId"].ToString());

												MessageBox.Show("User deleted successfully!");
												Owner.Show();
												Close();
											}
										catch (Exception myException)
											{
												Console.WriteLine(myException);
											}
									}
							}
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						Owner.Show();
						Close();
					}
			}
	}
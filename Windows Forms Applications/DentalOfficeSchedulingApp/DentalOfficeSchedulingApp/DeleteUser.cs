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
		public partial class DeleteUser : Form
			{
				public static List<KeyValuePair<string, object>> myUserList;				

				public void SetUserList(List<KeyValuePair<string, object>> myList)
					{
						myUserList = myList;
					}

				public static List<KeyValuePair<string,object>> GetUserList()
					{
						return myUserList;
					}

				public DeleteUser()
					{
						InitializeComponent();
						ShowUserList();
						ComboBoxSettings();
					}

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
								var myUserList = Database.GetUserList(myID);
								SetUserList(myUserList);

								if (UserCombo.SelectedIndex != -1)
									{
										DeleteBtn.Enabled = true;
									}
							}
					}

				private void DeleteBtn_Click(object sender, EventArgs e)
					{
						int myUserID;
						bool myParseOK = Int32.TryParse(UserCombo.SelectedValue.ToString(), out myUserID);

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
												var myList = GetUserList();

												// Lambda expression converting UserList to dictionary
												IDictionary<string, object> myDictionary = myList.ToDictionary(myKeyValuePair => myKeyValuePair.Key, myKeyValuePair => myKeyValuePair.Value);
												Database.DeleteUser(myDictionary["userId"].ToString());

												MessageBox.Show("User deleted successfully!");
												this.Owner.Show();
												this.Close();
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
						this.Owner.Show();
						this.Close();
					}
			}
	}
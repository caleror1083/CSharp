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
		public partial class UpdateUser : Form
			{
				public static List<KeyValuePair<string, object>> myUserList;

				public UpdateUser()
					{
						InitializeComponent();
						ShowUserList();
						ComboBoxSettings();
					}

				public void SetUserList(List<KeyValuePair<string, object>> myList)
					{
						myUserList = myList;
					}

				public static List<KeyValuePair<string,object>> GetUserList()
					{
						return myUserList;
					}

				public void ComboBoxSettings()
					{
						UserCombo.SelectedItem = null;
						UserCombo.Text = "--Select--";
						UserNameTxt.Text = null;
						PasswordTxt.Text = null;
						ConfirmTxt.Text = null;
						YesRadio.Checked = false;
						NoRadio.Checked = false;
						UserNameTxt.Enabled = false;
						PasswordTxt.Enabled = false;
						ConfirmTxt.Enabled = false;
						YesRadio.Enabled = false;
						NoRadio.Enabled = false;
						UpdateBtn.Enabled = false;
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

				private void UserCombo_SelectedValueChanged(object sender, EventArgs e)
					{
						DataRowView myDataRow = UserCombo.SelectedItem as DataRowView;
						int myID = Convert.ToInt32(UserCombo.SelectedValue);
						var myUserList = Database.FindUser(myID);
						SetUserList(myUserList);

						if (myUserList != null)
							{
								UserNameTxt.Enabled = true;
								PasswordTxt.Enabled = true;
								ConfirmTxt.Enabled = true;
								YesRadio.Enabled = true;
								NoRadio.Enabled = true;
								UpdateBtn.Enabled = true;
							}
					}

				private void UpdateBtn_Click(object sender, EventArgs e)
					{
						bool passed = CheckEmpty();

						if (passed == true)
							{
								DialogResult myConfirmation = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
								if (myConfirmation == DialogResult.Yes)
									{
										if (PasswordTxt.Text == ConfirmTxt.Text)
											{
												try
													{
														var myList = GetUserList();

														// Lambda expression converting UserList to dictionary
														IDictionary<string, object> myDictionary = myList.ToDictionary(myKeyValuePair => myKeyValuePair.Key, myKeyValuePair => myKeyValuePair.Value);
														myDictionary["userName"] = UserNameTxt.Text;
														myDictionary["password"] = PasswordTxt.Text;
														myDictionary["active"] = YesRadio.Checked ? 1 : 0;
														Database.UpdateUser(myDictionary);
													}
												catch (Exception myException)
													{
														Console.WriteLine(myException);
													}
												finally
													{
														MessageBox.Show("User updated successfully!");
														this.Owner.Show();
														this.Close();
													}
											}
										else
											{
												MessageBox.Show("Please ensure passwords match.");
											}
									}
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
				private void UserNameTxt_KeyPress(object sender, KeyPressEventArgs e)
					{
						if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
							{
								e.Handled = true;
							}
					}
			}
	}
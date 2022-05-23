/*
	C868 Software Development Capstone
	Robert Calero
	Student ID# 000998416
*/

using System;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp
	{
		public partial class AddUser : Form
			{
				public AddUser()
					{
						InitializeComponent();
					}

				private void AddBtn_Click(object sender, EventArgs e)
					{	
						bool passed = CheckEmpty();
						if (passed == true)
							{
								if (PasswordTxt.Text == ConfirmTxt.Text)
									{
										Database.CreateUser(Database.GetID("user", "userId") + 1, UserNameTxt.Text, PasswordTxt.Text, YesRadio.Checked ? 1 : 0, Database.GetTime(), Database.GetUserName());
										MessageBox.Show("User created successfully!");
										this.Owner.Show();
										this.Close();
									}
								else
									{
										MessageBox.Show("Make sure passwords match");
									}
							}
						else
							{
								MessageBox.Show("You must fill out all information");
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

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Owner.Show();
						this.Close();
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
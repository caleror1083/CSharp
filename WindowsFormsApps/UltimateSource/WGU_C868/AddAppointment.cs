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
		public partial class AddAppointment : Form
			{
				public Scheduling schedulingObject;

				public AddAppointment()
					{
						InitializeComponent();
						ShowCustomerList();
						ComboBoxSettings();
						EndDateTimePicker.Value = EndDateTimePicker.Value.AddHours(1);
					}

				public void ComboBoxSettings()
					{
						SelectCombo.SelectedItem = null;
						SelectCombo.Text = "--Select--";
						AppointmentTxt.Enabled = false;
						DescriptionTxt.Enabled = false;
						LocationTxt.Enabled = false;
						ContactTxt.Enabled = false;
						TypeCombo.Enabled = false;
						AddBtn.Enabled = false;
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
								SelectCombo.DisplayMember = "Display";
								SelectCombo.ValueMember = "customerId";
								SelectCombo.DataSource = myDataSet.Tables["Cust"];
							}
						catch (Exception myException)
							{
								MessageBox.Show("Error! " + myException);
							}
					}

				public int AllowedAppointments(DateTime myStart, DateTime myEnd)
					{
						DateTime mySystemStart = myStart.ToLocalTime();
						DateTime mySystemEnd = myEnd.ToLocalTime();
						DateTime myBusinessStart = DateTime.Today.AddHours(8);
						DateTime myBusinessEnd = DateTime.Today.AddHours(17);

						if (mySystemStart.TimeOfDay < myBusinessStart.TimeOfDay || mySystemEnd.TimeOfDay > myBusinessEnd.TimeOfDay)
							{
								return 1;
							}
						if (Database.AppointmentOverlaps(myStart, myEnd) == true)
							{
								return 2;
							}
						if (mySystemStart.TimeOfDay > mySystemEnd.TimeOfDay)
							{
								return 3;
							}
						if (mySystemStart.Date != mySystemEnd.Date)
							{
								return 4;
							}
						return 0;
					}

				private void AddBtn_Click(object sender, EventArgs e)
					{
						// Take currently selected customer and create an appointment for them
						bool passed = CheckEmpty();
						if (passed == true)
							{
								if (SelectCombo.SelectedItem != null)
									{
										DataRowView myDataRowView = SelectCombo.SelectedItem as DataRowView;
										int myCustomerID = Convert.ToInt32(SelectCombo.SelectedValue);
										DateTime myStart = StartDateTimePicker.Value.ToUniversalTime();
										DateTime myEnd = EndDateTimePicker.Value.ToUniversalTime();
										int availability = AllowedAppointments(myStart, myEnd);

										switch (availability)
											{
												case 0:
													Database.CreateAppointment(myCustomerID, AppointmentTxt.Text, DescriptionTxt.Text, LocationTxt.Text, ContactTxt.Text, TypeCombo.SelectedItem.ToString(), myStart, myEnd);
													MessageBox.Show("Appointment created successfully!");
													this.Owner.Show();
													this.Close();
													break;
												case 1:
													MessageBox.Show("The appointment is outside of business hours, select a different time");
													break;
												case 2:
													MessageBox.Show("The appointment conflicts with another appointment on the schedule, select a different time");
													break;
												case 3:
													MessageBox.Show("The appointment start time is after the end time");
													break;
												case 4:
													MessageBox.Show("The appointment start and end date are not on the same date");
													break;
											}
									}
							}
						if (passed == false)
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

				private void SelectCombo_SelectedValueChanged(object sender, EventArgs e)
					{
						AppointmentTxt.Enabled = true;
						DescriptionTxt.Enabled = true;
						LocationTxt.Enabled = true;
						ContactTxt.Enabled = true;
						TypeCombo.Enabled = true;
						AddBtn.Enabled = true;
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Owner.Show();
						this.Close();
					}
			}
	}
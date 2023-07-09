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
		public partial class UpdateAppointment : Form
			{
				public static List<KeyValuePair<string, object>> myAppointmentList;

				public void SetAppointmentList(List<KeyValuePair<string, object>> myList)
					{
						myAppointmentList = myList;
					}

				public static List<KeyValuePair<string, object>> GetAppointmentList()
					{
						return myAppointmentList;
					}

				public UpdateAppointment()
					{
						InitializeComponent();
						ShowCustomerList();
						ComboBoxSettings();
					}

				public void ComboBoxSettings()
					{
						CustomerCombo.SelectedItem = null;
						CustomerCombo.Text = "--Select--";
						AppointmentCombo.Enabled = false;
						AppointmentTxt.Enabled = false;
						DescriptionTxt.Enabled = false;
						LocationTxt.Enabled = false;
						ContactTxt.Enabled = false;
						TypeCombo.Enabled = false;
						StartDateTimePicker.Enabled = false;
						EndDateTimePicker.Enabled = false;
						UpdateBtn.Enabled = false;
					}

				public void ShowCustomerList()
					{
						SqlConnection myConnection = new SqlConnection(Database.GetConnectionString());

						try
							{
								string myQuery = "SELECT customerId, concat(customerName, ' --ID: ', customerId) as Display FROM customer;";
								SqlDataAdapter myDataAdapter = new SqlDataAdapter(myQuery, myConnection);
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

				public void ShowAppointmentList()
					{
						SqlConnection myConnection = new SqlConnection(Database.GetConnectionString());
						string myUTCOffset = (TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).ToString().Substring(0, 6));

						try
							{
						        string myQuery = $"SELECT appointmentId, concat(type, ' --Time: ', DATE_FORMAT(CONVERT_TZ(start, '+00:00', '{myUTCOffset}'), '%M %D %Y %r')) as Display FROM appointment WHERE customerId = '{CustomerCombo.SelectedValue}';";
								SqlDataAdapter myDataAdapter = new SqlDataAdapter(myQuery, myConnection);
								myConnection.Open();

								DataSet myDataSet = new DataSet();
								myDataAdapter.Fill(myDataSet, "Appoint");
								AppointmentCombo.DisplayMember = "Display";
								AppointmentCombo.ValueMember = "appointmentId";
								AppointmentCombo.DataSource = myDataSet.Tables["Appoint"];
							}
						catch (Exception myException)
							{
								MessageBox.Show("Error! " + myException);
							}
					}

				private void CustomerCombo_SelectedValueChanged(object sender, EventArgs e)
					{
						ShowAppointmentList();
						AppointmentCombo.Enabled = true;
						AppointmentTxt.Enabled = false;  
						DescriptionTxt.Enabled = false;
						LocationTxt.Enabled = false;
						ContactTxt.Enabled = false;
						TypeCombo.Enabled = false;
						StartDateTimePicker.Enabled = false;
						EndDateTimePicker.Enabled = false;
						UpdateBtn.Enabled = false;
						AppointmentTxt.Text = null;
						DescriptionTxt.Text = null;
						LocationTxt.Text = null;
						ContactTxt.Text = null;
						TypeCombo.SelectedItem = null;
					}

				private void AppointmentCombo_SelectedValueChanged(object sender, EventArgs e)
					{
						DataRowView myDataRowView = AppointmentCombo.SelectedItem as DataRowView;
						int myID = Convert.ToInt32(AppointmentCombo.SelectedValue);
						List<KeyValuePair<string, object>> myAppointmentList = Database.GetAppointmentList(myID);
						SetAppointmentList(myAppointmentList);

						if (AppointmentCombo.SelectedIndex != -1)
							{
								AppointmentTxt.Enabled = true;
								DescriptionTxt.Enabled = true;
								LocationTxt.Enabled = true;
								ContactTxt.Enabled = true;
								TypeCombo.Enabled = true;
								StartDateTimePicker.Enabled = true;
								EndDateTimePicker.Enabled = true;
								UpdateBtn.Enabled = true;
								DisplayFields(myAppointmentList);
							}
					}

				public void DisplayFields(List<KeyValuePair<string, object>> myAppointmentList)
					{
						// Lambda expressions to get values from the AppointmentList
						AppointmentTxt.Text = myAppointmentList.First(myKeyValuePair => myKeyValuePair.Key == "title").Value.ToString();
						DescriptionTxt.Text = myAppointmentList.First(myKeyValuePair => myKeyValuePair.Key == "description").Value.ToString();
						LocationTxt.Text = myAppointmentList.First(myKeyValuePair => myKeyValuePair.Key == "location").Value.ToString();
						ContactTxt.Text = myAppointmentList.First(myKeyValuePair => myKeyValuePair.Key == "contact").Value.ToString();
						TypeCombo.SelectedIndex = TypeCombo.FindStringExact(myAppointmentList.First(myKeyValuePair => myKeyValuePair.Key == "type").Value.ToString());
						string myStart = myAppointmentList.Find(myKeyValuePair => myKeyValuePair.Key == "start").Value.ToString();
						string myEnd = myAppointmentList.Find(myKeyValuePair => myKeyValuePair.Key == "end").Value.ToString();
						StartDateTimePicker.Value = Convert.ToDateTime(myStart).ToLocalTime(); 
						EndDateTimePicker.Value = Convert.ToDateTime(myEnd).ToLocalTime();
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Owner.Show();
						this.Close();
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

				private void UpdateBtn_Click(object sender, EventArgs e)
					{
						// Take currently selected customer and update an appointment for them
						bool passed = CheckEmpty();
						if (passed == true)
							{
								DialogResult myConfirmation = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
								if (myConfirmation == DialogResult.Yes)
									{
										try
											{
												DateTime myStart = StartDateTimePicker.Value.ToUniversalTime();
												DateTime myEnd = EndDateTimePicker.Value.ToUniversalTime();
												int availability = AllowedAppointments(myStart, myEnd);

												switch (availability)
													{
														case 0:
															List<KeyValuePair<string, object>> myList = GetAppointmentList();

															// Lambda expression converting AppointmentList to dictionary
															IDictionary<string, object> myDictionary = myList.ToDictionary(myKeyValuePair => myKeyValuePair.Key, myKeyValuePair => myKeyValuePair.Value);
															myDictionary["appointmentId"] = AppointmentCombo.SelectedValue;
															myDictionary["customerId"] = CustomerCombo.SelectedValue;
															myDictionary["title"] = AppointmentTxt.Text;
															myDictionary["description"] = DescriptionTxt.Text;
															myDictionary["location"] = LocationTxt.Text;
															myDictionary["contact"] = ContactTxt.Text;
															myDictionary["type"] = TypeCombo.SelectedItem.ToString();
															myDictionary["start"] = StartDateTimePicker.Value;
															myDictionary["end"] = EndDateTimePicker.Value;
															myDictionary["url"] = CustomerCombo.SelectedValue;

															Database.UpdateAppointment(myDictionary);
															MessageBox.Show("Appointment updated successfully!");
															this.Owner.Show();
															this.Close();
															break;
														case 1:
															MessageBox.Show("The appointment is outside of business hours, select a different time"); ;
															break;
														case 2:
															MessageBox.Show("The appointment conflicts with another appointment, select a different time");
															break;
														case 3:
															MessageBox.Show("The appointment start time is after the end time.");
															break;
														case 4:
															MessageBox.Show("The appointment start and end date are not on the same date.");
															break;
													}
											}
										catch (Exception myException)
											{
												Console.WriteLine(myException);
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
			}
	}
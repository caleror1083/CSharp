/*
	C868 Software Development Capstone
	Robert Calero
	Student ID# 000998416
*/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp
	{
		public partial class DeleteAppointment : Form
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

				public DeleteAppointment()
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
						DeleteBtn.Enabled = false;
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

				public void ShowAppointmentList()
					{
						MySqlConnection myConnection = new MySqlConnection(Database.GetConnectionString());
						string myUTCOffset = (TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).ToString().Substring(0, 6));

						try
							{
						        string myQuery = $"SELECT appointmentId, concat(type, ' --Time: ', DATE_FORMAT(CONVERT_TZ(start, '+00:00', '{myUTCOffset}'), '%M %D %Y %r')) as Display FROM appointment WHERE customerId = '{CustomerCombo.SelectedValue}';";
								MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(myQuery, myConnection);
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
						DeleteBtn.Enabled = false;
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
						var myAppointmentList = Database.GetAppointmentList(myID);
						SetAppointmentList(myAppointmentList);

						if (AppointmentCombo.SelectedIndex != -1)
							{
								DeleteBtn.Enabled = true;
								DisplayFields(myAppointmentList);
							}
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Owner.Show();
						this.Close();
					}

				private void DeleteBtn_Click(object sender, EventArgs e)
					{
						DialogResult myConfirmation = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
						if (myConfirmation == DialogResult.Yes)
							{
								try
									{
										var myList = GetAppointmentList();

										// Lambda expression converting AppointmentList to dictionary
										IDictionary<string, object> myDictionary = myList.ToDictionary(myKeyValuePair => myKeyValuePair.Key, myKeyValuePair => myKeyValuePair.Value);
										Database.DeleteAppointment(myDictionary);
										MessageBox.Show("Appointment deleted successfully!");

										ShowAppointmentList();
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
	}
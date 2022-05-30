/*
	C868 Software Development Capstone
	Robert Calero
	Student ID# 000998416
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp
	{
		public partial class Scheduling : Form
			{
				public Scheduling()
					{
						InitializeComponent();
						CalendarDGV.DataSource = ShowCalendar(WeeklyCalendar.Checked);
					}

				public static Array ShowCalendar(bool weekly)
					{
						SqlConnection myConnection = new SqlConnection(Database.myConnectionString);
						myConnection.Open();

						var myQuery = $"SELECT customerId, type, start, end, appointmentId, userId FROM appointment WHERE userId = '{Database.GetUserID()}'";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlDataReader myReader = myCommand.ExecuteReader();
						Dictionary<int, Hashtable> myAppointments = new Dictionary<int, Hashtable>();
						Dictionary<int, Hashtable> myParsedAppointments = new Dictionary<int, Hashtable>();

						// Creates a dictionary of appointments
						while (myReader.Read())
							{
								Hashtable myAppointment = new Hashtable();
								myAppointment.Add("customerId", myReader[0]);
								myAppointment.Add("type", myReader[1]);
								myAppointment.Add("start", myReader[2]);
								myAppointment.Add("end", myReader[3]);
								myAppointment.Add("userId", myReader[5]);
								myAppointments.Add(Convert.ToInt32(myReader[4]), myAppointment);
							}
						myReader.Close();

						// Assigns a userName to appointment dictionary
						foreach (var myAppointment in myAppointments.Values)
							{
								myQuery = $"SELECT userName FROM user WHERE userId = '{myAppointment["userId"]}'";
								myCommand = new SqlCommand(myQuery, myConnection);
								myReader = myCommand.ExecuteReader();
								myReader.Read();
								myAppointment.Add("userName", myReader[0]);
								myReader.Close();
							}

						// Assigns a customerName to appointment dictionary
						foreach (var myAppointment in myAppointments.Values)
							{
								myQuery = $"SELECT customerName FROM customer WHERE customerId = '{myAppointment["customerId"]}'";
								myCommand = new SqlCommand(myQuery, myConnection);
								myReader = myCommand.ExecuteReader();
								myReader.Read();
								myAppointment.Add("customerName", myReader[0]);
								myReader.Close();
							}

						foreach (var myAppointment in myAppointments)
							{
								DateTime myStart = DateTime.Parse(myAppointment.Value["start"].ToString());
								DateTime myEnd = DateTime.Parse(myAppointment.Value["end"].ToString());
								DateTime myToday = DateTime.UtcNow;

								// Weekly appointments are checked in our appointment list
								if (weekly)
									{
										DateTime mySunday = myToday.AddDays(-(int)myToday.DayOfWeek);
										DateTime mySaturday = myToday.AddDays(-(int)myToday.DayOfWeek + (int)DayOfWeek.Saturday);
										
										if (myStart >= mySunday && myEnd < mySaturday)
											{
												myParsedAppointments.Add(myAppointment.Key, myAppointment.Value);
											}
									}

								// If not then we get month appointments
								else
									{
										DateTime myFirstOfMonth = new DateTime(myToday.Year, myToday.Month, 1);
										DateTime myLastOfMonth = myFirstOfMonth.AddMonths(1).AddDays(-1);
										
										if (myStart >= myFirstOfMonth && myEnd < myLastOfMonth)
											{
												myParsedAppointments.Add(myAppointment.Key, myAppointment.Value);
											}
									}
							}

						// What is displayed to the user in the calendar view
						Database.SetAppointments(myAppointments);
						var myAppointmenttArray = from row in myParsedAppointments select new
							{
								id = row.Key,
								type = row.Value["type"],
								start = Convert.ToDateTime(row.Value["start"].ToString()).ToLocalTime(),
								end = Convert.ToDateTime(row.Value["end"].ToString()).ToLocalTime(),
								customer = row.Value["customerName"]
							};
						myConnection.Close();
						return myAppointmenttArray.ToArray();
					}

				public void UpdateCalendar()
					{
						CalendarDGV.DataSource = ShowCalendar(WeeklyCalendar.Checked);
					}

				private void WeeklyCalendar_CheckedChanged(object sender, EventArgs e)
					{
						UpdateCalendar();
					}

				private void RefreshBtn_Click(object sender, EventArgs e)
					{
						UpdateCalendar();
					}

				private void AddCustBtn_Click(object sender, EventArgs e)
					{
						Form myAddCustomer = new AddCustomer();
						myAddCustomer.Owner = this;
						myAddCustomer.Show();
						this.Hide();
					}

				private void UpdateCustBtn_Click(object sender, EventArgs e)
					{
						Form myUpdateCustomer = new UpdateCustomer();
						myUpdateCustomer.Owner = this;
						myUpdateCustomer.Show();
						this.Hide();
					}

				private void DeleteCustBtn_Click(object sender, EventArgs e)
					{
						Form myDeleteCustomer = new DeleteCustomer();
						myDeleteCustomer.Owner = this;
						myDeleteCustomer.Show();
						this.Hide();
					}

				private void AddApptBtn_Click(object sender, EventArgs e)
					{
						Form myAddAppointment = new AddAppointment();
						myAddAppointment.Owner = this;
						myAddAppointment.Show();
						this.Hide();
					}

				private void UpdateApptBtn_Click(object sender, EventArgs e)
					{
						Form myUpdateAppointment = new UpdateAppointment();
						myUpdateAppointment.Owner = this;
						myUpdateAppointment.Show();
						this.Hide();
					}

				private void DeleteApptBtn_Click(object sender, EventArgs e)
					{
						Form myDeleteAppointment = new DeleteAppointment();
						myDeleteAppointment.Owner = this;
						myDeleteAppointment.Show();
						this.Hide();
					}

				private void AppointmentsByCustomer_Click(object sender, EventArgs e)
					{
						Form mySearchCustomer = new SearchCustomer();
						mySearchCustomer.Owner = this;
						mySearchCustomer.Show();
						this.Hide();
					}

				private void AppointmentsByConsultant_Click(object sender, EventArgs e)
					{
						Form mySearchConsultant = new SearchConsultant();
						mySearchConsultant.Owner = this;
						mySearchConsultant.Show();
						this.Hide();
					}

				private void ReportAppointmentMonth_Click(object sender, EventArgs e)
					{
						Form myReportMonth = new ReportMonth();
						myReportMonth.Owner = this;
						myReportMonth.Show();
						this.Hide();
					}

				private void ReportAppointmentType_Click(object sender, EventArgs e)
					{
						Form myReportType = new ReportType();
						myReportType.Owner = this;
						myReportType.Show();
						this.Hide();
					}

				private void AddUserBtn_Click(object sender, EventArgs e)
					{
						Form myAddUser = new AddUser();
						myAddUser.Owner = this;
						myAddUser.Show();
						this.Hide();
					}

				private void UpdateUserBtn_Click(object sender, EventArgs e)
					{
						Form myUpdateUser = new UpdateUser();
						myUpdateUser.Owner = this;
						myUpdateUser.Show();
						this.Hide();
					}

				private void DeleteUserBtn_Click(object sender, EventArgs e)
					{
						Form myDeleteUser = new DeleteUser();
						myDeleteUser.Owner = this;
						myDeleteUser.Show();
						this.Hide();
					}

				private void Scheduling_FormClosing(object sender, FormClosingEventArgs e)
					{
						Log.Logout(Database.GetUserName());
					}
			}
	}
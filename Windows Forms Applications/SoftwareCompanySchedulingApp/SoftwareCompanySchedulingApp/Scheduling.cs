/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SoftwareCompanySchedulingApp
	{
		public partial class Scheduling : Form
			{
				public Login login;

				public Scheduling()
					{
						InitializeComponent();
						calendarDGV.DataSource = CalendarPop(weeklyCalendar.Checked);
						Reminder(calendarDGV);
					}

				public static string setApptId = "";
				public static string setCustName = "";
				bool buttonWasClicked = false;

				private void weeklyCalendar_CheckedChanged(object sender, EventArgs e)
					{
						UpdateCalendar();
						message.Text = "Showing appointments for the next 7 days";
					}

				private void monthlyCalendar_CheckedChanged(object sender, EventArgs e)
					{
						UpdateCalendar();
						message.Text = "Showing appointments for the next 30 days";
					}

				private void AddBtn_Click(object sender, EventArgs e)
					{
						AddCustomer addCustomer = new AddCustomer();
						addCustomer.Show();
					}

				private void UpdateBtn_Click(object sender, EventArgs e)
					{
						UpdateCustomer updateCustomer = new UpdateCustomer();
						updateCustomer.Show();
					}

				private void DeleteBtn_Click(object sender, EventArgs e)
					{
						DeleteCustomer deleteCustomer = new DeleteCustomer();
						deleteCustomer.Show();
					}

				private void AddApptBtn_Click(object sender, EventArgs e)
					{
						AddAppt addAppt = new AddAppt();
						addAppt.mainAppt = this;
						addAppt.Show();
					}

				private void UpdateApptBtn_Click(object sender, EventArgs e)
					{
						buttonWasClicked = true;
						if (buttonWasClicked == true)
							{
								int rowIndex = calendarDGV.CurrentCell.RowIndex;
								setApptId = calendarDGV.Rows[rowIndex].Cells[0].Value.ToString();
								setCustName = calendarDGV.Rows[rowIndex].Cells[4].Value.ToString();
							}
						UpdateAppt updateAppt = new UpdateAppt();
						updateAppt.scheduling = this;
						updateAppt.Show();
					}
				
				public static Dictionary<string, string> apptDetails = new Dictionary<string, string>();
				private void DeleteApptBtn_Click(object sender, EventArgs e)
					{
						buttonWasClicked = true;
						if (buttonWasClicked == true)
							{
								if (MessageBox.Show("Delete this appointment?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
									{
										int rowIndex = calendarDGV.CurrentCell.RowIndex;
										string apptId = calendarDGV.Rows[rowIndex].Cells[0].Value.ToString();
										apptDetails = LoginControl.ApptDetails(apptId);
										DeleteAppt();
										UpdateCalendar();
									}
							}
					}

				private void ReportApptMonth_Click(object sender, EventArgs e)
					{
						AppointmentTypeReport showAppointmentReport = new AppointmentTypeReport();
						showAppointmentReport.Show();
					}

				private void ReportConsultant_Click(object sender, EventArgs e)
					{
						ConsultantReport showConsultantReport = new ConsultantReport();
						showConsultantReport.Show();
					}

				private void ReportShort_Click(object sender, EventArgs e)
					{
						CustomerReport showShortReport = new CustomerReport();
						showShortReport.Show();
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Close();
						MessageBox.Show("Goodbye!");
						Application.Exit();
					}

				private void Reminder(DataGridView myCalendar)
					{
						foreach (DataGridViewRow row in myCalendar.Rows)
							{
								DateTime now = DateTime.UtcNow;
								DateTime begin = DateTime.Parse(row.Cells[2].Value.ToString()).ToUniversalTime();
								TimeSpan beginAppt = begin - now;
								if (beginAppt.TotalMinutes <= 15 && beginAppt.TotalMinutes > 0)
									{
										MessageBox.Show($"Reminder: You have a meeting with {row.Cells[4].Value} at {row.Cells[2].Value}");
									}
							}
					}

				public static bool DeleteAppt()
					{
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();
						string delete = $"DELETE FROM appointment WHERE appointmentId = '{apptDetails["appointmentId"]}'";
						SqlCommand myCommand = new SqlCommand(delete, myConnection);
						int apptDeleted = myCommand.ExecuteNonQuery();
						myConnection.Close();
						if (apptDeleted != 0)
							{
								return true;
							}
						else
							{
								return false;
							}
					}

				public void UpdateCalendar()
					{
						bool view = true;
						if (weeklyCalendar.Checked)
							{
								calendarDGV.DataSource = CalendarPop(view);
							}
						else
							{
								view = false;
								calendarDGV.DataSource = CalendarPop(view);
							}
					}

				private static Array CalendarPop(bool view)
					{
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();
							{
								string myQuery = $"SELECT customerId, type, start, end, appointmentId, userId FROM appointment WHERE userId = '{LoginControl.GetUserId()}'";
								SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
								SqlDataReader myReader = myCommand.ExecuteReader();

								Dictionary<int, Hashtable> appts = new Dictionary<int, Hashtable>();
								// Dictionary of all appointments
								while (myReader.Read())
									{
										Hashtable tableAppt = new Hashtable();
										tableAppt.Add("customerId", myReader[0]);
										tableAppt.Add("type", myReader[1]);
										tableAppt.Add("start", myReader[2]);
										tableAppt.Add("end", myReader[3]);
										tableAppt.Add("userId", myReader[5]);

										appts.Add(Convert.ToInt32(myReader[4]), tableAppt);
									}
								myReader.Close();

								foreach (var appt in appts.Values)	// Assigns the username to each appointment
									{
										myQuery = $"SELECT userName FROM user WHERE userId = '{appt["userId"]}'";
										myCommand = new SqlCommand(myQuery, myConnection);
										myReader = myCommand.ExecuteReader();
										myReader.Read();
										appt.Add("userName", myReader[0]);
										myReader.Close();
									}

								foreach (var app in appts.Values)	// Assigns the customerName to each appointment
									{
										myQuery = $"SELECT customerName FROM customer WHERE customerId = '{app["customerId"]}'";
										myCommand = new SqlCommand(myQuery, myConnection);
										myReader = myCommand.ExecuteReader();
										myReader.Read();
										app.Add("customerName", myReader[0]);
										myReader.Close();
									}

								Dictionary<int, Hashtable> pAppts = new Dictionary<int, Hashtable>();
								foreach (var app in appts)
									{
										DateTime start = DateTime.Parse(app.Value["start"].ToString());
										DateTime end = DateTime.Parse(app.Value["end"].ToString());
										DateTime now = DateTime.UtcNow;
										if (view == true)
											{
												DateTime sun = now.AddDays(-(int)now.DayOfWeek);
												DateTime sat = now.AddDays(-(int)now.DayOfWeek + (int)DayOfWeek.Saturday);
												if (start >= sun && end <= sat)
													{
														pAppts.Add(app.Key, app.Value);
													}
											}
										else
											{
												DateTime startOfMonth = new DateTime(now.Year, now.Month, 1);
												DateTime endofMonth = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
												if (start >= startOfMonth && end <= endofMonth)
													{
														pAppts.Add(app.Key, app.Value);
													}												
											}
										
									}
								LoginControl.SetAppts(appts);
								var apptArray = from row in pAppts
											    select new
													{
														ID = row.Key,
														Type = row.Value["type"],
														StartTime = LoginControl.ConvertToTimezone(row.Value["start"].ToString()),
														EndTime = LoginControl.ConvertToTimezone(row.Value["end"].ToString()),
														Customer = row.Value["customerName"]
													};
								myConnection.Close();
								return apptArray.ToArray();
							}
					}
			}
	}
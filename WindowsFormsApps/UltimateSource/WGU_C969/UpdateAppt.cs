/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WGU_C969
	{
		public partial class UpdateAppt : Form
			{
				public Scheduling scheduling;
				public static Dictionary<string, string> update = new Dictionary<string, string>();

		        public UpdateAppt()
					{
						InitializeComponent();
						UpdateInformation();
					}

                private void UpdateAppt_Load(object sender, EventArgs e)
                    {
                        StartDT.Value = DateTime.Now;
                        EndDT.Value = DateTime.Now.AddMinutes(60);
                    }

				private void StartDT_ValueChanged(object sender, EventArgs e)
					{
						StartDT.Format = DateTimePickerFormat.Custom;
						StartDT.CustomFormat = "hh:mm tt MMMM dd, yyyy";
					}

                private void EndDT_ValueChanged(object sender, EventArgs e)
                {
                    EndDT.Format = DateTimePickerFormat.Custom;
			        EndDT.CustomFormat = "hh:mm tt MMMM dd, yyyy";
                }

				private void UpdateBtn_Click(object sender, EventArgs e)
                    {
                        Dictionary<string, string> updateInfo = new Dictionary<string, string>();

                        int user_id = LoginControl.GetUserId();
                        string user_name = LoginControl.GetUserName();
                        string stamp = LoginControl.CreateStamp();

                        DateTime begin = StartDT.Value.ToUniversalTime();
                        DateTime finish = EndDT.Value.ToUniversalTime();

                        if (string.IsNullOrEmpty(TypeTxt.Text)
)
							{
								MessageBox.Show("All fields must be completed");
							}
                        else
                            {
                                try
                                    {
                                        if (Conflict(begin, finish))
                                            {
                                                throw new ApptExceptions();
                                            }
                                        else
                                            {
                                                try
                                                    {
                                                        if (BusinessHours(begin, finish))
                                                            {
                                                                throw new ApptExceptions();
                                                            }
                                                        else
                                                            {
                                                                updateInfo.Add("type", TypeTxt.Text);
                                                                updateInfo.Add("customerId", CustomerIdTxt.Text);
                                                                updateInfo.Add("start", StartDT.Value.ToUniversalTime().ToString("u"));
                                                                updateInfo.Add("end", EndDT.Value.ToUniversalTime().ToString("u"));

                                                                if (UpdateApptInfo(updateInfo))
                                                                    {
                                                                        scheduling.UpdateCalendar();
                                                                        MessageBox.Show("Updated");
                                                                    }
                                                            }
                                                    }
                                                catch (ApptExceptions ex)
                                                    {

                                                        ex.OutsideHours();
                                                    }
                                            }
                                    }
                                catch (ApptExceptions ex)
                                    {
                                        ex.Overlapping();
                                    }
                                scheduling.UpdateCalendar();
                                this.Close();
                            }
                    }

                public static bool Conflict(DateTime begin, DateTime finish)
                    {
                        foreach (var appt in LoginControl.GetAppts().Values)
                            {
                                if (begin < DateTime.Parse(appt["end"].ToString()) && DateTime.Parse(appt["start"].ToString()) < finish)
                                    {
                                        return true;
                                    }
                            }
                        return false;
                    }

                public static bool BusinessHours(DateTime open, DateTime close)
                    {
                        open = open.ToLocalTime();
                        close = close.ToLocalTime();

                        // Business hours are 8:00am to 5:00pm
                        DateTime businessOpen = DateTime.Today.AddHours(8);
                        DateTime businessClose = DateTime.Today.AddHours(17);
                        if (open.TimeOfDay >= businessOpen.TimeOfDay && open.TimeOfDay < businessClose.TimeOfDay && close.TimeOfDay > businessOpen.TimeOfDay && close.TimeOfDay <= businessClose.TimeOfDay)
                            {
                                return false;
                            }
                        return true;
                    }

                public static bool UpdateApptInfo(Dictionary<string, string> updateInfo)
                    {
                        MySqlConnection myConnection = new MySqlConnection(Properties.Resources.connectionString.ToString());
                        myConnection.Open();
                        
                        // Update Customer Table
                        string myUpdates = $"UPDATE appointment SET customerId = '{updateInfo["customerId"]}', start = '{updateInfo["start"]}', end = '{updateInfo["end"]}', type = '{updateInfo["type"]}', lastUpdate = '{LoginControl.CreateStamp()}', lastUpdateBy = '{LoginControl.GetUserName()}' WHERE appointmentId = '{update["appointmentId"]}'";
                        MySqlCommand myCommand = new MySqlCommand(myUpdates, myConnection);
                        int updatedAppt = myCommand.ExecuteNonQuery();
                        if (updatedAppt != 0)
                            {
                                return true;
                            }
                        else
                            {
                                return false;
                            }
                    }

				private void UpdateInformation()
					{
						string apptId = Scheduling.setApptId;
						update = LoginControl.ApptDetails(apptId);
						NameTxt.Text = Scheduling.setCustName;
						CustomerIdTxt.Text = update["customerId"];
						ApptIdTxt.Text = apptId;
						TypeTxt.Text = update["type"];
						StartDT.Value = DateTime.Parse(LoginControl.ConvertToTimezone(update["start"]));
						EndDT.Value = DateTime.Parse(LoginControl.ConvertToTimezone(update["end"]));				
					}

                private void ExitBtn_Click(object sender, EventArgs e)
                    {
                        this.Close();
                    }
            }
	}
/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SoftwareCompanySchedulingApp
	{
		public partial class AddAppt : Form
			{
				public Scheduling mainAppt;
                public static Dictionary<string, string> myCustomerForm = new Dictionary<string, string>();
                public static Dictionary<string, string> myForm = new Dictionary<string, string>();

				public AddAppt()
					{
						InitializeComponent();
						EndDT.Value = EndDT.Value.AddHours(1);
					}

                private void AddAppt_Load(object sender, EventArgs e)
                    {
                        StartDT.Value = DateTime.Now;
                        EndDT.Value = DateTime.Now.AddMinutes(60);

                        string myQuery = $"SELECT customerId, customerName FROM customer";
                        SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
                        myConnection.Open();
                        SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
                        SqlDataReader myReader;
                        myReader = myCommand.ExecuteReader();
                        DataTable myTable = new DataTable();
                        myTable.Columns.Add("customerId", typeof(string));
                        myTable.Columns.Add("customerName", typeof(string));
                        myTable.Load(myReader);
                        NameBox.ValueMember = "customerId";
                        NameBox.DisplayMember = "customerName";
                        NameBox.DataSource = myTable;
                        myConnection.Close();
                    }

                private void NameBox_SelectedIndexChanged(object sender, EventArgs e)
                    {
                        string name = NameBox.SelectedValue.ToString();
                        int custId = LoginControl.FindCust(name);

                        if (custId != 0)
                            {
                                myCustomerForm = LoginControl.CustDetails(custId);
                                CustomerIdTxt.Text = myCustomerForm["customerId"];
                            }
                        else
                            {
                                MessageBox.Show("Customer not found, try again");
                            }
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

				private void AddBtn_Click(object sender, EventArgs e)
					{
                        int user_Id = LoginControl.GetUserId();
                        string user_Name = LoginControl.GetUserName();
                        string stamp = LoginControl.CreateStamp();

                        DateTime begin = StartDT.Value.ToUniversalTime();
                        DateTime finish = EndDT.Value.ToUniversalTime();
 
                        if (string.IsNullOrEmpty(TypeTxt.Text)
)
							{
								MessageBox.Show("You must fill out all information before you can add an appointment");
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
                                                                LoginControl.CreateRec(stamp, user_Name, "appointment", $"'{CustomerIdTxt.Text}', '{StartDT.Value.ToUniversalTime().ToString("u")}', '{EndDT.Value.ToUniversalTime().ToString("u")}', '{TypeTxt.Text}'", user_Id);
                                                                MessageBox.Show("Appointment apped successfully");
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
                                mainAppt.UpdateCalendar();
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

                private void ExitBtn_Click(object sender, EventArgs e)
                    {
                        this.Close();
                    }
            }
	}
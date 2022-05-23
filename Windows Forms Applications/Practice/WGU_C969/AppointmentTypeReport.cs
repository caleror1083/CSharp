/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SoftwareCompanySchedulingApp
	{
		public struct TypeReport
			{
				public string calendarMonth;
				public string apptType;
				public int count;
			}

		public partial class AppointmentTypeReport : Form
			{
				public AppointmentTypeReport()
					{
						InitializeComponent();
						OutputDGV.DataSource = Creation();
					}

				private static Array Creation()
					{
						List<TypeReport> typeReports = new List<TypeReport>();
						List<Hashtable> apptTypes = new List<Hashtable>();
						SortedList calendarMonths = new SortedList();

						calendarMonths.Add(1, "January");
						calendarMonths.Add(2, "February");
						calendarMonths.Add(3, "March");
						calendarMonths.Add(4, "April");
						calendarMonths.Add(5, "May");
						calendarMonths.Add(6, "June");
						calendarMonths.Add(7, "July");
						calendarMonths.Add(8, "August");
						calendarMonths.Add(9, "September");
						calendarMonths.Add(10, "October");
						calendarMonths.Add(11, "November");
						calendarMonths.Add(12, "December");

						foreach (var appt in LoginControl.GetAppts().Values)
							{
								int apptMonth = DateTime.Parse(appt["start"].ToString()).Month;
								bool duplicate = false;
								
								foreach (TypeReport appointment in typeReports)
									{
										if (appointment.calendarMonth == calendarMonths[apptMonth].ToString() && appointment.apptType == appt["type"].ToString())
											{
												duplicate = true;
											}
									}

								if (!duplicate)
									{
									    TypeReport typeReport = new TypeReport();
										typeReport.calendarMonth = calendarMonths[apptMonth].ToString();
										typeReport.apptType = appt["type"].ToString();

										// Lambda expression for counting
										typeReport.count = LoginControl.GetAppts().Where(a => a.Value["type"].ToString() == appt["type"].ToString() && DateTime.Parse(a.Value["start"].ToString()).	Month == apptMonth).Count();
										typeReports.Add(typeReport);
									}
							}
						var arrAppts = from row in typeReports select new {Month = row.calendarMonth, Type = row.apptType, Count = row.count};
						return arrAppts.ToArray();
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Dispose(false);
						this.Close();
					}
			}
	}
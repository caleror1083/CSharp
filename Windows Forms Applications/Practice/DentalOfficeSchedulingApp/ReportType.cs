/*
	C868 Software Development Capstone
	Robert Calero
	Student ID# 000998416
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp
	{
		public partial class ReportType : Form
			{
				public ReportType()
					{
						InitializeComponent();
						DateTimeLbl.Text = DateTime.Now.ToString();
						IDictionary<string, object> myDictionary = Database.AppointmentByTypeCount();
						CleaningsCount.Text = myDictionary["cleaning"].ToString();
						CavitiesCount.Text = myDictionary["cavities"].ToString();
						WisdomCount.Text = myDictionary["wisdomTeeth"].ToString();
						ConsultationsCount.Text = myDictionary["consultation"].ToString();
						RootCanalsCount.Text = myDictionary["rootCanals"].ToString();
						OtherCount.Text = myDictionary["other"].ToString();
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Owner.Show();
						this.Close();
					}
			}
	}
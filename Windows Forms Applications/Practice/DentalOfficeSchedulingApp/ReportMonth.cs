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
		public partial class ReportMonth : Form
			{
				public ReportMonth()
					{
						InitializeComponent();
						DateTimeLbl.Text = DateTime.Now.ToString();
					}

				private void TypeCombo_SelectedValueChanged(object sender, EventArgs e)
					{
						string myType = TypeCombo.SelectedItem.ToString();
						IDictionary<string, object> myDictionary = Database.AppointmentByMonth(myType);
						JanuaryCount.Text = myDictionary["Jan"].ToString();
						FebruaryCount.Text = myDictionary["Feb"].ToString();
						MarchCount.Text = myDictionary["Mar"].ToString();
						AprilCount.Text = myDictionary["Apr"].ToString();
						MayCount.Text = myDictionary["May"].ToString();
						JuneCount.Text = myDictionary["Jun"].ToString();
						JulyCount.Text = myDictionary["Jul"].ToString();
						AugustCount.Text = myDictionary["Aug"].ToString();
						SeptemberCount.Text = myDictionary["Sep"].ToString();
						OctoberCount.Text = myDictionary["Oct"].ToString();
						NovemberCount.Text = myDictionary["Nov"].ToString();
						DecemberCount.Text = myDictionary["Dec"].ToString();
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Owner.Show();
						this.Close();
					}
			}
	}
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

namespace WGU_C969
	{
		public struct ConsultReport
			{
				public int user_Id;
				public string user_Name;
				public string type;
				public string start;
				public string end;
				public string name;
			}

		public partial class ConsultantReport : Form
			{
				public ConsultantReport()
					{
						InitializeComponent();
						OutputDGV.DataSource = Creation();
					}

				private static Array Creation()
					{
						Dictionary<int, Hashtable> consultantReports = LoginControl.GetAppts();
						var arrAppt = from row in consultantReports select new {UserName = row.Value["userName"], Type = row.Value["type"], Start = LoginControl.ConvertToTimezone(row.Value["start"].ToString()), End = LoginControl.ConvertToTimezone(row.Value["end"].ToString()), Customer = row.Value["customerName"]};
						return arrAppt.ToArray();
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Dispose(false);
						this.Close();
					}
			}
	}
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
		public struct CustomerInformation
			{
				public string name;
				public int appointments;
			}

		public partial class CustomerReport : Form
			{
				public CustomerReport()
					{
						InitializeComponent();
						OutputDGV.DataSource = Creation();
					}

				private static DataTable Creation()
					{
						Dictionary<int, Hashtable> appts = LoginControl.GetAppts();		// Displays how many appointments each customer has scheduled
						DataTable myTable = new DataTable();
						myTable.Clear();
						myTable.Columns.Add("Customer");
						myTable.Columns.Add("Appointments");
						IEnumerable<string> customer = appts.Select(x => x.Value["customerName"].ToString()).Distinct();	// Lambda selects customer from appointment list
						
						foreach (string cust in customer)
							{
								DataRow myRow = myTable.NewRow();
								myRow["Customer"] = cust;
								myRow["Appointments"] = appts.Where(x => x.Value["customerName"].ToString() == cust.ToString()).Count().ToString();	// Lambda returns the number of customer appointments
								myTable.Rows.Add(myRow);
							}
						return myTable;
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						this.Dispose(false);
						this.Close();
					}
			}
	}
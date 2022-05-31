using System;
using System.Windows.Forms;

namespace Calendar
	{
		public partial class MainForm : Form
			{
				public MainForm()
					{
						InitializeComponent();
					}

				void MainForm_Load(object sender, EventArgs e)
					{
						DisplayDays();	
					}

				void DisplayDays()
					{
						DateTime startoftheMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);  // // Gets the first day of the month
						int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); // Gets the count of days of the month
						int dayoftheweek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("D")) + 1;  // Convert the startofthemonth to integer

						// Iterate through the days of the week adding a blank user control in each iteration
						for (int i = 1; i < dayoftheweek; i++)
							{
								UserControlBlank control = new UserControlBlank();
								DayContainer.Controls.Add(control);
							}

						// Iterate through the days in the month adding a days user control in each iteration
						for (int i = 1; i <= days; i++)
							{
								UserControlDays controlDays = new UserControlDays();
								controlDays.Days(i);
								DayContainer.Controls.Add(controlDays);
							}
					}
			}
	}
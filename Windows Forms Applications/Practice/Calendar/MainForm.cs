using System;
using System.Windows.Forms;

// Namespaces
namespace Calendar
	{
		// Classes
		public partial class MainForm : Form
			{
				// Fields
				private int _Month;
				private int _Year;

				// Contructors(Parameters)
				public MainForm()
					{
						InitializeComponent();
					}

				// <ethods(Parameters)
				void MainForm_Load(object sender, EventArgs e)
					{
						DisplayDays();	
					}

				// Display the days of the month on the calendar
				void DisplayDays()
					{
						_Month = DateTime.Now.Month;
						_Year = DateTime.Now.Year;
						DateTime startoftheMonth = new DateTime(_Year, _Month, 1);  // // Gets the first day in the current month
						int days = DateTime.DaysInMonth(_Year, _Month); // Gets the count of days in the current month
						int dayoftheweek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("D")) + 1;  // Convert the days in the month to integers formatted to numbers

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
								controlDays.Days(i);  // Calls the Days method in the UserControlDays class
								DayContainer.Controls.Add(controlDays);
							}
					}

				private void NextButton_Click(object sender, EventArgs e)
					{
						DayContainer.Controls.Clear();  // Clear the container
						_Month++;  // Increment the current month by 1
						DateTime startoftheMonth = new DateTime(_Year, _Month, 1);
						int days = DateTime.DaysInMonth(_Year, _Month);
						int dayoftheweek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("D")) + 1;

						for (int i = 1; i < dayoftheweek; i++)
							{
								UserControlBlank control = new UserControlBlank();
								DayContainer.Controls.Add(control);
							}

						for (int i = 1; i <= days; i++)
							{
								UserControlDays controlDays = new UserControlDays();
								controlDays.Days(i);
								DayContainer.Controls.Add(controlDays);
							}
					}
			}
	}
using System;
using System.Globalization;
using System.Windows.Forms;

// Namespaces
namespace Calendar
	{
		// Classes
		public partial class MainForm : Form
			{
				// Fields
				private int _Month, _Year;
				public static int static_month, static_year;  // Static variables that passes to the EventForm for month and year

				// Contructors(Parameters)
				public MainForm()
					{
						_Month = DateTime.Now.Month;  // Retrieves the current month
						_Year = DateTime.Now.Year; // Retrieves the current year
						InitializeComponent();
					}

				// Methods(Parameters)
				void MainForm_Load(object sender, EventArgs e)
					{
						DisplayCurentMonth();
					}

				void DisplayCurentMonth()
					{
						string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(_Month); // Gets the current month
						DateLabel.Text = $"{monthName} {_Year}"; // Displays the value of the month name and the year

						static_month = _Month;
						static_year = _Year;
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
								controlDays.DisplayEvents();  // Calls the DisplayEvents method in the UserControlDays class
							}
					}

				void PreviousButton_Click(object sender, EventArgs e)
					{
						DayContainer.Controls.Clear();  // Clear the container

						if (_Month == 1)  // Checks if the value of month is equal to 1
							{
								_Month = 13;  // If user is on January/1, when button is clicked _Month's value is set to 13
								_Year--;  // Decrement to the previous year
							}
						_Month--;  // Decrement month to go to previous month, When _Month's value is 12, user will be in December of the previous year
						static_month = _Month;
						static_year = _Year;
						DisplayCurentMonth();
					}

				void NextButton_Click(object sender, EventArgs e)
					{
						DayContainer.Controls.Clear();

						if (_Month == 12)  // Checks if the value of month is equal to 12
							{
								_Month = 0; // If user is on December/12, when button is clicked _Month's value is set to 0
								_Year++;  // Increase to the next year
							}
						_Month++;  // Increment month to go to next month. When _Month's value is 1, user will be in January of the following year
						static_month = _Month;
						static_year = _Year;
						DisplayCurentMonth();
					}
			}
	}
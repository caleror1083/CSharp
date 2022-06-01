using System.Data.SqlClient;
using System.Windows.Forms;

// Namespaces
namespace Calendar
{
	// Classes
	public partial class UserControlDays : UserControl
			{
				// Fields
				public static string static_day;  // Static variables that passes to the EventForm for day

				// Constructors(Parameters)
				public UserControlDays()
					{
						InitializeComponent();
					}

				// Methods(Parameters)
				public void Days(int numDay)
					{
						DaysLabel.Text = $"{numDay}";  // Display the day in the user control
					}

				void UserControlDays_Click(object sender, System.EventArgs e)
					{
						static_day = DaysLabel.Text;
						DisplayEventTimer.Start();  // Start timer if UserControl is clicked
						EventForm events = new EventForm();
						events.Show();
					}

				public void DisplayEvents()
					{
						using (SqlConnection connection = new SqlConnection(@"Data Source=ROB-DESKTOP\SQLEXPRESS;Initial Catalog=Calendar;Integrated Security=True"))  // Create a connectionstring
							{
								connection.Open();
								SqlCommand command = connection.CreateCommand();
								command.CommandText = $"SELECT * FROM Events WHERE date = @date";
								command.Parameters.AddWithValue("@date", $"{MainForm.static_month}/{DaysLabel.Text}/{MainForm.static_year}");
								
								SqlDataReader reader = command.ExecuteReader();
								if (reader.Read())
									{
										EventLabel.Text = reader["event"].ToString();
									}
							}
					}

				// Timer for auto display event if a new event is added
				void DisplayEventTimer_Tick(object sender, System.EventArgs e)
					{
						DisplayEvents();  // Call the displayEvent method
					}
			}
	}
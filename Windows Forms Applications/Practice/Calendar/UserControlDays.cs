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

				private void UserControlDays_Click(object sender, System.EventArgs e)
					{
						static_day = DaysLabel.Text;
						EventForm events = new EventForm();
						events.Show();
					}
			}
	}
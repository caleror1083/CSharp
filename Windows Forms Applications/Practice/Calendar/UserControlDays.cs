using System.Windows.Forms;

// Namespaces
namespace Calendar
	{
		// Classes
		public partial class UserControlDays : UserControl
			{
				// Constructors(Parameters)
				public UserControlDays()
					{
						InitializeComponent();
					}

				public void Days(int numDay)
					{
						DaysLabel.Text = $"{numDay} ";  // Display the day in the user control
					}
			}
	}
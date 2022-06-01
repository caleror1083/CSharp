using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// Namespaces
namespace Calendar
	{
		// Classes
		public partial class EventForm : Form
			{
				// Constructors(Parameters)
				public EventForm()
					{
						InitializeComponent();
					}
					
				// Methods(Parameters)
				private void EventForm_Load(object sender, EventArgs e)
					{
						DateTextbox.Text = $"{MainForm.static_month}/{UserControlDays.static_day}/{MainForm.static_year}";
					}

				private void SaveButton_Click(object sender, EventArgs e)
					{
						using (SqlConnection connection = new SqlConnection(@"Data Source=ROB-DESKTOP\SQLEXPRESS;Initial Catalog=Calendar;Integrated Security=True"))  // Create a connectionstring
							{
								connection.Open();
								SqlCommand command = connection.CreateCommand();
								command.CommandText = $"INSERT INTO Events (date,event) VALUES (@date,@event)";
								command.Parameters.AddWithValue("@date", DateTextbox.Text);
								command.Parameters.AddWithValue("@event", EventTextbox.Text);
								command.ExecuteNonQuery();
								MessageBox.Show("Event saved successfully");
							}
					}
			}
	}
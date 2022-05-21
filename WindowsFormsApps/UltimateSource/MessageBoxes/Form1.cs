using System.Windows.Forms;

namespace MessageBoxes
	{
		public partial class Form1 : Form
			{
				public Form1()
					{
						InitializeComponent();
					}

				// Other Button Events:
				// MouseHover
				private void btnMessage_Click(object sender, System.EventArgs e)
					{
						MessageBox.Show("Hello World!");
					}

				private void btnMessageTitle_Click(object sender, System.EventArgs e)
					{
						MessageBox.Show("Hello World!", "Message Title");
					}

				private void btnStringVariable_Click(object sender, System.EventArgs e)
					{
						string userName = "Rob";
						
						MessageBox.Show(userName);
					}

				private void btnIntVariable_Click(object sender, System.EventArgs e)
					{
						// Other Data types:
						// bool variableName = true or false
						// object variableName = any data type value
						int userAge = 36;

						MessageBox.Show(userAge.ToString());
					}
			}
	}
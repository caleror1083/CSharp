// Robert Calero
// Login Form - C# - Windows Form Application .NET Framework

using System;
using System.Windows.Forms;

namespace Login
	{
		public partial class Main : Form
			{
				public Main()
					{
						InitializeComponent();
					}

				private void MainButtonExit_Click(object sender, EventArgs e)
					{
						Application.Exit();
					}
			}
	}
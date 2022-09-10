using System;
using System.Windows.Forms;

namespace Properties
	{
		public partial class Form1 : Form
			{
				public Form1()
					{
						InitializeComponent();
					}

				private void btnText_Click(object sender, EventArgs e)
					{
						btnText.Text = "Any string";
					}

				private void btnEnabled_Click(object sender, EventArgs e)
					{
						btnEnabled.Enabled = false;
					}

				private void btnHeight_Click(object sender, EventArgs e)
					{
						btnHeight.Height = 25;
					}

				private void btnTextBox_Click(object sender, EventArgs e)
					{
						txtTextBox.Text = "Any String in TextBox";
					}
			}
	}
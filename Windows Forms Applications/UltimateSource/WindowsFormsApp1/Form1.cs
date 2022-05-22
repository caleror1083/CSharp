using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int num1;
		int num2;
		int sum;

		private void Form1_Load(object sender, EventArgs e)
		{
			lblNum1.Text = "Enter 1st number:";
			txtNum2.Visible = false;
			txtSum.Visible = false;
			btnExit.Visible = false;
		}

		private void txtNum1_TextChanged(object sender, EventArgs e)
		{
			num1 = Convert.ToInt32(txtNum1.Text);

			lblNum2.Text = "Enter 2nd number:";
			txtNum2.Visible = true;
		}

		private void txtNum2_TextChanged(object sender, EventArgs e)
		{
			num2 = Convert.ToInt32(txtNum2.Text);

			lblSum.Text = "The sum is: ";

			sum = Convert.ToInt32(num1 + num2);

			txtSum.Visible = true;
			txtSum.Enabled = false;
			txtSum.Text = (sum.ToString());
		}

		private void txtSum_TextChanged(object sender, EventArgs e)
		{
			lblExit.Text = "Click the Exit button to exit!";
			btnExit.Visible = true;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
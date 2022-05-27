using System.Threading;
using System.Windows.Forms;

namespace _001_Multithreading
	{
		public partial class MainForm : Form
			{
				public MainForm()
					{
						InitializeComponent();
					}

				private void TimeConsumingButton_Click(object sender, System.EventArgs e)
					{
						TimeConsumingButton.Enabled = false;
						PrintButton.Enabled = false;
						
						Thread workerThread = new Thread(DoTimeConsumingWork);
						workerThread.Start();

						TimeConsumingButton.Enabled = true;
						PrintButton.Enabled = true;
					}

				private void DoTimeConsumingWork()
					{
						Thread.Sleep(5000);
					}

				private void PrintButton_Click(object sender, System.EventArgs e)
					{
						for (int i = 1; i <= 10; i++)
							{
								NumbersListbox.Items.Add(i);
							}
					}
			}
	}
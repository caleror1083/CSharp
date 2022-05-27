using System.Windows.Forms;

namespace AddressBook
	{
		internal static class Program
			{
				static void Main()
					{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						Application.Run(new MainForm());
					}
			}
	}
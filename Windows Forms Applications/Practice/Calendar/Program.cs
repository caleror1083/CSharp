using System.Windows.Forms;

// Namespaces
namespace Calendar
	{
		// Classes
		static class Program
			{
				// Methods(Parameters)
				static void Main()
					{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						Application.Run(new MainForm());
					}
			}
	}
/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using System.Windows.Forms;

// Namespaces
namespace SoftwareCompanySchedulingApp
    {
		// Classes
	    static class Program
			{
				// Methods(Parameters)
				static void Main()
					{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						Application.Run(new Login());
					}
			}
	}
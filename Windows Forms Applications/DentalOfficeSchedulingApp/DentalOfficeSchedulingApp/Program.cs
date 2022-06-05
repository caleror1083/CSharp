// 	C868 Software Development Capstone - Robert Calero - Student ID# 000998416
using System.Windows.Forms;

// Namespaces
namespace DentalOfficeSchedulingApp
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
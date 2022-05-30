/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using System.Windows.Forms;

namespace SoftwareCompanySchedulingApp
    {
	    static class Program
			{
				static void Main()
					{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						Application.Run(new Login());
					}
			}
	}
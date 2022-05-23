/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using System;
using System.Windows.Forms;

namespace SoftwareCompanySchedulingApp
    {
	    static class Program
			{
				/// <summary>
				/// The main entry point for the application.
				/// </summary>
				[STAThread]
				static void Main()
					{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						Application.Run(new Login());
					}
			}
	}
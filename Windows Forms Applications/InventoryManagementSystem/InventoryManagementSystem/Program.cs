/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
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
						Application.Run(new MainScreen());
					}
			}
	}
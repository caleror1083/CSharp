// C968 Software I - C# - Robert Calero - Student ID# 000998416

using System.Windows.Forms;

namespace InventoryManagementSystem
	{
		class Program
			{
				static void Main()
					{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						Application.Run(new MainScreen());
					}
			}
	}
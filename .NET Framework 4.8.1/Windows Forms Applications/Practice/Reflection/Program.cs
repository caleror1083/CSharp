using System.Windows.Forms;

namespace Reflection
	{
		internal static class Program
			{
				static void Main()
					{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						Application.Run(new Examples());
					}
			}
	}
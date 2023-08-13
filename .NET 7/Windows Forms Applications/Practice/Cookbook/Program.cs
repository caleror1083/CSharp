// Robert Calero - App displays cookbook recipes
using System.Windows.Forms;

namespace Cookbook;

internal static class Program
{
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new MainForm());
	}
}
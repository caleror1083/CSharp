// Robert Calero
// Tic Tac Toe - C# - Windows Form Application .NET Framework

using System.Windows.Forms;

namespace TicTacToe
	{
		static class Program
			{
		
				static void Main()
					{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						Application.Run(new GameBoard());
					}
			}
	}
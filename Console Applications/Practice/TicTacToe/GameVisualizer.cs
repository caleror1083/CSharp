// Robert Calero - App displaying Tic Tac Toe Game

using System;

class GameVisualizer
	{
		public void PrintBoard(string[,] argTicTacToeBoard)
			{
				for (int i = 0; i < argTicTacToeBoard.GetLength(0); i++)
					{
						for (int j = 0; j < argTicTacToeBoard.GetLength(0); j++)
							{
								Console.Write(argTicTacToeBoard[i, j]);
							}
						Console.WriteLine();
					}
			}

		public void InitializeBoard(string[,] argTicTacToeBoard)
			{
				for (int i = 0; i < argTicTacToeBoard.GetLength(0); i++)
					{
						for (int j = 0; j < argTicTacToeBoard.GetLength(0); j++)
							{
								argTicTacToeBoard[i, j] = " ";
							}
					}
			}				
	}
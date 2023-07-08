// Robert Calero - App displaying Tic Tac Toe Game
class GameEngine    // Class declaration
	{
		public static string CheckForWinner(string[,] argTicTacToeBoard, string currentPlayer)
			{
				var horizontalWin = 0;
				var verticalWin = 0;
				var diagonalWin = 0;

				for (var i = 0; i < argTicTacToeBoard.GetLength(0); i++)
					{
						if (horizontalWin == 3)
							{
								break;
							}
						else
							{
								horizontalWin = 0;
							}

						for (var j = 0; j < argTicTacToeBoard.GetLength(0); j++)
							{
								if (argTicTacToeBoard[i, j].Equals(currentPlayer))
									{
										horizontalWin++;
									}
							}
					}

				for (var i = 0; i < argTicTacToeBoard.GetLength(0); i++)
					{
						if (verticalWin == 3)
							{
								break;
							}
						else
							{
								verticalWin = 0;
							}

						for (var j = 0; j < argTicTacToeBoard.GetLength(0); j++)
							{
								if (argTicTacToeBoard[j, i].Equals(currentPlayer))
									{
										verticalWin++;
									}
							}
					}

				for (var i = 0; i < argTicTacToeBoard.GetLength(0); i++)
					{
						if (argTicTacToeBoard[i, i].Equals(currentPlayer))
							{
								diagonalWin++;
							}								
					}
				if (diagonalWin != 3)
					{
						diagonalWin = 0;
						for (var i = 0; i < argTicTacToeBoard.GetLength(0); i++)
							{
								if (argTicTacToeBoard[(argTicTacToeBoard.GetLength(0) - 1) - i, (argTicTacToeBoard.GetLength(0) - 1) - i].Equals(currentPlayer))
									{
										diagonalWin++;
									}
							}
					}
				return horizontalWin == 3 || verticalWin == 3 || diagonalWin == 3 ? currentPlayer : string.Empty;
			}
	}
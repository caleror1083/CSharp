// Robert Calero - App displaying Tic Tac Toe Game

class AIPlayer : IPlayer
	{
		private string player;

		public string GetPlayer()
			{
				return player;
			}

		public void SetPlayer(string player)
			{
				this.player = player;
			}

		public void Play(string [,] argTicTacToeBoard)
			{
				for (int i = 0; i < argTicTacToeBoard.GetLength(0); i++)
					{
						for (int j = 0; j < argTicTacToeBoard.GetLength(0); j++)
							{
								if (argTicTacToeBoard[i, j].Equals(" "))
									{
										argTicTacToeBoard[i, j] = player;
										return;
									}
							}
					}
			}
	}
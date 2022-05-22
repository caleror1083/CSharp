// Robert Calero - App displaying Tic Tac Toe Game

using System;

class RealPlayer : IPlayer
	{
		public string player;	

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
				Console.Write($"Enter grid position X for {player}: ");
				int positionX = int.Parse(Console.ReadLine());

				Console.Write($"Enter grid position Y for {player}: ");
				int positionY = int.Parse(Console.ReadLine());

				if (argTicTacToeBoard[positionX, positionY].Equals(" "))
					{		
						argTicTacToeBoard[positionX, positionY] = player;
					}
			}
	}
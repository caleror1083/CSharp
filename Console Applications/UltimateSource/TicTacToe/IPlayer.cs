// Robert Calero - App displaying Tic Tac Toe Game

interface IPlayer
	{
		string GetPlayer();
		void Play(string[,] argTicTacToeBoard);
		void SetPlayer(string player);
	}
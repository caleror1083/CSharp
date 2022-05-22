// Robert Calero - App displaying Tic Tac Toe Game
using System;

class GameUI
	{
		public void GameBoard()
			{
				IPlayer player1;
				IPlayer player2;
				string[,] TicTacToeBoard = new string[3, 3];
				GameEngine myEngine = new GameEngine();
				GameVisualizer myVisualizer = new GameVisualizer();
				GameManager myGame = new GameManager(myVisualizer, myEngine);

				while (true)
					{
						Console.Write("Choose playing mode - 2PLAYER or AI? ");
						var mode = Console.ReadLine().ToUpper();

						if (mode.Equals("2PLAYER"))
							{
								player1 = new RealPlayer();
								player2 = new RealPlayer();    // Polymorphism
								break;
							}
						else if (mode.Equals("AI"))
							{
								player1 = new RealPlayer();
								player2 = new AIPlayer();
								break;
							}
					}

				myGame.PlayGame(TicTacToeBoard, player1, player2);
			}
	}
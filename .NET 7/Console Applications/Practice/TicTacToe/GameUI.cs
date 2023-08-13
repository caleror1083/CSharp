using System;

namespace TicTacToe;

internal class GameUI
	{
		public static void GameBoard()
			{
				IPlayer player1;
				IPlayer player2;
				var TicTacToeBoard = new string[3, 3];

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
                GameManager.PlayGame(TicTacToeBoard, player1, player2);
                Console.ReadKey();
			}
	}
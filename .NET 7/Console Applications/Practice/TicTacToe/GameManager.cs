using System;

namespace TicTacToe;

class GameManager
	{
		public static void PlayGame(string[,] argTicTacToeBoard, IPlayer argPlayer1, IPlayer argPlayer2)
			{
                GameVisualizer.InitializeBoard(argTicTacToeBoard);

				Console.Write("Player1, Do you want to be X or O? ");
				while (true)
					{
						var player1Name = Console.ReadLine().ToUpper();
						if (player1Name.ToUpper().Equals("X") || player1Name.ToUpper().Equals("O"))
							{
								argPlayer1.SetPlayer(player1Name);
								break;
							}
					}
				argPlayer2.SetPlayer(argPlayer1.GetPlayer().ToUpper().Equals("X") ? "O" : "X");

				var winner = string.Empty;
				var currentPlayer = argPlayer1;

				while (winner.Equals(string.Empty))
					{
						argPlayer1.Play(argTicTacToeBoard);
						argPlayer2.Play(argTicTacToeBoard);
                        GameVisualizer.PrintBoard(argTicTacToeBoard);
						winner = GameEngine.CheckForWinner(argTicTacToeBoard, currentPlayer.GetPlayer());
						currentPlayer = currentPlayer.Equals(argPlayer1) ? argPlayer2 : argPlayer1;
					}
				Console.WriteLine($"The winner is {winner}");
			}
	}
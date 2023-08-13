using System;
using System.Threading;

namespace Dice;

internal class Game
{
    public static void RollDice()
    {
        var playerScore = 0;
        var cpuScore = 0;
        var tieScore = 0;
        var die = new Random();

        for (var round = 1; round < 4; round++)
        {
            Console.Write($"Round {round} ROLL!");
            Console.ReadKey();

            var playerDie = die.Next(1, 7);
            Console.WriteLine($"You rolled a {playerDie}");

            Console.WriteLine($"...");
            Thread.Sleep(1000);

            var cpuDie = die.Next(1, 7);
            Console.WriteLine($"AI rolled a {cpuDie}");

            if (playerDie > cpuDie)
            {
                playerScore++;
                Console.WriteLine($"You won round {round}");
            }
            else if (playerDie < cpuDie)
            {
                cpuScore++;
                Console.WriteLine($"You lost round {round}");
            }
            else
            {
                tieScore++;
                Console.WriteLine($"Round {round} is a tie");
            }

            Console.WriteLine($"Player {playerScore} | CPU {cpuScore} | Tie {tieScore}");
			Console.Write("Loading next round...");
			Thread.Sleep(5000);
			Console.Clear();
        }

        if (playerScore > cpuScore)
		{
			Console.WriteLine("You win");
		}
		else if (playerScore < cpuScore)
		{
			Console.WriteLine("You lose");
		}
		else
		{
			Console.WriteLine("Draw");
		}
    }
}
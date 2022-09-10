using System;

class Example
	{
		public void Results()
			{
				Console.WriteLine("Example 1:");
				string name;

				Console.Write("What is your name? ");
				name = Console.ReadLine();

				Console.WriteLine("Your name spelled vertically is");
				foreach (char letterCharacter in name)
					{
						Console.WriteLine(letterCharacter);
					}
				Console.ReadKey();
			}
	}
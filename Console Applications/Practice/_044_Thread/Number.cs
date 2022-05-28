using System;

namespace _044_Thread
	{
		internal class Number
			{
				public static void PrintNumbers()
					{
						for (int i = 1; i <= 10; i++)  // Print numbers from 1-10
							{
								Console.WriteLine(i);
							}
					}

				public static void PrintTargetNumbers(object target)
					{
						if (int.TryParse(target.ToString(), out int number))
							{
								for (int i = 1; i <= number; i++)
									{
										Console.WriteLine(i);  // Prints the target number entered by the user via for loop
									}
							}
					}
			}
	}
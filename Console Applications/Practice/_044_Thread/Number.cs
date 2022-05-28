using System;

namespace _044_Thread
	{
		internal class Number
			{
				// Fields
				private readonly int _Target; // Data that the thread method requires

				// Constructors
				public Number(int target)
					{
						_Target = target;
					}

				public static void PrintNumbers()
					{
						for (int i = 1; i <= 10; i++)  // Print numbers from 1-10
							{
								Console.WriteLine(i);
							}
					}

				public static void PrintTargetNumbers(object target)  // Non Type Safe manner using ParameterizedThreadStart
					{
						if (int.TryParse(target.ToString(), out int number))
							{
								for (int i = 1; i <= number; i++)
									{
										Console.WriteLine(i);  // Prints the target number entered by the user via for loop
									}
							}
					}

				public void PrintTargetNumbersSafe()  // Using Type Safe manner - Thread method
					{
						for (int i = 1; i <= _Target; i++)
							{
								Console.WriteLine(i);
							}
					}
			}
	}
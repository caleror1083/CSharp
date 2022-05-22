using System;
using System.Collections;

class Example
	{
		readonly private static int[] integerValues = { 1, 2, 3, 4, 5, 6 };
		private static int[] integerValuesCopy;

	public void Result()
			{
				integerValuesCopy = new int[integerValues.Length];    // defaults to zeros

				Console.WriteLine("Initial array values");
				PrintArrays();

				// copy integerValues into integerValuesCopy
				Array.Copy(integerValues, integerValuesCopy, integerValues.Length);

				Console.WriteLine();
				Console.WriteLine("Array values after copy");
				PrintArrays();
			}

	public static void PrintArrays()
		{
			Console.Write("integerValues: ");

			// iterate through the int array with an enumerator
			IEnumerator enumerator = integerValues.GetEnumerator();

			while (enumerator.MoveNext())
				{
					Console.Write($"{enumerator.Current} ");
				}
			Console.Write("\nintegerValuesCopy: ");

			// iterate through the second int array with a foreach statement
			foreach (var element in integerValuesCopy)
				{
					Console.Write($"{element} ");
				}
			Console.WriteLine();
		}
	}
using System;
using System.Collections.Generic;
using System.Linq;

public class Example
	{
		public void Result()
			{
				int[] array1 = { 3, 5, 7, 8, 9, 11, 16, 19, 23, 26 };    // Declare an integer array

				//LINQ Query to retrieve a range of values from array
				var NumRange = array1.Where(index => index > 8 && index < 23);

				foreach (var numbers in NumRange)
					{
						Console.WriteLine(numbers);
					}
			}
	}
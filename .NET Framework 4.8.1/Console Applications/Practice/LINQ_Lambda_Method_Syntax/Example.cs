using System;
using System.Collections.Generic;
using System.Linq;

public class Example
	{
		public void Result()
			{
				int[] numbersArray = { 3, 5, 7, 8, 9, 11, 16, 19, 23, 26 };    // Declare an integer array

				//LINQ Query to retrieve a range of values from array
				IEnumerable<int> NumRange = numbersArray
				                            .Where(index => index > 8 && index < 23);

				foreach (var numbers in NumRange)
					{
						Console.WriteLine(numbers);
					}

										string word = "top";

						// splits the string into substrings that are based on the characters in an array
						string result = string.Join(" ", word
						    .Split(' ')
							.Select(x => new string(x.Reverse().ToArray())));
						Console.WriteLine(result);
			}
	}
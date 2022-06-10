using System;

class Example
	{
		public void Results()
			{
				Console.WriteLine("Example 1:");
				int i;

				for (i = 1; i <= 10; i++)  // printing ascending values 1-10 from an Integer type
					{
						Console.WriteLine(i);
					}
				Console.WriteLine();

				Console.WriteLine("Example 2:");
				int a;

				for (a = 10; a >= 1; a--)  // printing decending values 1-10 from an Integer type
					{
						Console.WriteLine(a);
					}
				Console.Write("HAPPY NEW YEAR!");
				Console.WriteLine("\n");

				Console.WriteLine("Example 3:");  // This for loop prints out 1-10 on 1 line
				int b;

				for (b = 1; b <= 10; b++)
					{
						Console.Write($"{b} ");
					}
				Console.WriteLine("\n");

				Console.WriteLine("Example 4:");  // This for loop varies the control variable over the sequence 2-20 with increments of 3
				int c;

				for (c = 2; c <= 20; c += 3)
					{
						Console.Write($"{c} ");
					}
				Console.WriteLine("\n");

				Console.WriteLine("Example 5:");  // This for loop gives the sum the even integers from 2 to 20
				int totalSum = 0;
				int number;

				for (number = 2; number <= 20; number += 2)
					{
						totalSum += number;
					}
				Console.WriteLine($"Sum is {totalSum}");
				Console.WriteLine();

				Console.WriteLine("Example 6");    // Compound-interest calculations with for
				decimal principal = 1000;    // initial amount before interest
				decimal amount;
				double rate = 0.05;    // interest rate

				Console.WriteLine("Year Amount on deposit");    // display headers

				for (int year = 1; year <= 10; ++year)    // calculate amount on deposit for each of ten years 
					{
						amount = principal * ((decimal) Math.Pow(1.0 + rate, year));    // calculate new amount for specified year 

						Console.WriteLine($"{year, -4} {amount:C}");    // display the year and the amount, the integer after the comma indicates that the value output should be displayed with a field width right-aligned, negative value is left-aligned
					}
				Console.WriteLine();

				Console.WriteLine("Example 7");    // break statement exiting a for statement.
				int count; // control variable also used after loop terminates

				for (count = 1; count <= 10; ++count) // loop 10 times
					{
						Console.Write($"{count} ");
						if (count == 5) // if count is 5, 
							{
								break; // terminate loop
							}
					}
				Console.WriteLine($"\nBroke out of loop at count = {count}");
				Console.WriteLine();

				Console.WriteLine("Example 8");    // continue statement skipping an iteration of a for statement.
				for (int count1 = 1; count1 <= 10; ++count1)
					{
						if (count1 == 5)	// if count is 5, 
							{
								continue;	// skip remaining code in loop
							}
						Console.Write($"{count1} ");
					}
				Console.WriteLine("\nUsed continue to skip displaying 5");
				Console.WriteLine();

				Console.WriteLine("Example 9: Printing even numbers to 10 using continue");
				for (int coun = 1; coun <= 10; coun++)
					{
						if (coun % 2 == 1) // value is odd number skip displaying it
							{
								continue;	// skip remaining code in loop
							}
						Console.Write($"{coun} ");
					}
				Console.WriteLine("\nUsed continue to skip displaying odd numbers");
				Console.WriteLine();

				Console.WriteLine("Example 10");
				string name;

				Console.Write("What is your name? ");
				name = Console.ReadLine();

				Console.WriteLine("Your name spelled vertically is");
				for (int index = 0; index < name.Length; index++)
					{
						Console.WriteLine(name[index]);
					}
				Console.WriteLine();

				Console.WriteLine("Example 11: Nested loops using for loops");
				int rows;
				int columns;
				string symbol;

				Console.Write("How many columns for your rectangle? ");
				columns = int.Parse(Console.ReadLine());

				Console.Write("How many rows for your rectangle? ");
				rows = int.Parse(Console.ReadLine());

				Console.Write("What symbol will be used? ");
				symbol = Console.ReadLine();

				for (int indexOut = 0; indexOut < rows; indexOut++)
					{
						for (int indexIn = 0; indexIn < columns; indexIn++)
							{
								Console.Write($"{symbol}");
							}
						Console.WriteLine();
					}
				Console.WriteLine();

				Console.WriteLine("Example 12: Random Integers");
				Random randomNumbers = new Random(); // random-number generator

				for (int counter = 1; counter <= 20; ++counter)      // loop 20 times
					{
						int face = randomNumbers.Next(1, 7);		// pick random integer from 1 to 6
						Console.Write($"{face} ");					// display generated value
					}
				Console.WriteLine();

				Console.WriteLine("Example 13: Random");
				Random randomNumbers2 = new Random();				// random-number generator

				int frequency1 = 0;									// count of 1s rolled
				int frequency2 = 0;									// count of 2s rolled
				int frequency3 = 0;									// count of 3s rolled
				int frequency4 = 0;									// count of 4s rolled
				int frequency5 = 0;									// count of 5s rolled
				int frequency6 = 0;									// count of 6s rolled
				int roll;
				int face2;

				for (roll = 1; roll <= 10; ++roll)			// summarize results of 60,000,000 rolls of a die
					{
						face2 = randomNumbers2.Next(1, 7);			// number from 1 to 6

						switch (face2)								// determine roll value 1-6 and increment appropriate counter
							{
								case 1:
									++frequency1;					// increment the 1s counter
									break;
								case 2:
									++frequency2;					// increment the 2s counter
									break;
								case 3:
									++frequency3;					// increment the 3s counter
									break;
								case 4:
									++frequency4;					// increment the 4s counter
									break;
								case 5:
									++frequency5;					// increment the 5s counter
									break;
								case 6:
									++frequency6;					// increment the 6s counter
									break;
							} 
						} 
				Console.WriteLine("Face\tFrequency"); // output headers
				Console.WriteLine($"1\t{frequency1}\n2\t{frequency2}");
				Console.WriteLine($"3\t{frequency3}\n4\t{frequency4}");
				Console.WriteLine($"5\t{frequency5}\n6\t{frequency6}");

				Console.WriteLine();

				Console.WriteLine("Example 14: Star Pattern");
				int ab = 1;
				int spaces;
				int k = 6;
				int ib = 0;
				int jb = 0;

				spaces = k - 1;

				for (ib = 1; ib < k * 2; ib++)
					{
						for (jb = 1; jb <= spaces; jb++)
							{
								Console.Write(" ");
							}
						for (jb = 1; jb < ab * 2; jb++)
							{
								Console.Write("*");
							}
						Console.WriteLine("");
						 
						if (ib < k)
							{
								spaces--;
								ab++;
							}
						else
							{
								spaces++;
								ab--;
							}
					}

				Console.WriteLine();

				Console.WriteLine("Example 15: Random For Loop Examples");
                int x;                                  // Variable declaration of type int
                int int2 = 0;                           // Variable declaration and initialization of type int
                int y;                                  // Variable declaration of type int
                string guess;                           // Variable declaration of type string
                string myName = "Rob";    // Variable declaration and initialization of type string

                // For loop
                for (x = 1; x <= 5; x++)
                    {
                        Console.WriteLine("This for loop is at iteration: " + x);
                    }

                Console.WriteLine(); // Writes a blank line to the console

                // Exit the For loop before it is finished
                for (x = 1; x <= 5; x++)
                    {
                        Console.WriteLine("This for loop is at iteration: " + x);
                        if (x == 3)
                            {
                                break;
                            }
                    }

                Console.WriteLine(); // Writes a blank line to the console

                // Continue statement
                for (x = 1; x <= 10; x++)
                    {
                        if (x == 5)
                        {
                            Console.WriteLine("The number equals: " + x);
                            continue;
                        }
                    }

                Console.WriteLine(); // Writes a blank line to the console

                // For loop with Step Operator
                for (x = 0; x <= 20; x += 5)
                    {
                        Console.WriteLine("The number equals: " + x);
                    }

                Console.WriteLine(); // Writes a blank line to the console

                for (x = 1; x <= 10; x++)
                    {
                        for (y = 1; y <= 5; y++)
                            {
                                Console.Write(y);
                            }
                        Console.WriteLine();
                    }

                Console.WriteLine(); // Writes a blank line to the console

                // Foreach loop
                foreach (char ch in myName)
                    {
                        Console.WriteLine(ch);
                    }

                // Do While loop aka Do Until in VB
                do
                    {
                        Console.WriteLine("The number equals: " + int2);
                        int2 += 1;
                    }
                while (int2 == 10);

                Console.WriteLine(); // Writes a blank line to the console

                // Exit the Do loop
                do
                    {
                        if (int2 == 5)
                            {
                                Console.WriteLine("The number equals: " + int2);
                                int2 += 1;
                                break;
                            }
                    }
                while (int2 == 10);

                Console.WriteLine(); // Writes a blank line to the console

                // While loop aka Do While in VB
                while (int2 <= 15)
                    {
                        Console.WriteLine("The number equals: " + int2);
                        int2 += 1;
                    }

                Console.WriteLine(); // Writes a blank line to the console

                do
                    {
                        Console.Write("Guess a number from 1 to 20: ");
                        guess = Console.ReadLine();
                    }
                while (!guess.Equals("17"));

				Console.WriteLine("Example 16: Random For Loop Examples");
				// Write a program that prints the first 100 members of the sequence: 2, -3, 4, -5, 6
               for (int i = 2; i < 101; i++)
					{
						if (i % 2 == 0)
						{
							Console.WriteLine(i);
						}
            
						else
						{
							Console.WriteLine(-i);
						}
					}

			}
	}
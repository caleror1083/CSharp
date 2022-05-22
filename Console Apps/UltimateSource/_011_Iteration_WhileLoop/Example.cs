// Robert Calero - App displaying while loops
using System;

class Example
	{
		public void Results()
			{
				Console.WriteLine("Example 1: Outputs even numbers based on the value the user enters ");
				int UserTarget;
				int Start = 0;

				Console.Write("Please enter your target number? ");
				UserTarget = int.Parse(Console.ReadLine());

				while (Start <= UserTarget)
					{
						Console.Write($"{Start} ");
						Start += 2;
					}
				Console.WriteLine("\n");

				Console.WriteLine("Example 2: Outputs the values 1-10 on each line");
				int counter = 1;

				while (counter <= 10)
					{
						Console.WriteLine(counter);
						counter++;
					}
				Console.WriteLine();

				Console.WriteLine("Example 3: Outputs the name entered by the user");
				string name = "";

				while (name == "")
					{
						Console.Write("Enter your name: ");
						name = Console.ReadLine();
					}
				Console.WriteLine($"Hello {name}");
				Console.WriteLine();

				Console.WriteLine("Example 4: ");    // Solving the class-average problem using sentinel-controlled iteration.
				int grade;
				int total = 0;    // initialize sum of grades
				int gradeCounter = 0;    // initialize the number of grades entered so far
				double average;						

				Console.Write("Enter grade or -1 to quit: ");    // prompt for input and read grade from user
				grade = int.Parse(Console.ReadLine());

				while (grade != -1)    // loop until sentinel value is read from the user
					{
						total += grade;    // add grade to total
						gradeCounter++;    // increment counter

						Console.Write("Enter grade or -1 to quit: ");	// prompt for input and read grade from user
						grade = int.Parse(Console.ReadLine());
					}

				if (gradeCounter != 0)    // if the user entered at least one grade...
					{
						average = (double)total / gradeCounter;    // use number with decimal point to calculate average of grades

						// display the total and average (with two digits of precision)
						Console.WriteLine($"\nTotal of the {gradeCounter} grades entered is {total}");
						Console.WriteLine($"Class average is {average:F1}");
					}
				else    // no grades were entered, so output error message
					{
						Console.Write("No grades were entered");
					}
				Console.WriteLine("\n");

				Console.WriteLine("Example 5: ");    // Analysis of examination results, using nested control statements.    
				int passes = 0; // number of passes       
				int failures = 0; // number of failures   
				int studentCounter = 1; // student counter

				// process 3 students using counter-controlled iteration
				while (studentCounter <= 3)
					{
						// prompt user for input and obtain a value from the user
						Console.Write("Enter result (1 = pass, 2 = fail): ");
						int result = int.Parse(Console.ReadLine());

						// if...else is nested in the while statement           
						if (result == 1)
							{
							passes++; // increment passes      
							}
						else
							{
							failures++; // increment failures
							}

						// increment studentCounter so loop eventually terminates
						studentCounter++;
					} 
				Console.WriteLine($"Passed: {passes}\nFailed: {failures}");

				// determine whether more than 8 students passed
				if (passes > 2)
					{
						Console.WriteLine("Bonus to instructor!");
					}
				Console.WriteLine();

				Console.WriteLine("Example 6: ");
				int counter1 = 0;
				int grade1;
				int total1 = 0;
				double average1;

				while (counter1 < 3)
					{
						Console.Write("Enter your grade: ");
						grade1 = Convert.ToInt32(Console.ReadLine());
						total1 += grade1;
						counter1++;
					}
				average1 = total1 / 3;

				Console.WriteLine($"Your average is {average1}");
				Console.WriteLine();

				Console.WriteLine("Example 7: ");
				int sum = 0; // initialize sum to 0 for totaling
				int x = 1; // initialize x to 1 for counting

				while (x <= 10) // while x is less than or equal to 10      
					{
						sum += x;
						++x;
					}
				Console.WriteLine($"The sum is: {sum}");
				Console.WriteLine();

				Console.WriteLine("Example 8: Using a switch statement to count letter grades.");
				int total2 = 0; // sum of grades                  
				int gradeCounter2 = 0; // number of grades entered
				int aCount = 0; // count of A grades             
				int bCount = 0; // count of B grades             
				int cCount = 0; // count of C grades             
				int dCount = 0; // count of D grades             
				int fCount = 0; // count of F grades
				string input;

				Console.WriteLine("Enter the integer grades in the range 0-100.");
				Console.WriteLine("Type <Ctrl> z and press Enter to terminate input:");

				input = Console.ReadLine(); // read user input

				while (input != null)	// loop until user enters the end-of-file indicator (<Ctrl> z)
					{
						int grade2 = int.Parse(input); // read grade off user input
						total2 += grade2; // add grade to total
						++gradeCounter2; // increment number of grades

						// determine which grade was entered     
						switch (grade2 / 10)
							{
								case 9:			// grade was in the 90s       
								case 10:		// grade was 100             
									++aCount;	// increment aCount      
									break;		// necessary to exit switch 
								case 8:			// grade was between 80 and 89
									++bCount;	// increment bCount      
									break;		// exit switch              
								case 7:			// grade was between 70 and 79
									++cCount;	// increment cCount      
									break;		// exit switch              
								case 6:			// grade was between 60 and 69
									++dCount;	// increment dCount      
									break;		// exit switch              
								default:		// grade was less than 60    
									++fCount;	// increment fCount      
									break;		// exit switch              
							}
						input = Console.ReadLine(); // read user input
					}
				Console.WriteLine("\nGrade Report:");

				// if user entered at least one grade...
				if (gradeCounter2 != 0)
					{
						// calculate average of all grades entered
						double average2 = (double)total2 / gradeCounter2;

						// output summary of results
						Console.WriteLine(
						$"Total of the {gradeCounter2} grades entered is {total2}");
						Console.WriteLine($"Class average is {average2:F1}");
						Console.WriteLine("Number of students who received each grade:");
						Console.WriteLine($"A: {aCount}"); // display number of A grades
						Console.WriteLine($"B: {bCount}"); // display number of B grades
						Console.WriteLine($"C: {cCount}"); // display number of C grades
						Console.WriteLine($"D: {dCount}"); // display number of D grades
						Console.WriteLine($"F: {fCount}"); // display number of F grades
					}
				else // no grades were entered, so output appropriate message
					{
						Console.WriteLine("No grades were entered");
					}
				Console.WriteLine();

				Console.WriteLine("Example 9: Guessing game");
				string codeword = "cochino";
				string guess = "";
				int guessCount = 0;
				int guessLimit = 3;
				bool outOfGuesses = false;

				while (guess != codeword && !outOfGuesses)
					{
						if (guessCount < guessLimit)
							{
								Console.Write("Enter guess: ");
								guess = Console.ReadLine();
								guessCount++;
							}
						else
							{
								outOfGuesses = true;
							}
					}

				if (outOfGuesses)
					{
						Console.Write("You lose!");
					}
				else
					{
						Console.Write("You win!");						
					}

				Console.WriteLine("\n");

				Console.WriteLine("Example 10: Rock Paper Scissors Game");
				Random randomRPS = new Random();    // Instance of random object to generate computer's choice
				bool playAgain = true;    // if player decides to continue this will be true
				string answer;    // variable to hold the player's answer if they want to continue
				string playerChoice;    // variable to hold player ones choice
				string computerChoice;    // variable to hold the computers choice

				while (playAgain)    // evaluates if the player wants to continue playing, by default it will be true
					{
						playerChoice = " ";
						computerChoice = " ";

						while (playerChoice != "ROCK" && playerChoice != "PAPER" && playerChoice != "SCISSORS")    // prevents the player to input anything but R, P, S
							{
								Console.Write("Enter ROCK, PAPER or SCISSORS: ");
								playerChoice = Console.ReadLine();    // storing the players input
								playerChoice = playerChoice.ToUpper();    // making the players input all uppercase
							}

						switch (randomRPS.Next(1, 4))    // checks whether the number is between 1-3
							{
								case 1:
									computerChoice = "ROCK";
									break;
								case 2:
									computerChoice = "PAPER";
									break;
								case 3:
									computerChoice = "SCISSORS";
									break;
							}
						Console.WriteLine($"Player: {playerChoice}");
						Console.WriteLine($"Computer: {computerChoice}");

						switch (playerChoice)    // check the players choice against the computers choice to decide winner
							{
								case "ROCK":
									if (computerChoice == "ROCK")
										{
											Console.WriteLine("It's a draw!");
										}
									else if (computerChoice == "PAPER")
										{
											Console.WriteLine("Compter Wins!");
										}
									else
										{
											Console.WriteLine("Player Wins!");
										}
									break;
								case "PAPER":
									if (computerChoice == "ROCK")
										{
											Console.WriteLine("Player Wins!");
										}
									else if (computerChoice == "PAPER")
										{
											Console.WriteLine("It's a draw!");
										}
									else
										{
											Console.WriteLine("Computer Wins!");
										}
									break;
								case "SCISSORS":
									if (computerChoice == "ROCK")
										{
											Console.WriteLine("Computer Wins!");
										}
									else if (computerChoice == "PAPER")
										{
											Console.WriteLine("Player Wins!");
										}
									else
										{
											Console.WriteLine("It's a draw!");
										}
									break;
							}
						Console.Write("Would you like to play again (Y/N)? ");
						answer = Console.ReadLine();
						answer = answer.ToUpper();

						if (answer == "Y")
							{
								Console.WriteLine();
								playAgain = true;
							}
						else
							{
								playAgain = false;
							}
					}
				Console.WriteLine("Thank you for playing!");

			   // ----- WHILE LOOP -----
				// You use the while loop when you want to execute
				// as long as a condition is true

				// This while loop will print odd numbers between
				// 1 and 10
				int r = 1;
				while (r <= 10)
				{
					// % (Modulus) returns the remainder of a
					// division. If it returns 0 that means the
					// value is even
					if (r % 2 == 0)
					{
						r++;

						// Continue skips the rest of the code and 
						// starts execution back at the top of the 
						// while
						continue;
					}

					// Break jumps completely out of the loop
					if (r == 9) break;

					Console.WriteLine(r);
					r++;
				}
				Console.WriteLine();

				Console.WriteLine("Example: Number Guessing Game");
				bool play = true;;
				int minimum = 1;
				int maximum = 100;
				int numberGuessed;
				int number;
				int guesses;
				string response;
				Random randomNumbers = new Random();

				while (play)
					{
						numberGuessed = 0;
						guesses = 0;
						number = randomNumbers.Next(minimum, maximum + 1);

						while (numberGuessed != number)
							{
								Console.Write($"Guess a number between {minimum} - {maximum}: ");
								numberGuessed = int.Parse(Console.ReadLine());
								Console.WriteLine($"Your guess is: {numberGuessed}");

								if (numberGuessed > number)
									{
										Console.WriteLine($"{numberGuessed} is too high");
										Console.WriteLine();
									}
								else if (numberGuessed < number)
									{
										Console.WriteLine($"{numberGuessed} is too low");
										Console.WriteLine();
									}
								guesses++;
							}
						Console.WriteLine($"The number is: {number}");
						Console.WriteLine($"After {guesses} guesses, you finally won!");

						Console.Write("Would you like to play again? - (Y/N): ");
						response = Console.ReadLine();
						response = response.ToUpper();

						if (response == "Y")
							{
								play = true;
							}
						else
							{
								play = false;
							}
					}
				Console.WriteLine("Thank you for playing");
			}
	}
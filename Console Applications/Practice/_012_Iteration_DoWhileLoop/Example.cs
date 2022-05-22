// Robert Calero - App displaying do while loops
using System;

class Example
	{
		public void Results()
			{
				Console.WriteLine("Example 1: ");
				int counter = 1;

				do
					{
						Console.WriteLine(counter);
						counter++;
					}
				while (counter <= 10);
				Console.WriteLine();

				Console.WriteLine("Example 2:");
				int UserTarget;
				string UserChoice;

				do
					{
						Console.Write("Please enter your target? ");
						UserTarget = int.Parse(Console.ReadLine());

						int Start = 0;
						while (Start <= UserTarget)
							{
								Console.Write($"{Start} ");
								Start += 2;
							}
						Console.WriteLine();

						do
							{
								Console.Write("Do you want to continue - Yes or No? ");
								UserChoice = Console.ReadLine().ToUpper();

								if (UserChoice != "YES" && UserChoice != "NO")
									{
										Console.WriteLine("Invalid choice, please say Yes or No");
									}
							}
						while (UserChoice != "YES" && UserChoice != "NO");
					}
				while (UserChoice == "YES");
				Console.WriteLine();

				Console.WriteLine("Example 3:");
				int choice;
				int total = 0;
				string decision;

				do
					{
						do
							{
								Console.Write("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large: ");
								choice = int.Parse(Console.ReadLine());

								switch (choice)
									{
										case 1:
											total += 1;
											break;
										case 2:
											total += 2;
											break;
										case 3:
											total += 3;
											break;
										default:
											Console.WriteLine($"Your choice {choice} is invalid");
											break;
									}
							}
						while (choice != 1 && choice != 2 && choice != 3);
				
						do
							{
								Console.Write("Do you want to buy another coffee? - Yes or No: ");
								decision = Console.ReadLine().ToUpper();

								if (decision != "YES" && decision != "NO")
									{
										Console.WriteLine($"Your choice {decision} is invalid, Please try again");
									}
							}
						while (decision != "YES" && decision != "NO");
					}
				while (decision.ToUpper() != "NO");

				Console.WriteLine();
				Console.WriteLine("Thank you for shopping with us");
				Console.WriteLine($"Bill amount = {total, 4:C}");
				Console.WriteLine();

				Console.WriteLine("Example 4:");
				do
					{
						double number1 = 0;
						double number2 = 0;
						double result = 0;

						Console.WriteLine("------------------");
						Console.WriteLine("Calculator Program");
						Console.WriteLine("------------------");

						Console.Write("Enter number 1: ");
						number1 = double.Parse(Console.ReadLine());

						Console.Write("Enter number 2: ");
						number2 = double.Parse(Console.ReadLine());

						Console.WriteLine("Enter an option: ");
						Console.WriteLine("\t+ : Add");
						Console.WriteLine("\t- : Subtract");
						Console.WriteLine("\t* : Multiply");
						Console.WriteLine("\t/ : Divide");
						Console.Write("Enter an option: ");

						switch (Console.ReadLine())
							{
								case "+":
									result = number1 + number2;
									Console.WriteLine($"Your result: {number1} + {number2} = " + result);
									break;
								case "-":
									result = number1 - number2;
									Console.WriteLine($"Your result: {number1} - {number2} = " + result);
									break;
								case "*":
									result = number1 * number2;
									Console.WriteLine($"Your result: {number1} * {number2} = " + result);
									break;
								case "/":
									result = number1 / number2;
									Console.WriteLine($"Your result: {number1} / {number2} = " + result);
									break;
								default:
									Console.WriteLine("That was not a valid option");
									break;
							}
						Console.Write("Would you like to continue? (Y = yes, N = No): ");
					}
				while (Console.ReadLine().ToUpper() == "Y");
				Console.Write("Bye!");

	           // ----- DO WHILE LOOP -----
            // Use do while when you must execute the code
            // at least once

            // Generate a random number
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;

            do
            {
                Console.Write("Enter a number between 1 & 10 : ");

                // Use Convert to switch the string into an int
                numberGuessed = Convert.ToInt32(Console.ReadLine());
				numberGuessed = int.Parse(Console.ReadLine());  // string to int

            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed it is was {0}", secretNumber);

            // Other Convert options : ToBoolean, ToByte,
            // ToChar, ToDecimal, ToDouble, ToInt64,
            // ToString, and they can convert from any 
            // type to any other type
            Console.WriteLine();

			}
	}
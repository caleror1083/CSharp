// Robert Calero - App displaying IF statements, assignment operator, equality opeators, relational and logical operators
using System;

class Example    // Class declaration - a class defines the variables and methods used by objects
	{
		public void Results()
			{
				             // ----- NULLABLE TYPES -----
            // Data types by default cannot have a
            // value of null. Often null is needed
            // when you are working with databases
            // and you can create a null type by 
            // adding a ? to the definition
            int? randNum = null;

            // Check for null
            if (randNum == null)
            {
                Console.WriteLine("randNum is null");
            }
            Console.WriteLine();

            // Another check for null
            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }
            Console.WriteLine();

				Console.WriteLine("Example 1:");
				bool isMale = true;    // if value is false, else is executed

				if (isMale)
					{
						Console.WriteLine("You are male");
					}
				else
					{
						Console.WriteLine("You are not male");						
					}
				Console.WriteLine();

				Console.WriteLine("Example 2:");
				bool isFemale = true;
				bool isTall = true;

				if (isFemale && isTall)    // if one of the values is false, else is executed
					{
						Console.WriteLine("You are tall female");
					}
				else
					{
						Console.WriteLine("You are either not female, tall or both");						
					}
				Console.WriteLine();

				Console.WriteLine("Example 3:");
				bool isFemale2 = false;
				bool isShort = true;

				if (isFemale2 || isShort)    // if both of the values are false, else is executed
					{
						Console.WriteLine("You are short female");
					}
				else
					{
						Console.WriteLine("You are either not female, short or both");						
					}
				Console.WriteLine();

				Console.WriteLine("Example 4:");
				bool isFemale3 = true;
				bool isShort2 = false;

				if (isFemale3 && isShort2)    // if both of the values are false, else is executed
					{
						Console.WriteLine("You are short female");
					}
				else if (isFemale3 && !isShort2)
					{
						Console.WriteLine("You are a tall female");
					}
				else if (!isFemale3 && isShort2)
					{
						Console.WriteLine("You are tall but you are a male");
					}
				else
					{
						Console.WriteLine("You are not female and not short");						
					}
				Console.WriteLine();

				Console.WriteLine("Example 5:");
				int UserNumber;

				// Accepting value from user
				Console.Write("Please enter a number ");
				UserNumber = int.Parse(Console.ReadLine());

				if (UserNumber == 1)
					{
						Console.WriteLine($"Your number is {UserNumber}");
					}
				else if (UserNumber == 2)
					{
						Console.WriteLine($"Your number is {UserNumber}");
					}
				else if (UserNumber == 3)
					{
						Console.WriteLine($"Your number is {UserNumber}");
					}
				else
					{
						Console.WriteLine("Your number is not between 1 and 3");
					}
				Console.WriteLine();

				Console.WriteLine("Example 6:");
				int number = 10;
				bool is10 = number == 10 ? true : false;    // ternary operator
				
				/*
				bool is10;

				if (number == 10)
					{
						is10 = true;
					}
				else
					{
						is10 = false;
					}
				*/

				Console.WriteLine($"The number 10 is {is10}");
				Console.WriteLine();

				Console.WriteLine("Example 7: Comparing Integers");
				int num1, num2;

				// Accepting values from user
				Console.Write("Enter first number:\t ");
				num1 = int.Parse(Console.ReadLine());

				Console.Write("Enter second number:\t ");
				num2 = int.Parse(Console.ReadLine());

				if (num1 < num2)
					{
						Console.WriteLine($"{num1} is less than {num2}");
					}
				else if (num1 == num2)
					{
						Console.WriteLine($"{num1} is equal to {num2}");
					}
				else
					{
						Console.WriteLine($"{num1} is greater than {num2}");
					}
				Console.WriteLine();

				Console.WriteLine("Example 8: Comparing Integers v2");
				int number1;
				int number2;

				// prompt user and read first number
				Console.Write("Enter first integer: ");
				number1 = int.Parse(Console.ReadLine());

				// prompt user and read second number
				Console.Write("Enter second integer: ");
				number2 = int.Parse(Console.ReadLine());

				if (number1 == number2)                           
					{                                                
						Console.WriteLine($"{number1} == {number2}");
					}                                                

				if (number1 != number2)
					{
					Console.WriteLine($"{number1} != {number2}");
					}

				if (number1 < number2)
					{
					Console.WriteLine($"{number1} < {number2}");
					}

				if (number1 > number2)
					{
					Console.WriteLine($"{number1} > {number2}");
					}

				if (number1 <= number2)
					{
					Console.WriteLine($"{number1} <= {number2}");
					}

				if (number1 >= number2)
					{
					Console.WriteLine($"{number1} >= {number2}");
					}
				Console.WriteLine();

				Console.WriteLine("Example 9:");
				Console.WriteLine(GetMax(20, 10, 5));    // see GetMax method
				Console.WriteLine();

				Console.WriteLine("Example 10:");    // Calculates the cost the user will spend from the number of beers consumed in a year
				const double mpgWalking = 3;
				const double minutesHour = 60;
				double numBeers;
				double price;
				double minWalking = mpgWalking * minutesHour;
				double totalBeers;
				double totalCalories;
				double weightGained;
				double totalPrice;
				double totalBeersLeap; 
				double totalCaloriesLeap;  
				double weightGainedLeap;
				double totalPriceLeap;
				double response;
				double neededToWalk;
				double totalNeededToWalk;
				double totalNeededToWalkLeap;

				Console.Write("On average, how many beers will you consume each day? "); // Writes the string to the console and stays on the same line
				numBeers = Convert.ToDouble(Console.ReadLine()); // gets input from the user

				Console.Write("On average, how much will you pay for each can of beer? "); // Writes the string to the console and stays on the same line
				price = Convert.ToDouble(Console.ReadLine()); // gets input from the user

				Console.Write("On average, how many minutes do you spend walking each day? "); // Writes the string to the console and stays on the same line
				minWalking = Convert.ToDouble(Console.ReadLine()); // gets input from the user

				totalBeers = numBeers * 365; // Calculates the total beers consumed in a year
				totalCalories = totalBeers * 150; // Calculates the total calories consumed in a year
				neededToWalk = 40 / numBeers;
				totalNeededToWalk = totalBeers * 40;
				weightGained = numBeers * 15; // Calculates the weight gained from drinking in a year
				totalPrice = totalBeers * price; // Calculates the total price spent in a year

				totalBeersLeap = numBeers * 366; // Calculates the total beers comsuned in a leap year
				totalNeededToWalkLeap = totalBeersLeap * 40;
				totalCaloriesLeap = totalBeersLeap * 150; // Calculates the total calories consumed in a leap year
				weightGainedLeap = numBeers * 15.04; // Calculates the weight gained from drinking in a leap year
				totalPriceLeap = totalBeersLeap * price; // Calculates the total price spent in a leap year

				Console.WriteLine(" "); // Writes a blank line to the console

				Console.Write("Is it a leap year? (1 = yes, 2 = no) ");
				response = Convert.ToDouble(Console.ReadLine());
				if (response == 1)
					{
						Console.WriteLine("That is approximately " + totalBeersLeap.ToString("F") + " beers in one year"); // Displays the input from the user with 2 digits of precision after the decimal point to the console 
						Console.WriteLine("In one year, you will consume approximately " + totalCaloriesLeap.ToString("F") + " calories from beer alone."); // Displays the input from the user with 2 digits of precision after the decimal point to the console
						Console.WriteLine("Without diet or exercise to counter these calories, you can expect to gain " + weightGainedLeap.ToString("F") + " pounds from drinking that much beer this year."); // Displays the input from the user with 2 digits of precision after the decimal point to the console
						Console.WriteLine("You will spend approximately $" + totalPriceLeap.ToString("F") + " on beer this year."); // Displays the input from the user with 2 digits of precision after the decimal point to the console
						Console.WriteLine("You will need to walk " + totalPrice.ToString("F") + " more minutes to burn all those calories, for a total of " + totalNeededToWalkLeap.ToString("F") + " minutes of walking this year."); // Displays the input from the user with 2 digits of precision after the decimal point to the console
						Console.WriteLine("That amounts to " + totalPrice.ToString("F") + " minutes of walking every day."); // Displays the input from the user with 2 digits of precision after the decimal point to the console
					}
				else
					{
						Console.WriteLine("That is approximately " + totalBeers.ToString("F") + " beers in one year"); // Displays the input from the user with 2 digits of precision after the decimal point to the console
						Console.WriteLine("In one year, you will consume approximately " + totalCalories.ToString("F") + " calories from beer alone."); // Displays the input from the user with 2 digits of precision after the decimal point to the console
						Console.WriteLine("Without diet or exercise to counter these calories, you can expect to gain " + weightGained.ToString("F") + " pounds from drinking that much beer this year."); // Displays the input from the user with 2 digits of precision after the decimal point to the console
						Console.WriteLine("You will spend approximately $" + totalPrice.ToString("F") + " on beer this year."); // Displays the input from the user with 2 digits of precision after the decimal point to the console
						Console.WriteLine("You will need to walk " + neededToWalk.ToString("F") + " more minutes to burn all those calories, for a total of " + totalNeededToWalk.ToString("F") + " minutes of walking this year."); // Displays the input from the user with 2 digits of precision after the decimal point to the console
						Console.WriteLine("That amounts to " + minWalking.ToString("F") + " minutes of walking every day."); // Displays the input from the user with 2 digits of precision after the decimal point to the console
					}
				Console.WriteLine();

				Console.WriteLine("Example 11: Ternary Operator");
				// Decision using ternary operator
				int age;

				Console.Write("How old are you? ");
				age = int.Parse(Console.ReadLine());

				Console.WriteLine(age > 50 ? "You are old" : "You are young"); // ternary operator
				Console.WriteLine();

				Console.WriteLine("Example 12:");
				int age1;
				int studentAge;
				bool hasInsurance;
				string outcomeK;
				string outcomeD;
				string outcomeS;

				// prompt user and read first number
				Console.Write("Enter your age: ");
				studentAge = int.Parse(Console.ReadLine());

				if ((studentAge >= 0) && (studentAge <= 4))
					{
						Console.WriteLine("Go to pre-school");
					}
				else if ((studentAge >= 5) && (studentAge <= 7))
					{
						Console.WriteLine("Go to elementary school");
					}
				else if ((studentAge >= 8) && (studentAge <= 13))
					{
						Console.WriteLine("Go to middle school");
					}
				else if ((studentAge >= 14) && (studentAge <= 17))
					{
						Console.WriteLine("Go to high school");
					}
				else if ((studentAge >= 18) && (studentAge <= 21))
					{
						Console.WriteLine("Go to college");
					}
				else
					{
						Console.WriteLine("You should be working at your age");
					}
				Console.WriteLine();

				Console.WriteLine("Example 13:");
				bool canDrive = studentAge >= 16 ? true : false;
				Console.WriteLine($"Permission to drive: {canDrive}");
				Console.WriteLine();

				Console.WriteLine("Example 14:");
				Console.Write("What is your name? "); // Writes text to the console
				string userName = Console.ReadLine(); // Declare and assign the value entered by the user to the variable

				Console.Write("What is your password? "); // Writes text to the console
				string userPassword = Console.ReadLine(); // Declare and assign the value entered by the user to the variable

				// If Statement
				if (userName == "Rick")
					{
						Console.WriteLine("Welcome " + userName + "!");
					}
				// Else If
				else if (userName == "Glenn")
					{
						Console.WriteLine("Welcome " + userName + "!");
					}
				// Else
				else
					{
						Console.WriteLine("Not a valid user");
					}

				if (userPassword == "Paterson216")
					{
						Console.WriteLine("Welcome");
					}

				// Logical Operators
				if ((userName == "Rob" || userName == "Lance") && (userPassword.Length == 12))
					{
						Console.WriteLine("Yooooo " + userName);
					}
				else
					{
						Console.WriteLine("No access");
					}
				Console.WriteLine(); // Writes a blank line to the console

				Console.Write("What is your age? "); // Writes text to the console
				age1 = Convert.ToInt32(Console.ReadLine());

				Console.Write("Do you have insurance? true/false? "); // Writes text to the console
				hasInsurance = Convert.ToBoolean(Console.ReadLine());

				// Nested If
				if (age1 >= 17)
					{
						if (hasInsurance == true)
							{
								Console.WriteLine("You can drive");
							}
						else
							{
								Console.WriteLine("Watch out!");
							}
					}
				else
					{
						Console.WriteLine("You can't drive");
					}

				// Relational Operators
				if (age1 != 5)
					{
						outcomeK = "You aren't in Kindergarten";
					}
					else
					{
						outcomeK = "You are in Kindergarten";
					}

				if (age1 >= 65)
					{
						outcomeS = "You are a senior";
					}
					else
					{
						outcomeS = "You aren't a senior";
					}

				if (age1 >= 21)
					{
						outcomeD = "You can drink";
					}
					else
					{
						outcomeD = "You can't drink";
					}
				Console.WriteLine(outcomeK + ", " + outcomeD + ", " + outcomeS);
				Console.WriteLine();

				Console.WriteLine("Example 13: Calculator program");
				double num10, num20;
				string op;

				// Accepting values from user
				Console.Write("Enter first number:\t ");
				num10 = double.Parse(Console.ReadLine());    // Assign the value entered to the double variable, Converts the string entered into type double

				Console.Write("Enter operator:\t ");
				op = Console.ReadLine();

				Console.Write("Enter second number:\t ");
				num20 = double.Parse(Console.ReadLine());

				if (op == "+")
					{
						Console.Write(num10 + num20);
					}
				else if (op == "-")
					{
						Console.Write(num10 - num20);
					}
				else if (op == "*")
					{
						Console.Write(num10 * num20);
					}
				else if (op == "/")
					{
						Console.Write((float)num10 / num20);    // typecase operator
					}
				else if (op == "%")
					{
						Console.Write(num10 % num20);
					}
				else
					{
						Console.Write("Invalid operator");
					}
				Console.WriteLine("\n");

				Console.WriteLine("Example 14:");    // logical operators
				// create truth table for && (conditional AND) operator
				Console.WriteLine("Conditional AND (&&)");
				Console.WriteLine($"false && false: {false && false}");
				Console.WriteLine($"false && true: {false && true}");
				Console.WriteLine($"true && false: {true && false}");
				Console.WriteLine($"true && true: {true && true}\n");

				// create truth table for || (conditional OR) operator
				Console.WriteLine("Conditional OR (||)");
				Console.WriteLine($"false || false: {false || false}");
				Console.WriteLine($"false || true: {false || true}");
				Console.WriteLine($"true || false: {true || false}");
				Console.WriteLine($"true || true: {true || true}\n");

				// create truth table for & (boolean logical AND) operator
				Console.WriteLine("Boolean logical AND (&)");
				Console.WriteLine($"false & false: {false & false}");
				Console.WriteLine($"false & true: {false & true}");
				Console.WriteLine($"true & false: {true & false}");
				Console.WriteLine($"true & true: {true & true}\n");

				// create truth table for | (boolean logical inclusive OR) operator
				Console.WriteLine("Boolean logical inclusive OR (|)");
				Console.WriteLine($"false | false: {false | false}");
				Console.WriteLine($"false | true: {false | true}");
				Console.WriteLine($"true | false: {true | false}");
				Console.WriteLine($"true | true: {true | true}\n");

				// create truth table for ^ (boolean logical exclusive OR) operator
				Console.WriteLine("Boolean logical exclusive OR (^)");
				Console.WriteLine($"false ^ false: {false ^ false}");
				Console.WriteLine($"false ^ true: {false ^ true}");
				Console.WriteLine($"true ^ false: {true ^ false}");
				Console.WriteLine($"true ^ true: {true ^ true}\n");

				// create truth table for ! (logical negation) operator
				Console.WriteLine("Logical negation (!)");
				Console.WriteLine($"!false: {!false}");
				Console.WriteLine($"!true: {!true}");

				// To compare strings use Equals
				string name6 = "Derek";
				string name7 = "Derek";

				if (name6.Equals(name7, StringComparison.Ordinal))
				{
					Console.WriteLine("Names are Equal");
				}
				Console.WriteLine();

			}    // end method Results

		// Method for Example 8
		public int GetMax(int num1, int num2, int num3)
			{
				int result;

				if (num1 >= num2 && num1 >= num3)
					{
						result = num1;
					}
				else if (num2 >= num1 && num2 >= num3)
					{
						result = num2;
					}
				else
					{
						result = num3;
					}
				return result;
			}    // end method GetMax
	}    // end class Examples
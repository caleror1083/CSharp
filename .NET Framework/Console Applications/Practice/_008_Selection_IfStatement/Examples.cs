// Robert Calero - App displaying IF statements, assignment operator, equality opeators, relational and logical operators
using System;

// Namespaces
namespace _008_Selection_IfStatement
	{
		class Examples    // Class declaration - a class defines the variables and methods used by objects
			{
				// Methods(Parameters)
				public void ProcessExamples()
					{
						Start:
							Console.Write($"Please select an example from 1-22: ");
							bool check = int.TryParse(Console.ReadLine(), out int choice);

							if (check)
								{
									switch (choice)
										{
											case 1:
												Example1();
												break;
											case 2:
												Example2();
												break;
											case 3:
												Example3();
												break;
											case 4:
												Example4();
												break;
											case 5:
												Example5();
												break;
											case 6:
												Example6();
												break;
											case 7:
												Example7();
												break;
											case 8:
												Example8();
												break;
											case 9:
												Example9();
												break;
											case 10:
												Example10();
												break;
											case 11:
												Example11();
												break;
											case 12:
												Example12();
												break;
											case 13:
												Example13();
												break;
											case 14:
												Example14();
												break;
											case 15:
												Example15();
												break;
											case 16:
												Example16();
												break;
											case 17:
												Example17();
												break;
											case 18:
												Example18();
												break;
											case 19:
												Example19();
												break;
											case 20:
												Example20();
												break;
											case 21:
												Example21();
												break;
											case 22:
												Example22();
												break;
											default:
												Console.WriteLine($"Your choice is invalid");
												goto Start;
										}
								}
							else
								{
									Console.WriteLine($"Selection chosen is incorrect");
									goto Start;
								}

						Decide:
							Console.Write($"Do you want to do another example? - Yes or No: ");
							string decision = Console.ReadLine();
							Console.WriteLine();

							switch (decision.ToUpper())
								{
									case "YES":
										goto Start;
									case "NO":
										break;
									default:
										Console.WriteLine($"Your decision is invalid. Try again");
										goto Decide;
								}
					}	

				static void Example1()
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
					}

				static void Example2()
					{
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
					}

				static void Example3()
					{
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
					}

				static void Example4()
					{
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
					}

				static void Example5()
					{
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
					}

				static void Example6()
					{
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
					}

				static void Example7()
					{
						Console.WriteLine("Example 6:");
						int number = 10;
						bool is10 = number == 10 ? true : false;    // ternary operator
		
						Console.WriteLine($"The number 10 is {is10}");
						Console.WriteLine();
					}

				static void Example8()
					{
						// Comparing Integers
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
					}

				static void Example9()
					{
						// Comparing Integers v2
						int number1, number2;

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
					}

				static void Example10()
					{
						Console.WriteLine(GetMax(20, 10, 5));    // see GetMax method
						Console.WriteLine();
					}

				static int GetMax(int num1, int num2, int num3)
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
					}

				static void Example11()
					{
						// Calculates the cost the user will spend from the number of beers consumed in a year 
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
					}

				static void Example12()
					{
						// Decision using ternary operator
						int age;

						Console.Write("How old are you? ");
						age = int.Parse(Console.ReadLine());

						Console.WriteLine(age > 50 ? "You are old" : "You are young"); // ternary operator
						Console.WriteLine();	
					}

				static void Example13()
					{
						int studentAge;

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
					}

				static void Example14()
					{
						int studentAge;

						// prompt user and read first number
						Console.Write("Enter your age: ");
						studentAge = int.Parse(Console.ReadLine());

						bool canDrive = studentAge >= 16 ? true : false;
						Console.WriteLine($"Permission to drive: {canDrive}");
						Console.WriteLine();
					}

				static void Example15()
					{
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
					}

				static void Example16()
					{
						int age1;
						bool hasInsurance;

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
	
					}

				static void Example17()
					{
						int age1;
						string outcomeK;
						string outcomeD;
						string outcomeS;

						Console.Write("What is your age? "); // Writes text to the console
						age1 = Convert.ToInt32(Console.ReadLine());

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
					}

				static void Example18()
					{
						// Calculator program
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
					}

				static void Example19()
					{
						// logical operators
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
					}

				static void Example20()
					{
						// To compare strings use Equals
						string name6 = "Derek";
						string name7 = "Derek";

						if (name6.Equals(name7, StringComparison.Ordinal))
							{
								Console.WriteLine("Names are Equal");
							}
						Console.WriteLine();
					}

				static void Example21()
					{
						/* Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
						 * Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic.
						 * Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. */

						Console.WriteLine("Please enter two floating-point numbers to compare (make sure to use the correct decimal symbol based on your system's settings)");    
						double number1 = double.Parse(Console.ReadLine()); 
						double number2 = double.Parse(Console.ReadLine());

						if (Math.Abs(number1 - number2) < 0.000001)  // Checks whether the difference in absolute value between the two numbers is smaller than the specified epsilon
							{
								Console.WriteLine("The two numbers are equal with precision 0.000001");  // If the difference is small enough we consider the two numbers equal
							}
						else
							{            
								Console.WriteLine("The two numbers are NOT equal with precision 0.000001"); 
							}
					}

				static void Example22()
					{
						/* Joro loves a lot to play football. He used to play for his local village club “Pantera” Kaloyanovets. However, he is a programmer now and he is very busy.
						 * Now he is able to play only in the holidays and in the weekends.
						 * Joro plays in 1/2 of the holidays and twice in the weekends: each Saturday and each Sunday, but not every weekend 
						 * – only when he is not tired and only when he is not going to his hometown.
						 * Joro goes at his hometown h weekends in the year. The other weekends are considered “normal”. Joro is tired in 1/3 of the normal weekends.
						 * When Joro is at his hometown, he always plays football with his old friends once, at Sunday.
						 * In addition, if the year is leap, Joro plays football 3 more times additionally, in non-weekend days. We assume the year has exactly 52 weekends.
						 * Your task is to write a program that calculates how many times Joro plays football (rounded down to the nearest integer number). */

						 /* t leap year
						  * 1 holiday
						  * 2 hometown weekends
						  * 38
						  *
						  * 52 weekends total in the year, split into:
						  * 2 hometown weekends  2 Sundays  2 plays
						  * 50 normal weekends  50 * 2 / 3  33.33 plays
						  * 1 holiday  0.5 plays
						  * Leap years  additional 3 plays
						  * Total plays = 38.83 plays  38 (rounded) */

						string isLeap = Console.ReadLine();
						int holidays = int.Parse(Console.ReadLine());
						int hometownWeekends = int.Parse(Console.ReadLine());

						int normalWeekends = 52 - hometownWeekends;
						double plays = 0;

						plays += holidays / 2.0;
						plays += (2.0 / 3) * normalWeekends;
						plays += hometownWeekends;

						if (isLeap == "t")
							{
								plays += 3;
							}
						Console.WriteLine((int)plays);
					}
			}
	}
// Robert Calero - App displaying String data type declaration, initialization, printing variable value to the console, String methods
using System;

// Namespaces
namespace _002_StringDataType
	{
		// Classes
		internal class Examples
			{
				// Methods(Parameters)
				public void ProcessExamples()
					{
						Start:
							Console.Write($"Please select an example from 1-30: ");
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
											case 23:
												Example23();
												break;
											case 24:
												Example24();
												break;
											case 25:
												Example25();
												break;
											case 26:
												Example26();
												break;
											case 27:
												Example27();
												break;
											case 28:
												Example28();
												break;
											case 29:
												Example29();
												break;
											case 30:
												Example30();
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
						Console.Write($"What is your name? ");       // Prompts the user for input
						string name = Console.ReadLine();           // Receiving input for user to display the value of what was entered

						Console.WriteLine($"Your name is {name}");  // Displaying the value of the string variable using string interpolation
					}

				static void Example2()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"Your name is {name, 4}");  // string interplation with left padding - left padding starts at 4
					}

				static void Example3()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();
					
						Console.WriteLine($"Adding right padding to your name\n{name, -4}");    // String interplation with right padding - right padding starts at -4
					}

				static void Example4()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"The length of your name is {name.Length} characters");  // Gets the number of characters in the current string object and returns the integer value
					}

				static void Example5()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						for (int index = 0; index < name.Length; index++)    // Loops through the string variable entered displaying each character individually
							{
								Console.Write($"{name[index]}");
							}
						Console.WriteLine();
					}

				static void Example6()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"Your name in all uppercase letters is {name.ToUpper()}");  // Formats string to all uppercase letters
					}

				static void Example7()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"Your name in all lowercase letters is {name.ToLower()}");  // Formats string to all lowercase letters
					}

				static void Example8()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"Is the letter o in my name? {name.Contains("o")}");    // Returns true or false if the string parameter is in the current string
					}

				static void Example9()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"The first character in your name is: {name[0]}");    // Returns the first substring of the value entered
					}

				static void Example10()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"The letter R is at index {name.IndexOf('R')} in your name");    // Returns the index of the value entered
					}

				static void Example11()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"Begin grabbing the substring of my name? {name.Substring(1, 2)}");    // Retrieves 2 characters from the string entered starting from index 1
					}

				static void Example12()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"Is the string entered empty? {string.IsNullOrEmpty(name)}");   // Checks to see if the string entered is empty or has characters
					}

				static void Example13()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"Is the string empty: {string.IsNullOrWhiteSpace(name)}");   // Checks to see if the string entered is empty or has blank spaces or characters
					}

				static void Example14()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"Has the word \"Rob\": {name.StartsWith("Rob")}"); // Checks whether the string entered matches the beginning of the string
					}

				static void Example15()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"Has the word \"Rob\": {name.EndsWith("Rob")}"); // Checks whether the string entered matches the end of the string
					}

				static void Example16()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();

						Console.WriteLine($"Your name without the white-space is: {name.Trim()}"); // Removes the white-space from the string entered if any
					}

				static void Example17()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();
 
						Console.WriteLine($"Your name with letters removed is: {name.Remove(0, 2)}"); // Returns a new string in which 2 characters from the entered string were removed starting from a specific index position
					}

				static void Example18()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();
						
						Console.Write($"What is your friends name? ");
						string friendName = Console.ReadLine();

						Console.WriteLine($"Do you both have the same name? {name.Equals(friendName)}");    // Checks if value of one string match value of another
					}

				static void Example19()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();
						
						Console.Write($"What is your friends name? ");
						string friendName = Console.ReadLine();

						Console.WriteLine($"Do you both have the same name? {name.Equals(friendName, StringComparison.OrdinalIgnoreCase)}");    // Checks if value of one string match value of another regardless of the character cases
					}

				static void Example20()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();
					
						Console.WriteLine($"Inserting a string at a specified position from the string value entered: {name.Insert(0, $"Mr. ")}");    // Inserts a word in front of the value
					}

				static void Example21()
					{
						Console.Write($"What is your phone number? (Ex: 000-000-0000) ");
						string number = Console.ReadLine();

						Console.WriteLine($"You number without the dashes is: {number.Replace("-", " ")}");    // Replaces the dashes from the value with no spaces
					}

				static void Example22()
					{
						Console.Write($"What is your name? ");
						string name = Console.ReadLine();
						
						Console.Write($"What is your friends name? ");
						string friendName = Console.ReadLine();

						Console.WriteLine($"Compare strings: {string.Compare(name, friendName, StringComparison.OrdinalIgnoreCase)}"); // Compares two strings and returns an integer that indicates their relative position in the sort order
					}
				
				static void Example23()
					{
						Console.Write($"How much money you got? ");
						string number = Console.ReadLine();  // Explicit conversion - string to int

						int valueEntered = int.Parse(number);  // Converts the string value entered into an integer - use Parse when values are in a string
						Console.WriteLine($"You got: {valueEntered, 0:C}"); // Returns currency numeric format string - value in a currency format with 2 decimal places
					}

				static void Example24()
					{
						Console.Write($"Enter a number: ");
						string number = Console.ReadLine();

						int valueEntered = int.Parse(number);
						Console.WriteLine($": {valueEntered, 0:D}"); // Returns the decimal numeric format string
					}

				static void Example25()
					{
						Console.Write($"Enter a number: ");
						string number = Console.ReadLine();

						int valueEntered = int.Parse(number);
						Console.WriteLine($"Number entered with 2 decimal places is: {valueEntered, 0:F}"); // Returns the fixed-point numeric format string - value with 2 decimal places. If a double is used, it rounds to the next highest number
					}

				static void Example26()
					{
						Console.Write($"Enter a number: ");
						string number = Console.ReadLine();

						int valueEntered = int.Parse(number);
						Console.WriteLine($"Number entered with 2 decimal places is: {valueEntered, 0:N}"); // Returns the number numeric string format - integer value with commas and 2 decimal places
					}

				static void Example27()
					{
						Console.Write($"Enter a number: ");
						string number = Console.ReadLine();  // Explicit conversion - string to double

						double valueEntered = double.Parse(number);  // Converts the string value entered into a double
						Console.WriteLine($"Number entered with 2 decimal places is: {valueEntered, 0:#.00}"); // Returns the digit placeholder numeric format string
					}

				static void Example28()
					{
						Console.Write($"Enter a number: ");
						string number = Console.ReadLine();

						bool conversion = int.TryParse(number, out int valueEntered);  // TryParse() returns a bool indicating whether it succeeded or failed

						if (conversion) // Checks whether the conversion from string to int was successful
							{
								Console.WriteLine($"{valueEntered}");
							}
						else
							{
								Console.WriteLine($"Please enter a valid integer value");
							} 
					}

				static void Example29()
					{
						// Each time you change a string you are actually creating a new string which is inefficient when you are working with large blocks of text
						string sentence = $"C#";
						sentence += $" video";
						sentence += $" tutorial";
						sentence += $" for";
						sentence += $" beginners";

						Console.WriteLine($"{sentence}");
					}

				static void Example30()
					{
						string numbers = string.Empty; // initializes the string as being empty

						for (int index = 1; index <=3; index++)
							{
								numbers += Convert.ToString($"{index} "); // Iterates through the numbers converting each integer value into a string
							}

						Console.WriteLine($"{numbers}");
					}
			}
	}
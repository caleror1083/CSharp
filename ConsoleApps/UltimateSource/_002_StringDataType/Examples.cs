// Robert Calero - App displaying String data type declaration, initialization, printing variable value to the console, String methods
using System;

class Examples    // Class declaration - a class defines the variables and methods used by objects
	{
		public static void ProcessExamples()
			{
				bool check;
				string decision;

				Start:
					Console.Write("Please select an example from 1-22: ");
					check = int.TryParse(Console.ReadLine(), out int choice);

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
									default:
										Console.WriteLine("Your choice is invalid");
										goto Start;
								}
						}
					else
						{
							Console.WriteLine($"Selection chosen is incorrect");
							goto Start;
						}

				Decide:
					Console.Write("Do you want to do another example? - Yes or No: ");
					decision = Console.ReadLine();
					Console.WriteLine();

					switch (decision.ToUpper())
						{
							case "YES":
								goto Start;
							case "NO":
								break;
							default:
								Console.WriteLine("Your decision is invalid. Try again");
								goto Decide;
						}
			}

		public static void Example1()
			{
				Console.Write("What is your name? ");    // Prompts the user for input
				string name = Console.ReadLine();    // receiving input for user to display the value of what was entered

				Console.WriteLine($"Your name is {name}");    // displaying the value of the string variable using string interpolation
			}

		public static void Example2()
			{
				Console.Write("What is your name? ");    // Prompts the user for input
				string name = Console.ReadLine();    // receiving input for user to display the value of what was entered

				Console.WriteLine($"My name is {name, 4}");    // string interplation with formatting
			}

		public static void Example3()
			{
				Console.Write("What is your name? ");    // Prompts the user for input
				string name = Console.ReadLine();    // receiving input for user to display the value of what was entered

				Console.WriteLine($"The length of my name is {name.Length} characters");  // gets the number of characters in the string object
				Console.WriteLine($"My name is all uppercase {name.ToUpper()}");    // formats string to all uppercase
				Console.WriteLine($"My name is all lowercase {name.ToLower()}");    // formats string to all lowercase
				Console.WriteLine($"Is the letter o in my name? {name.Contains("o")}");    // returns whether a certain character is in a string
				Console.WriteLine($"What is the first character in my name? {name[0]}");    // returns the first substring of the value entered
				Console.WriteLine($"What is the last character in my name? {name[2]}");    // returns the last substring of the value entered
				Console.WriteLine($"Where does this character begin? {name.IndexOf('R')}");    // returns the index of the value entered
				Console.WriteLine($"Begin grabbing the substring of my name? {name.Substring(1, 2)}");    // returns the 2nd and 3rd substrings of the value entered
				Console.WriteLine($"Is the string empty: {string.IsNullOrEmpty(name)}");   // checks to see if the value of the variable is empty  
				Console.WriteLine($"Is the string empty: {string.IsNullOrWhiteSpace(name)}");   // checks to see if the value of the variable is empty
				Console.WriteLine($"Has the word \"Rob\": {name.StartsWith("Rob")}");
				name = name.Trim();
				name = name.Remove(0, 2);
				Console.WriteLine(name);
			}

		public static void Example4()
			{
				string name2 = "Lance";    // string is an alias to fully qualified name - variable declaration and instantiation
				string name3 = "123-456-7890";    // string variable declaration and instantiation
				string string1 = "someString";
				string string2 = "someOtherString";
				string string3 = "someString";
				string string4 = "somestring";
				Console.WriteLine(name2);    // display value of name2

				Console.WriteLine("Has the word Lance: " + name2.EndsWith("Lance"));
				Console.WriteLine("Strings Equal: " + name2.Equals(name3));    // chwcking if value of one string match value of another
				Console.WriteLine($"String Insert method {name2.Insert(0, "Mr. ")}");    // inserts a word in front of the value
				Console.WriteLine($"String replace method {name3.Replace("-", "")}");    // replaces the dashes from the value with no spaces

				if (string1 == string2)
					{
						Console.WriteLine("String1 and String2 are not equal");
					}
				if (string1.Equals(string3))
					{
						Console.WriteLine("String1 and String3 are equal");
					}
				if (string1 == string4)
					{
						Console.WriteLine("String1 and String4 are not equal");
					}
				Console.WriteLine();

				if (string1.Equals(string4, StringComparison.CurrentCultureIgnoreCase))    // method and parameter that ignores the case of strings
					{
						Console.WriteLine("String1 and String4 case is ignored but are equal");
					}
				Console.WriteLine();

				for (int i = 0; i < string1.Length; i++)    // loops through the string variable displaying each character individually
					{
						Console.Write($"{string1[i]}");
					}
				Console.WriteLine();
			}

		public static void Example5()
			{
				// ---------- STRINGS ----------
				// Strings store a series of characters
				string randString = "This is a string";

				// Get number of characters in string
				Console.WriteLine("String Length : {0}", randString.Length);

				// Check if string contains other string
				Console.WriteLine("String Contains is : {0}", randString.Contains("is"));

				// Index of string match
				Console.WriteLine("Index of is : {0}", randString.IndexOf("is"));

				// Remove number of characters starting at an index
				Console.WriteLine("Remove string : {0}", randString.Remove(10, 6));

				// Add a string starting at an index
				Console.WriteLine("Insert String : {0}", randString.Insert(10, "short "));

				// Replace a string with another
				Console.WriteLine("Replace String : {0}", randString.Replace("string", "sentence"));

				// Compare strings and ignore case
				// < 0 : str1 preceeds str2
				// = : Zero
				// > 0 : str2 preceeds str1
				Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));

				// Check if strings are equal
				Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

				// Add padding left
				Console.WriteLine("Pad Left : {0}", randString.PadLeft(20, '.'));

				// Add padding right
				Console.WriteLine("Pad Right : {0} Stuff", randString.PadRight(20, '.'));

				// Trim whitespace
				Console.WriteLine("Trim : {0}", randString.Trim());

				// Make uppercase
				Console.WriteLine("Uppercase : {0}", randString.ToUpper());

				// Make lowercase
				Console.WriteLine("Lowercase : {0}", randString.ToLower());	
			}
				
		public static void Example6()
			{
				string numValues = string.Format("{0:c} {1:00.00} {2:#.00} {3:0,0} {4:N0}", 1.56, 15.567, .56, 1000, 2000);
				// string value 0 returns currency
				// string value 1 returns value rounded to 2 decimal places
				// string value 2 returns cents
				// string value 3 returns comma seperated numeric value
				// string value 4 returns comma seperated numeric value - alternate way
				Console.WriteLine(numValues);
				Console.WriteLine();

				// ---------- FORMATTING OUTPUT ----------

				// Format output for currency
				Console.WriteLine("Currency : {0:c}", 23.455);

				// Pad with zeroes 
				Console.WriteLine("Pad with 0s : {0:d4}", 23);

				// Define decimals 
				Console.WriteLine("3 Decimals : {0:f3}", 23.4555);

				// Add commas and decimals
				Console.WriteLine("Commas : {0:n4}", 2300);
				Console.WriteLine("");
			}

		public static void Example7()
			{
				string[] names = new string[3] {"Mark", "Steve", "Adam" };
				Console.WriteLine("Name list: " + string.Join(", ", names));    // concatenates all values in a string array
				Console.WriteLine();
			}

		public static void Example8()
			{
				string strNumber = "100";    // explicit conversion - string to int
				int k = int.Parse(strNumber);    // use Parse when values are in a string

				Console.WriteLine(k);

				Console.WriteLine();
			}

		public static void Example9()
			{
				string strNumber2 = "100G";
				bool Successful = int.TryParse(strNumber2, out int l);    // TryParse() returns a bool indicating whether it succeeded or failed

				if (Successful)
					{
						Console.WriteLine(l);
					}
				else
					{
						Console.WriteLine("Please make the value of the string variable a valid int value");
					}
			}

		public static void Example10()
			{
				// Each time you change a string you are actually creating a new string which is inefficient when you are working with large blocks of text
				string sentence = "C#";
				sentence += " video";
				sentence += " tutorial";
				sentence += " for";
				sentence += " beginners";

				string full = "C# video tutorial for beginners";

				Console.WriteLine($"{sentence}");
				Console.WriteLine($"{full}");
				Console.WriteLine($"C# video tutorial for beginners");
			}

		public static void Example11()
			{
				// Each time you change a string you are actually creating a new string which is inefficient when you are working with large blocks of text
				string numbers = string.Empty;

				for (int index = 1; index <=3; index++)
					{
						numbers += Convert.ToString($"{index} ");
					}

				Console.WriteLine($"{numbers}");
			}
	}
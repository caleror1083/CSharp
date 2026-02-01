using System;

namespace StringDataType;
	
internal class Examples
{
	public static void ProcessExamples()
	{
		Start:
			Console.Write($"Please select an example from 1-32: ");
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
					case 31:
						Example31();
						break;
					case 32:
						Example32();
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

	private static void Example1()
	{
		string name = "Rob";  // Variable declaration and initialization

		Console.WriteLine($"Your name is {name}");  // Displaying the value of the string variable using string interpolation
	}

	private static void Example2()
	{
		Console.Write($"What is your name? ");       // Prompts the user for input
		string name = Console.ReadLine();           // Receiving input for user to display the value of what was entered

		Console.WriteLine($"Your name is {name}");  
	}

	private static void Example3()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

		Console.WriteLine($"Your name is {name, 4}");  // string interplation with left padding - left padding starts at 4
	}

	private static void Example4()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();
					
		Console.WriteLine($"Adding right padding to your name\n{name, -4}");    // String interplation with right padding - right padding starts at -4
	}

	private static void Example5()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

		// Gets the number of characters in the current string object and returns the integer value
        Console.WriteLine($"The length of your name is {name.Length} characters");  
	}

	private static void Example6()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

		for (int index = 0; index < name.Length; index++)    // Loops through the string variable entered displaying each character individually
		{
			Console.Write($"{name[index]}");
		}
		
        Console.WriteLine();
	}

	private static void Example7()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

		Console.WriteLine($"Your name in all uppercase letters is {name.ToUpper()}");  // Formats string to all uppercase letters
	}

	private static void Example8()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

		Console.WriteLine($"Your name in all lowercase letters is {name.ToLower()}");  // Formats string to all lowercase letters
	}

	private static void Example9()
	{
		Console.Write($"What is your name? ");
		var name = Console.ReadLine();

		Console.WriteLine($"Is the letter o in my name? {name.Contains('o')}");    // Returns true or false if the string parameter is in the current string
	}

	private static void Example10()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

		Console.WriteLine($"The first character in your name is: {name[0]}");    // Returns the first substring of the value entered
	}

	private static void Example11()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

		Console.WriteLine($"The letter R is at index {name.IndexOf('R')} in your name");    // Returns the index of the value entered
	}

	private static void Example12()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();
        
        // Retrieves 2 characters from the string entered starting from index 1
		Console.WriteLine($"Begin grabbing the substring of my name? {name.Substring(1, 2)}");    
	}

	private static void Example13()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

		Console.WriteLine($"Is the string entered empty? {string.IsNullOrEmpty(name)}");   // Checks to see if the string entered is empty or has characters
	}

	private static void Example14()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

        // Checks to see if the string entered is empty or has blank spaces or characters
		Console.WriteLine($"Is the string empty: {string.IsNullOrWhiteSpace(name)}");   
	}

	private static void Example15()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

		Console.WriteLine($"Has the word \"Rob\": {name.StartsWith("Rob")}"); // Checks whether the string entered matches the beginning of the string
	}

	private static void Example16()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

		Console.WriteLine($"Has the word \"Rob\": {name.EndsWith("Rob")}"); // Checks whether the string entered matches the end of the string
	}

	private static void Example17()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

		Console.WriteLine($"Your name without the white-space is: {name.Trim()}"); // Removes the white-space from the string entered if any
	}

	private static void Example18()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();

        // Returns a new string in which 2 characters from the entered string were removed starting from a specific index position
		Console.WriteLine($"Your name with letters removed is: {name.Remove(0, 2)}"); 
	}

	private static void Example19()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();
						
		Console.Write($"What is your friends name? ");
		string friendName = Console.ReadLine();

		Console.WriteLine($"Do you both have the same name? {name.Equals(friendName)}");    // Checks if value of one string match value of another
	}

	private static void Example20()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();
						
		Console.Write($"What is your friends name? ");
		string friendName = Console.ReadLine();
        
        // Checks if value of one string match value of another regardless of the character cases
		Console.WriteLine($"Do you both have the same name? {name.Equals(friendName, StringComparison.OrdinalIgnoreCase)}");    
	}

	private static void Example21()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();
        
        // Inserts a word in front of the value
		Console.WriteLine($"Inserting a string at a specified position from the string value entered: {name.Insert(0, $"Mr. ")}");    
	}

	private static void Example22()
	{
		Console.Write($"What is your phone number? (Ex: 000-000-0000) ");
		string number = Console.ReadLine();

		Console.WriteLine($"You number without the dashes is: {number.Replace("-", " ")}");    // Replaces the dashes from the value with no spaces
	}

	private static void Example23()
	{
		Console.Write($"What is your name? ");
		string name = Console.ReadLine();
						
		Console.Write($"What is your friends name? ");
		string friendName = Console.ReadLine();

        // Compares two strings and returns an integer that indicates their relative position in the sort order
		Console.WriteLine($"Compare strings: {string.Compare(name, friendName, StringComparison.OrdinalIgnoreCase)}"); 
	}

	private static void Example24()
	{
		// Each time you change a string you are actually creating a new string which is inefficient when you are working with large blocks of text
		string sentence = $"C#";
		sentence += $" video";
		sentence += $" tutorial";
		sentence += $" for";
		sentence += $" beginners";

		Console.WriteLine($"{sentence}");
	}

	private static void Example25()
	{
		string numbers = string.Empty; // initializes the string as being empty

		for (int index = 1; index <=3; index++)
		{
			numbers += Convert.ToString($"{index} "); // Iterates through the numbers converting each integer value into a string
		}

		Console.WriteLine($"{numbers}");
	}

	private static void Example26()
	{
		/*
		    Declare two string variables and assign them with “Hello” and “World”. Declare an object 
			variable and assign it with the concatenation of the first two variables (mind adding an 
			interval between). Declare a third string variable and initialize it with the value of the 
			object variable (you should perform type casting).
        */

		string firstString = "Hello";
		string secondString = "World";
		object concatenation = $"{firstString} {secondString}";
		string thirdString = $"{concatenation}";

		Console.WriteLine($"{thirdString}");
	}

	private static void Example27()
	{
		/*
		    Declare two string variables and assign them with following value:
            
            'The "use" of quotations causes difficulties.'
            
            Do the above in two different ways: with and without using quoted strings.
            Print the variables to ensure that their value was correctly defined
        */

		string firstString = "The \"use\" of quotations causes difficulties.";
		string secondString = @"The ""use"" of quotations causes difficulties.";

		Console.WriteLine(new string('-', 52) + "\nMethod 1: using normal quotation and escaping with \\\n" + new string('-', 52) + $"\n{firstString}");
		Console.WriteLine("\n\n\n"+new string('-', 54) + "\nMethod 2: using verbatim quotation and escaping with \"\n" + new string('-', 54) + $"\n{secondString}");
	}

	private static void Example28()
	{
		/* A marketing company wants to keep record of its employees. Each record would have the following characteristics:
        * •	First name
			* •	Last name
			* •	Age (0...100)
			* •	Gender (m or f)
			* •	Personal ID number (e.g. 8306112507)
			* •	Unique employee number (27560000…27569999)

			* Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
			* Use descriptive names. Print the data at the console. */	

		string firstName = "Robert";
		string lastName = "Calero";
		byte age = 44;
		char gender = 'm';
		string personalIDNumber = "8306112507";
		string uniqueEmployeeNumber = "27564281";
    
		Console.WriteLine($"First Name: {firstName}\nLastName: {lastName}\nAge: {age}\nGender: {gender}\nPersonal ID Number: {personalIDNumber}\nUnique Employee Number: {uniqueEmployeeNumber}");
	}

	private static void Example29()
	{
		string firstName = "John ";
		string lastName = "Doe";
		string name = string.Concat(firstName, lastName);

		Console.WriteLine(name);
	}

	private static void Example30()
	{
		string name = "Robert";

		Console.WriteLine(name[0]);    // returns the first character in name
	}

	private static void Example31()
	{
		string name = "Robert";
        const string indexPosition = "r";

        Console.WriteLine(name.IndexOf(indexPosition));    // returns the index position of a specific character in name
	}

	private static void Example32()
	{
		string name = "Robert Calero";
        const string startingCharacter = "C";
        int charPosition = name.IndexOf(startingCharacter);

		Console.WriteLine(name[charPosition..]);    // returns the characters from name starting from the index of charPosition
	}
}
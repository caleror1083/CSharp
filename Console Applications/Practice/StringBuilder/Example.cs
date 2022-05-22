// Robert Calero - App displaying StringBbuilder
using System;
using System.Text;    // needed for StringBuilder
using System.Globalization;    // For culture specific formating

class Example
	{
		public void ProcessExamples()
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
				StringBuilder sentence = new StringBuilder("C#");    // StringBuilders actually change the text rather then make a copy
				sentence.Append(" video");    // changing the StringBuilder object
				sentence.Append(" tutorial");
				sentence.Append(" for");
				sentence.Append(" beginners");    // 5th time changing
				Console.WriteLine($"{Convert.ToString(sentence)}");
				Console.WriteLine();

				Console.WriteLine("Example 3: StringBuilder Sentence");
                StringBuilder customString = new StringBuilder("This is the first sentence. ");
                customString.AppendFormat($"My name is {"Rob"} and I live in {"Paterson"}");
				customString.Replace("a", "e");    // replaces all 'a' characters in the string with the letter 'e'
                customString.Remove(5, 7);    // removes the specified index range of characters in the string
                Console.WriteLine(customString.ToString());
				Console.WriteLine();

				Console.WriteLine("Example 4: StringBuilder Sentence Example");
				StringBuilder a1 = new StringBuilder();
				StringBuilder a2 = new StringBuilder(50);
				StringBuilder a3 = new StringBuilder("Yes", 0, 2, 70);
				StringBuilder a4 = new StringBuilder(60, 100);
				StringBuilder myStringBuilder = new StringBuilder("Random Text");    // Create a StringBuilder with a default size of 16 characters, but it grows automatically
				StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);    // Create a StringBuilder with a size capacity of of 256

				Console.WriteLine(a1.Append(true));
				a1.Clear();
				Console.WriteLine(a1.Append((byte)1));
				a1.Clear();
				Console.WriteLine(a1.Append('s'));
				a1.Clear();
				Console.WriteLine(a1.Append(new char[] { 'a', 'e' }));
				a1.Clear();
				Console.WriteLine(a1.Append((decimal)4.5));
				a1.Clear();
				Console.WriteLine(a1.Append(5.0));
				a1.Clear();
				Console.WriteLine(a1.Append(6.0F));
				a1.Clear();
				Console.WriteLine(a1.Append(8));
				a1.Clear();
				Console.WriteLine(a1.Append('g', 2));
				a1.Clear();
				Console.WriteLine(a2.Append(true));
				a1.Clear();
				Console.WriteLine(a3.Append(true));
				a1.Clear();
				Console.WriteLine(a4.Append(true));
				unsafe
					{
						char myChar = 't';
						char* myPointer = &myChar;
						Console.WriteLine(a1.Append(myPointer, 1));
					}
				a1.Clear();
				Console.WriteLine(a1.Append(new char[] { 'a', 'e' }, 0, 2));
				a1.Clear();
				Console.WriteLine(a1.Append($"sk", 0, 2));
				a1.Clear();

				Console.WriteLine($"The maximum number of characters for this StringBuilder object is: {sb2.Capacity}");    // Get max size
				Console.WriteLine($"The length of the current StringBuilder object is: {sb2.Length}");    // Get length
				sb2.AppendLine();
				sb2.AppendLine("More important text");    // Add text to StringBuilder
            
				// Define culture specific formating
				CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
 
				// Append a format string
				string bestCust = "Bob Smith";
				sb2.AppendFormat("Worst Custy {0}", bestCust);
				sb2.AppendLine();
				sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);
 
				// Output StringBuilder
				Console.WriteLine(sb2.ToString());
 
				// Replace a string
				sb2.Replace("text", "characters");
				Console.WriteLine(sb2.ToString());

				// Clear a string builder
				sb2.Clear();
				sb2.Append("Random Text");
 
				// Are objects equal
				Console.WriteLine(myStringBuilder.Equals(sb2));
 
				// Insert at an index
				sb2.Insert(11, " that's Great"); 
				Console.WriteLine("Insert : {0}", sb2.ToString());
 
				// Remove number of characters starting at index
				sb2.Remove(11, 7);
				Console.WriteLine("Remove : {0}", sb2.ToString());
				Console.WriteLine();

			}
	}
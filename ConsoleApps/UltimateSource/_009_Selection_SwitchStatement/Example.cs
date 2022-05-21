// Robert Calero - App displaying Switch statements
using System;

class Example    // Class declaration - a class defines the variables and methods used by objects
	{
		public void Results()
			{
				Console.WriteLine("Example 1:");
				int age = 10;

				switch (age)    // checks the value entered to see where you are in life
					{
						case 0:
							Console.WriteLine("You have not been born yet");
							break;
						case 5:
							Console.WriteLine("Too young for school");
							break;
						case 10:
							Console.WriteLine("You are in school");
							break;
						default:
							Console.WriteLine("I don't know");
							break;
					}
				Console.WriteLine();
				
				Console.WriteLine("Example 2:");
				int number;

				Console.Write("Please enter a number: ");
				number = int.Parse(Console.ReadLine());

				switch (number)    // Checks to see if the number entered is either 10, 20 or 30
					{
						case 10:
							Console.WriteLine("Your number is 10");
							break;
						case 20:
							Console.WriteLine("Your number is 20");
							break;
						case 30:
							Console.Write("Your number is 30");
							break;
						default:
							Console.WriteLine("Your number is not 10, 20 or 30");
							break;						
					}
				Console.WriteLine();

				/* Replace multiple if else statements with 1 switch statement
				   int number;

				   Console.Write("Please enter a number: ");
				   number = int.Parse(Console.ReadLine());

				   if (number == 10)
				       {
					       Console.WriteLine("Your number is 10");
					   }
				   else if (number == 20)
				       {
					       Console.WriteLine("Your number is 20");
					   }
				   else if (number == 30)
				       {
					       Console.WriteLine("Your number is 30");
					   }
				   else
				       {
					       Console.WriteLine("Your number is not 10, 20 or 30");
					   }
				*/

				Console.WriteLine("Example 3: Alternate to Example 2");
				int num;

				Console.Write("Please enter a number: ");
				num = int.Parse(Console.ReadLine());

				switch (num)
					{
						case 10:
						case 20:
						case 30:
							Console.WriteLine($"Your number is {num}");
							break;
						default:
							Console.WriteLine("Your number is not 10, 20 or 30");
							break;						
					}
				Console.WriteLine();

				Console.WriteLine("Example 4: Coffee shop");
				int choice;    // variable to hold the coffee size choice
				int total = 0;    // variable to hold the total price
				string decision;

				Start:    // label named Start
					Console.Write("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large: ");
					choice = int.Parse(Console.ReadLine());

					switch (choice)    // checks the choice entered
						{
							case 1:
								total += 1;    // if small is selected the total price will increase $1.00
								break;
							case 2:
								total += 2;    // if medium is selected the total price will increase $2.00
								break;
							case 3:
								total += 3;    // if large is selected the total price will increase $3.00
								break;
							default:
								Console.WriteLine($"Your choice is invalid");
								goto Start;    // if an invalid choice is entered, control returns back to the starting point
						}
				
				Decide:
					Console.Write("Do you want to buy another coffee? - Yes or No: ");
					decision = Console.ReadLine();

					switch (decision.ToUpper())    // checks what the user entered and converts it to uppercase
						{
							case "YES":
								goto Start;    // if user decides to continue shopping, control returns back to the starting point
							case "NO":
								break;
							default:
								Console.WriteLine($"Your decision is invalid. Please try again");
								goto Decide;    // if an invalid choice is entered, control returns back to the decision
						}

				Console.WriteLine();
				Console.WriteLine("Thank you for shopping with us");
				Console.WriteLine($"Bill amount = {total, 4:C}");

				int age5 = 17;

				// Switch is used when you have limited options
				// The only way to use ranges is to stack 
				// the possible values
				switch (age5)
				{
					case 1:
					case 2:
						Console.WriteLine("Go to Day Care");
						break;
					case 3:
					case 4:
						Console.WriteLine("Go to Preschool");
						break;
					case 5:
						Console.WriteLine("Go to Kindergarten");
						break;
					default:
						Console.WriteLine("Go to another school");
                    
						// You can also jump out of a switch
						// with goto
						goto OtherSchool;
				}

			OtherSchool:
				Console.WriteLine("Elementary, Middle, High School");
				Console.WriteLine();

			}    // end method Results
	}    // end class Examples
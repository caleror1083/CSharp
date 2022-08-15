// Robert Calero - App displaying static methods and method overloading
using System;

namespace _015_Methods_Static
	{
		internal class Employees
			{
				public void ProcessExamples()
					{
						bool check;
						string decision;

						Start:
							Console.Write("Please select an example from 1-29: ");
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
						OddNumbers();    // invoking static method OddNumbers
						Console.WriteLine();
					}

				static void OddNumbers()    // method that prints odd numbers between 1-20
					{
						int value = 1;    // initial integer value is 1

						while (value <= 20)    // checks whether the integer value is greater than or equal to 20
							{
								Console.Write($"{value} ");    // prints the integer value to the console
								value += 2;    // increments the integer value by 2
							}
					}

				public static void Example2()
					{
						Console.Write("What do you want the target number to be? ");
						int target = int.Parse(Console.ReadLine());

						EvenNumbersByParameters(target); // invoking a static method with 1 integer parameter
						Console.WriteLine();
					}

				static void EvenNumbersByParameters(int targetParameter)    // method that prints even numbers via an integer parameter
					{
						int value = 0;    // initial integer value is 0

						while (value <= targetParameter)    // checks whether the integer value is greater than or equal to the target number entered
							{
								Console.Write($"{value} ");    // prints the integer value to the console
								value += 2;    // increments the integer value by 2
							}
					}

				public static void Example3()
					{
						string name = "Rob";
						SingHappyBirthday(name);  // calling a static method with 1 string parameter

					}

				static void SingHappyBirthday(string nameParameter)  // method that passes in a string parameter while writing Happy Birthday
					{
						Console.WriteLine("Happy birthday to you!");
						Console.WriteLine("Happy birthday to you!");
						Console.WriteLine($"Happy birthday dear {nameParameter}!");
						Console.WriteLine("Happy birthday to you!");
					}

				public static void Example4()
					{
						Console.Write("What number do you want cubed? ");
						double num = double.Parse(Console.ReadLine());

						Console.WriteLine(Cube(num));  // invoking static method with 1 double parameter
					}

				static double Cube(double numberParameter)    // method that prints the cubed number of the value entered utilizing a double parameter
					{
						return Math.Pow(numberParameter, 3);
					}

				public static void Example5()
					{
						Console.Write("Enter number 1: ");
						double x = double.Parse(Console.ReadLine());

						Console.Write("Enter number 2: ");
						double y = double.Parse(Console.ReadLine());

						Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
					}

				static double Multiply(double xParameter, double yParameter)    // passing by value - method that multiplies 2 values
					{
						double product = xParameter * yParameter;
						return product;
					}

				public static void Example6()
					{
						Console.WriteLine(GetPow(3, 3));  // invoking static method with 2 integer parameters
					}

				static int GetPow(int baseParameter, int exponentParameter)    // method that accepts a base number value and an exponent number value
					{
						int result = 1;

						for (int index = 0; index < exponentParameter; index++)
							{
								result *= baseParameter;
							}
						return result;
					}

				public static void Example7()
					{
						int numberValue = 0;

						PassReference(ref numberValue);  // invoking static method

						Console.WriteLine(numberValue);
					}

				static void PassReference(ref int numberParameter)    // example 7: static method with parameters
					{
						numberParameter = 101;
					}

				public static void Example8()
					{
						int number1 = 10;
						int number2 = 20;

						Console.WriteLine($"Before swap number1 is {number1} and number2 is {number2}");

						PassReference(ref number1, ref number2);  // invoking static method referencing 2 integer parameters

						Console.WriteLine($"After swap number1 is {number1} and number2 is {number2}");
					}

				// If a variable is passed by reference changes to its value in the method effect it outside of the method					
				static void PassReference(ref int number1Parameter, ref int number2Parameter)    // method that passes by reference
					{
						(number2Parameter, number1Parameter) = (number1Parameter, number2Parameter);
					}					

				public static void Example9()
					{
						Console.Write("Enter number 1: ");
						int number1 = int.Parse(Console.ReadLine());

						Console.Write("Enter number 2: ");
						int number2 = int.Parse(Console.ReadLine());

						Calculate(number1, number2, out int sum, out int product);    

						Console.WriteLine($"Sum = {sum} | Product = {product}");
					}

				static void Calculate(int number1Parameter, int number2Parameter, out int sumParameter, out int productParameter)  // You can pass a variable as an output variable even without assigning a value to it
					{
						sumParameter = number1Parameter + number2Parameter;
						productParameter = number1Parameter * number2Parameter;
					}

				public static void Example10()
					{
						Console.Write("Enter a number to to double the value: ");
						int number = int.Parse(Console.ReadLine());

						DoubleIt(number, out int result);    // A parameter passed with out has its value assigned in the method

						Console.WriteLine($"Result is {result}");
						Console.WriteLine();
					}

				static void DoubleIt(int numberParameter, out int resultParameter)    // A parameter marked with out must be assigned a value in the method
					{
						resultParameter = numberParameter * 2;
					}

				public static void Example11()
					{
						// Method overloading
						Console.WriteLine($"The sum of 2 Integers are {Sum(5, 6)}");
						Console.WriteLine($"The sum of 3 Integers are {Sum(5, 6, 7)}");
						Console.WriteLine($"The sum of 2 Doubles are {Sum(7.0, 9.0), 2:N}");
						Console.WriteLine();
					}

				static int Sum(int x, int y)    // Sum method with 2 value parameters
					{
						return x + y;
					}

				static int Sum(int x, int y, int z)    // Sum method with 3 value paramters
					{
						return x + y + z;
					}

				static double Sum(double x, double y)
					{
						return x + y;
					}

				public static void Example12()
					{
						AddOverload(5, 6);
						AddOverload(6, 7, 8);
						AddOverload(2.0F, 3.2F);
						AddOverload(5, 4.5F);
						AddOverload(5, 5, out _);
					}
				
				static void AddOverload(int FN, int SN)    // AddOverload method with 2 int parameters
					{
						Console.WriteLine($"The sum is {FN + SN}");
					}

				static void AddOverload(int FN, int SN, int TN)    // AddOverload method with 3 int parameters
					{
						Console.WriteLine($"The sum is {FN + SN + TN}");
					}

				static void AddOverload(float FN, float SN)    // AddOverload with 2 float type parameters
					{
						Console.WriteLine($"The sum is {FN + SN}");
					}

				static void AddOverload(int FN, float SN)    // AddOverload with 2 parameters of different types
					{
						Console.WriteLine($"The sum is {FN + SN}");
					}

				static void AddOverload(int FN, int SN, out int Sum)  // AddOverload with 3 parameters of different types
					{
						Console.WriteLine($"The sum is {Sum = FN + SN}");
					}

				public static void Example13()
					{
						Console.WriteLine($"The sum of the 2 doubles is {GetSum(5.0, 4.5)}");
						Console.WriteLine($"The sum of the 2 doubles converted from strings is {GetSum("5", "4")}");
					}
					
				static double GetSum(double x, double y)
					{
						return x + y;
					}

				static double GetSum(string x, string y)
					{
						double dblX = Convert.ToDouble(x);
						double dblY = Convert.ToDouble(y);
						return dblX + dblY;
					}

				public static void Example14()
					{
						SayHello();    // Call for the function to execute
					}

				static void SayHello()
					{
						Console.Write("What is your name: ");
						string name = Console.ReadLine();    // Save the input the user provides

						Console.WriteLine($"Hello {name}");
					}

				public static void Example15()
					{
						Console.Write("What is your name: ");
						string name = Console.ReadLine();    // Save the input the user provides

						SayHello(name);
					}
					
				static void SayHello(string nameParameter)
					{						
						Console.WriteLine($"Hello {nameParameter}");
					}

				public static void Example16()
					{
						PrintInfo(nameParameter: "Rob C", zipCodeParameter: "07524");
					}
				
				static void PrintInfo(string nameParameter, string zipCodeParameter)
					{
						Console.WriteLine($"{nameParameter} lives in zip code {zipCodeParameter}");
					}

				public static void Example17()
					{
						bool equal = AreEqual(8, 6);

						if (equal)
							{
								Console.WriteLine("Values are equal");
							}
						else
							{
								Console.WriteLine("Values are not equal");
							}
					}

				static bool AreEqual(int number1Parameter, int number2Parameter)
					{
						bool outcome = number1Parameter == number2Parameter;
						return outcome;
					}

				public static void Example18()
					{
						bool equal = AreEqual(5.0, 5.0);

						if (equal)
							{
								Console.WriteLine("Values are equal");
							}
						else
							{
								Console.WriteLine("Values are not equal");
							}
					}

				static bool AreEqual(object value1Parameter, object value2Parameter)
					{
						bool outcome = value1Parameter == value2Parameter;
						return outcome;
					}

				public static void Example19()
					{
						bool equal = CompareValues<int>(11, 10);

						if (equal)
							{
								Console.WriteLine("Values are equal");
							}
						else
							{
								Console.WriteLine("Values are not equal");
							}
					}			

				static bool CompareValues<Type>(Type value1Parameter, Type value2Parameter)  // Generic method
					{
						bool outcome = value1Parameter.Equals(value2Parameter);
						return outcome;
					}

				public static void Example20()
					{
						bool equal = CompareTypes(10, 20.3);

						if (equal)
							{
								Console.WriteLine("Types are equal");
							}
						else
							{
								Console.WriteLine("Types are not equal");
							}
					}

				static bool CompareTypes<Type>(Type Type1Parameter, Type type2Parameter)  // Generic method
					{
						bool outcome = typeof(Type).Equals(typeof(Type));
						return outcome;
					}

				public static void Example21()
					{
						// Initializing an int and a string array with values
						int[] intArray = new int[3] { 1, 2, 3 };
						string[] stringArray = new string[3] { "Rock", "Paper", "Scissors" };

						DisplayElements(intArray);     // Calls the DisplayElements int type method
						DisplayElements(stringArray);  // invokes the DisplayElements string type method
					}

				static void DisplayElements<Type>(Type[] arrays)  // Generic method - alternative to methods with equal parameters of the same type
					{
						Console.Write($"The values for the {arrays} array are: ");
						foreach (var index in arrays)  // iterates through the elements in each array
							{
								Console.Write($"{index} ");
							}
						Console.WriteLine();
					}

				public static void Example22()  // Generic class
					{
						Console.Write("What is your name? ");
						string name = Console.ReadLine();

						Console.Write("What is your age? ");
						int age = int.Parse(Console.ReadLine());

						// Instantiate an object of the Generic class
						Employees<string, int> types = new Employees<string, int>(name, age);
						types.DisplayGenericTypes();
					}

				public static void Example23()
					{
						AddNumbers(10, 20);    // method overloading makes the 3rd parameter optional
					}

				static void AddNumbers(int firstNumber, int secondNumber)
					{
						AddNumbers(firstNumber, secondNumber, null);
					}

				static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers)
					{
						int result = firstNumber + secondNumber;

						if (restOfNumbers != null)
							{
								foreach (int index in restOfNumbers)
									{
										result += index;
									}
							}
						Console.WriteLine($"The sum of all numbers is: {result}");
					}

				public static void Example24()
					{
						MultiplyNumbers(1, 3, new int[] {5, 10});
					}

				static void MultiplyNumbers(int firstNumber, int secondNumber, int[] restOfNumbers = null)    // // parameter defaults can make the 3rd parameter optional
					{
						int result = firstNumber * secondNumber;

						if (restOfNumbers != null)
							{
								foreach (int index in restOfNumbers)
									{
										result *= index;
									}
							}
						Console.WriteLine($"The product of all numbers is: {result}");
					}

				static void Example25()
					{
						NamedParameters(1, c: 2);  // named parameters can make parameter default values optional
					}

				static void NamedParameters(int a, int b = 10, int c = 20)    
					{
						Console.WriteLine($"The value of A is: {a}");
						Console.WriteLine($"The value of B is: {b}");
						Console.WriteLine($"The value of C is: {c}");
					}

				static void Example26()
					{
						int x = 5;
						Console.WriteLine($"The value of x is {x}");
					}

				static void Example27()
					{
						IntXParameter(5);
					}

				static void IntXParameter(int x)
					{
						Console.WriteLine($"The value of x is {x}");
					}

				static void Example28()
					{
						Console.Write("Please enter a number: ");
						int response = int.Parse(Console.ReadLine());
						
						Console.WriteLine($"Factorial of {response} = {Factorial(response)}");
					}

				static double Factorial(int number)
					{
						double factorial = 1;
						
						if (number == 0)
							{
								return 1;
							}

						// 4! = 4 * 3 * 2 * 1 = 24
						for (int i = number; i >= 1; i--)
							{
								factorial *= i;
							}
						return factorial;
					}

				static void Example29()
					{
						Console.Write("Please enter a number: ");
						int response = int.Parse(Console.ReadLine());
						
						Console.WriteLine($"Factorial of {response} = {Recursion(response)}");
					}

				static double Recursion(int number)
					{
						if (number == 0)
							{
								return 1;
							}

						// 4! = 4 * (4-1) * (4-2) * (4-3) = 24
						return number * Factorial(number - 1);
					}
			}
	}
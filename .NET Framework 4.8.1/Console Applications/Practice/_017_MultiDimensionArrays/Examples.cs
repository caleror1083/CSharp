using System;

// Namespaces
namespace _017_MultiDimensionArrays
	{
		internal class Examples
			{
				// Methods(Parameters)
				public void ProcessExamples()
					{
						Start:
							Console.Write($"Please select an example from 1-5: ");
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
						// If you define arrName[2,2] you are saying you want to have 2 rows high and 2 columns across
						int[,] rectArray = new int[2, 2];  // declares a rectangular array with no values [0,0]-[0,1], [1,0]-[1,1]

						// Initializing the 2-dimensional array with values
						rectArray[0, 0] = 10;
						rectArray[0, 1] = 20;
						rectArray[1, 0] = 30;
						rectArray[1, 1] = 40;

						// Printing the values of each row/column on a separate line
						Console.WriteLine($"{rectArray[0,0]} ");
						Console.WriteLine($"{rectArray[0,1]} ");
						Console.WriteLine($"{rectArray[1,0]} ");
						Console.WriteLine($"{rectArray[1,1]} ");
						Console.WriteLine();
					}

				static void Example2()
					{
						// declaration, initialization and assigning a multi dimensional array of integer values by 2 rows, 2 columns
						int[,] numberGrid = {
						                        {10, 20}, // {0,0} {0,1}
												{30, 40}  // {1,0} {1,1}
											};

						// Printing all values of a 2D array individually on a single line
						Console.Write($"{numberGrid[0, 0]} ");
						Console.Write($"{numberGrid[0, 1]} ");
						Console.Write($"{numberGrid[1, 0]} ");
						Console.Write($"{numberGrid[1, 1]} ");
						Console.WriteLine("\n");

						for (int x = 0; x < numberGrid.GetLength(0); x++)
							{
								for (int y = 0; y < numberGrid.GetLength(1); y++)
									{
										Console.WriteLine($"Index ({x},{y}) is value {numberGrid[x, y]}");
									}
							}
						Console.WriteLine();
					}

				static void Example3()
					{
						string[,] parkingLot = {
						                           {"Mustang", "F-150", "Explorer"},
												   {"Corvette", "Camaro", "Silverado"},
												   {"Corolla", "Camry", "Rav4"}
												};

						parkingLot[0, 2] = "Fusion";    // updating the Explorer value of index in 0, 2 of the array

						foreach (string car in parkingLot)
							{
								Console.WriteLine(car);
							}
						Console.WriteLine();

					}

				static void Example4()
					{
						string[,] parkingLot = {
												   { "Mustang", "F-150", "Explorer"},
												   { "Corvette", "Camaro", "Silverado"},
												   { "Corolla", "Camry", "Rav4"}
											   };

						// Printing the values of a multi dimensional array by rows and columns
						for (int index1 = 0; index1 < parkingLot.GetLength(0); index1++)
							{
								for (int index2 = 0; index2 < parkingLot.GetLength(1); index2++)
									{
										Console.Write($"{parkingLot[index1, index2]} ");
									}
								Console.WriteLine();
							}
						Console.WriteLine();
					}

				static void Example5()
					{
						string[,] custNames = new string[2,2] {
						                                          {"Bob", "Smith"},
																  {"Sally", "Marks"}
															  };
						Console.Write("What row do you want: ");
						int x = int.Parse(Console.ReadLine());

						Console.Write("What column do you want: ");
						int y = int.Parse(Console.ReadLine());

						Console.WriteLine($"Value at ({x},{y}) is {custNames.GetValue(1,1)}");  // Returns the value at the specified position in the 2-dimensional array
						Console.WriteLine();

						for (int i = 0; i < custNames.GetLength(0); i++)    // Cycle through the multidimensional array - Get length of multidimensional array column
							{
								for(int j = 0; j < custNames.GetLength(1); j++)    // Get length of multidimensional array row
									{
										Console.Write($"{custNames.GetValue(i,j)} ");
									}
								Console.WriteLine();
							}	
						// An array like arrName[2,2,3] would be like a stack of 3 spread sheets with 2 rows and 2 columns worth of data on each page
					}
			}
	}
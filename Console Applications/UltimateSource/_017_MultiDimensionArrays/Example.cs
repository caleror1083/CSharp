// Robert Calero - App displaying multidimensional arrays
using System;

class Example
	{
		public void Results()
			{
				/* Multidimensional arrays
                   When you define an array like arrName[5] you are saying you want to create boxes stacked vertically */
				/* If you define arrName[5,3] you are saying you want to have 5 rows high and 3 across */
				Console.WriteLine("Example 1: Multi dimensional arrays");
				int[,] multArray = new int[5, 3];    // declares a multi dimensional array with no values [0,0]-[0,2], [4,0]-[4,2]
				multArray[0,0] = 10;
				multArray[0,1] = 20;
				multArray[0,2] = 30;
				multArray[1,0] = 40;

				Console.WriteLine($"{multArray[0,0]} ");
				Console.WriteLine($"{multArray[0,1]} ");
				Console.WriteLine($"{multArray[0,2]} ");
				Console.WriteLine($"{multArray.GetValue(1,0)} ");
				Console.WriteLine();

				Console.WriteLine("Example 2: Printing all values of a 2D array individually on a single line");
				// declaration, initialization and assigning a multi dimensional array of integer values by 3 rows, 2 columns
				int[,] numberGrid = {
										{1, 2},
										{3, 4},
										{5, 6}
									};

				Console.Write($"{numberGrid[0, 0]} ");    // 1
				Console.Write($"{numberGrid[0, 1]} ");    // 2
				Console.Write($"{numberGrid[1, 0]} ");    // 3
				Console.Write($"{numberGrid[1, 1]} ");    // 4
				Console.Write($"{numberGrid[2, 0]} ");    // 5
				Console.Write($"{numberGrid[2, 1]} ");    // 6
				Console.WriteLine("\n");

				for (int x = 0; x < numberGrid.GetLength(0); x++)
					{
						for (int y = 0; y < numberGrid.GetLength(1); y++)
							{
								Console.WriteLine($"Index ({x},{y}) is value {numberGrid[x, y]}");
							}
					}
				Console.WriteLine();

				Console.WriteLine("Example 3: Updating the value of an individual index in a multi dimensional array and printing the values");
				string[,] parkingLot = {
									       { "Mustang", "F-150", "Explorer"},
									       { "Corvette", "Camaro", "Silverado"},
									       { "Corolla", "Camry", "Rav4"}
									   };

				parkingLot[0, 2] = "Fusion";    // updating the value of index in 0, 2 of the array

				foreach (string car in parkingLot)
					{
						Console.WriteLine(car);
					}
				Console.WriteLine();

				Console.WriteLine("Example 4: Printing the values of a multi dimensional array by rows and columns");
				for (int index1 = 0; index1 < parkingLot.GetLength(0); index1++)
					{
						for (int index2 = 0; index2 < parkingLot.GetLength(1); index2++)
							{
								Console.Write($"{parkingLot[index1, index2]} ");
							}
						Console.WriteLine();
					}
				Console.WriteLine();

				// If you define arrName[2,2] you are saying
				// you want to have 2 rows high and 2 across
				string[,] custNames = new string[2,2] { { "Bob", "Smith" }, { "Sally", "Marks" } };
				
				Console.WriteLine("MD Value at (1,1): {0}", custNames.GetValue(1,1));    // Get value in MD array
				Console.WriteLine();

				for (int ii = 0; ii < custNames.GetLength(0); ii++)    // Cycle through the multidimensional array - Get length of multidimensional array column
					{
						for(int j = 0; j < custNames.GetLength(1); j++)    // Get length of multidimensional array row
							{
								Console.Write("{0} ",custNames[ii,j]);
							}
						Console.WriteLine();
					}	
            // An array like arrName[2,2,3] would be like a stack of 3 spread sheets with 2 rows and 2 columns worth of data on each page
			}
	}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespaces
namespace Tetris
	{
		// Classes
		internal class GameGrid
			{
				// Fields
				private readonly int[,] _Grid; // 2d rectangular array - 1st dim is rows, 2nd dim is columns

				// Properties
				public int Rows { get; }  // Number of rows property
				public int Columns { get; }  // Number of columns property
				
				// Indexers
				public int this[int r, int c]  // indexer to provide access to the array
					{
						// This will use indexing directly on a GameGrid object
						get => _Grid[r, c];
						set => _Grid[r, c] = value;
					}

				// Constructors(Parameters)
				public GameGrid(int rows, int columns)  // Constructor will take the number of rows and columns as parameters
					{
						Rows = rows;  // Save the number of rows
						Columns = columns;  // Save the number of columns
						_Grid = new int[rows, columns];  // Initialize the array
					}
			}
	}
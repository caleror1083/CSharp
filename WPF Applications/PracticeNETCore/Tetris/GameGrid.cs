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

				// Methods(Parameters)
				public bool IsInside(int r, int c)  // Check if a given row and column is inside the grid or not
					{
						// To be inside the grid, the row must be greater than or equal to 0 and less than the number of rows
						// The column must be greater than or equal to 0 and less than the number of columns
						return r >= 0 && r < Rows && c >= 0 && c < Columns;
					}

				public bool IsEmpty(int r, int c)  // Checks if a given cell is empty or not
					{
						// To be empty, the cell it must be inside the grid and the value at that entry in the array must be 0
						return IsInside(r, c) && _Grid[r, c] == 0;
					}

				public bool IsRowFull(int r)  // Checks if an emtire row is full
					{
						for (int c = 0; c < Columns; c++)
							{
								if (_Grid[r, c] == 0)
									{
										return false;
									}
							}
						return true;
					}

				public bool IsRowEmpty(int r)  // Checks if an entire row is empty
					{
						for (int c = 0; c < Columns; c++)
							{
								if (_Grid[r, c] != 0)
									{
										return false;
									}
							}
						return true;
					}

				private void ClearRow(int r)  // When there are full rows, they need to be cleared
					{
						for (int c = 0; c < Columns; c++)
							{
								_Grid[r, c] = 0;
							}
					}

				 private void MoveRowDown(int r, int numRows)  // Move the rows down by a certain number of rows
					{
						for (int c = 0; c < Columns; c++)
							{
								_Grid[r + numRows, c] = _Grid[r, c];
								_Grid[r, c] = 0;
							}
					}

				public int ClearFullRows()
					{
						// The cleared variable starts at 0 and we move from the bottom row towards the top
						int cleared = 0;

						for (int r = Rows - 1; r >= 0; r--)
							{
								if (IsRowFull(r))  // Check if the current row is full, if it is we clear it and increment cleared
									{
										ClearRow(r);
										cleared++;
									}
								else if (cleared > 0)  // If cleared is greater than 0, we move the current row down by the number of cleared rows
									{
										MoveRowDown(r, cleared);
									}
							}
						return cleared;  // Return the number of cleared rows
					}
			}
	}
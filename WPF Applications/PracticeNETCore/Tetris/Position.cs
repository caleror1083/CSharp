// Namespaces
namespace Tetris
	{
		// Classes
		internal class Position
			{
				// Properties
				public int Row { get; set; }
				public int Column { get; set; }

				// Constructors(Parameters)
				public Position(int row, int column)
					{
						Row = row;
						Column = column;
					}
			}
	}
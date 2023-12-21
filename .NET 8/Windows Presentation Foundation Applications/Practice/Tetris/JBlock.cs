// Namespaces
namespace Tetris
	{
		// Classes
		internal class JBlock : Block
			{
				// Fields
				// Store the tiles positions for the four rotation states
				private readonly Position[][] _Tiles = new Position[][]  
					{
						new Position[] { new(0, 0), new(1, 0), new(1, 1), new(1, 2) },
						new Position[] { new(0, 1), new(0, 2), new(1, 1), new(2, 1) },
						new Position[] { new(1, 0), new(1, 1), new(1, 2), new(2, 2) },
						new Position[] { new(0, 1), new(1, 1), new(2, 0), new(2, 1) }
					};

				// Properties
				public override int Id => 2;
				protected override Position StartOffset => new(0, 3); // Makes the block spawn in the middle of the top row
				protected override Position[][] Tiles => _Tiles;  // Return the _Tiles array field
			}
	}
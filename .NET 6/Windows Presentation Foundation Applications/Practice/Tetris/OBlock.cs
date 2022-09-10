namespace Tetris
	{
		internal class OBlock : Block
			{
				// Fields
				// This block occupies the same positions in every rotation state
				private readonly Position[][] _Tiles = new Position[][]
					{
						new Position[] { new(0, 0), new(0, 1), new(1, 0), new(1, 1) }
					};

				// Properties
				public override int Id => 4;
				protected override Position StartOffset => new(0, 4);
				protected override Position[][] Tiles => _Tiles;
			}
	}
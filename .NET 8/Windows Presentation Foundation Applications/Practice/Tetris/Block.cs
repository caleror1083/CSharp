using System.Collections.Generic;

// Namespaces
namespace Tetris
	{
		// Classes
		internal abstract class Block
			{
				// Fields
				// Store the current rotation state and the current offset
				private int _RotationState;
				private readonly Position _Offset;

				// Properties
				public abstract int Id { get; }  // An integer Id which we need to distinguish the blocks
				protected abstract Position StartOffset { get; }  // A start offset which decides where the block spawns in the grid
				protected abstract Position[][] Tiles { get; }  // 2d Position array which contains the tile positions in the 4 rotation states

				// Constructors(Parameters)
				public Block()  // Set the _Offset equal to the StartOffset
					{
						_Offset = new Position(StartOffset.Row, StartOffset.Column);
					}

				// Methods(Parameters)
				public IEnumerable<Position> TilePositions()  // Returns the grid positions occupied by the block factoring in the current rotation and offset
					{
						// Moves over the tile positions in the current rotation state and as the row offset and column offset
						foreach (Position p in Tiles[_RotationState])
							{
								yield return new Position(p.Row + _Offset.Row, p.Column + _Offset.Column);
							}
					}

				public void RotateCW()  // Rotates the block 90' clockwise by incrementing the current rotation state wrapping around to 0 if it's in the final state
					{
						_RotationState = (_RotationState + 1) % Tiles.Length;
					}

				public void RotateCCW()  // Rotates the block 90' counterclockwise
					{
						if (_RotationState == 0)
							{
								_RotationState = Tiles.Length - 1;
							}
						else
							{
								_RotationState--;
							}
					}

				public void Move(int rows, int columns)  // Moves the block by a given number of rows and columns
					{
						_Offset.Row += rows;
						_Offset.Column += columns;
					}

				public void Reset()  // Reset method which resets the rotation and position
					{
						_RotationState = 0;
						_Offset.Row = StartOffset.Row;
						_Offset.Column = StartOffset.Column;
					}
			}
	}
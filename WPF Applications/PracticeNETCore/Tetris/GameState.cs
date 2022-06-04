using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
	{
		internal class GameState  // Handles the interactions between the classes
			{
				// Fields
				private Block _CurrentBlock;

				// Properties				
				public Block CurrentBlock  // Property with a backing field for the current block
					{
						get => _CurrentBlock;
						private set  // When we update the current block the reset method is called to set the correct start position and rotation
							{
								_CurrentBlock = value;
								_CurrentBlock.Reset();
							}
					}
				public GameGrid GameGrid { get; }  // Properties for the game grid
				public BlockQueue BlockQueue { get; }  // Properties for the block queue
				public bool GameOver { get; private set; }  // Properties for a game over boolean

				// Constructors(Parameters)
				public GameState()
					{
						GameGrid = new GameGrid(22, 10);  // Initialize the game grid with 22 rows and 10 columns
						BlockQueue = new BlockQueue();  // Initialize the block queue
						CurrentBlock = BlockQueue.GetAndUpdate();  // Use it to get a random block for the current block property
					}

				// Methods(Parameters)
				private bool BlockFits()  // Checks if the current block is in a legal position or not
					{
						foreach (Position p in CurrentBlock.TilePositions())  // Loops over the tile positions of the current block
							{
								if (!GameGrid.IsEmpty(p.Row, p.Column))  // If any of them are outside the grid or overlapping another tile then we retuen false
									{
										return false;
									}
							}
						return true;  // Otherwise if we get through the entire loop we return true
					}

				public void RotateBlockCW()  // Method to rotate the current block clockwise
					{
						CurrentBlock.RotateCW();

						if (!BlockFits()) // Only if it's possible to do so from where it is
							{
								CurrentBlock.RotateCCW();  // Rotating the block and if it ends up in an illegal position then we rotate it back
							}
					}

				public void RotateBlockCCW()  // Method to rotate the current block counterclockwise
					{
						CurrentBlock.RotateCCW();

						if (!BlockFits())
							{
								CurrentBlock.RotateCW();
							}
					}

				public void MoveBlockLeft()  // Method to move the current block left
					{
						CurrentBlock.Move(0, -1);

						if (!BlockFits())
							{
								CurrentBlock.Move(0, 1);
							}
					}

				public void MoveBlockRight()  // Method to move the current block right
					{
						CurrentBlock.Move(0, 1);

						if (!BlockFits())
							{
								CurrentBlock.Move(0, -1);
							}
					}

				private bool IsGameOver()
					{
						return !(GameGrid.IsRowEmpty(0) && GameGrid.IsRowEmpty(1));
					}
			}
	}
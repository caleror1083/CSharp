using System;

// Namespaces
namespace Tetris
	{
		// Classes
		internal class BlockQueue
			{
				// Fields
				// Picks the next block in the game
				// Block array with an instance of the 7 block classes which we will recycle
				private readonly Block[] _Blocks = new Block[] { new IBlock(), new JBlock(), new LBlock(), new OBlock(), new SBlock(), new TBlock(), new ZBlock() };
				private readonly Random _Random = new(); // Random object also needed

				// Properties
				public Block NextBlock { get; private set; }  // Property for the next block in the queue - This property will be previewed in the UI during gameplay

				// Constructors(Parameters)
				public BlockQueue()  // Initialize the next block with a random block
					{
						NextBlock = RandomBlock();
					}

				// Methods(Parameters)
				private Block RandomBlock()  // Method that returns a random block
					{
						return _Blocks[_Random.Next(_Blocks.Length)];
					}

				public Block GetAndUpdate()  // Returns the next block and updates the Property
					{
						Block block = NextBlock;

						do
							{
								NextBlock = RandomBlock();
							}
						while (block.Id == NextBlock.Id);
						return block;
					}
			}
	}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// Namespaces
namespace Tetris
	{
		// Classes
		public partial class MainWindow : Window
			{
				// Fields
				private readonly ImageSource[] _TileImages = new ImageSource[]
					{
						new BitmapImage(new Uri("assets/images/TileEmpty.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/TileCyan.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/TileBlue.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/TileOrange.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/TileYellow.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/TileGreen.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/TilePurple.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/TileRed.png", UriKind.Relative))
					};
				private readonly ImageSource[] _BlockImages = new ImageSource[]
					{
						new BitmapImage(new Uri("assets/images/Block-Empty.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/Block-I.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/Block-J.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/Block-L.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/Block-O.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/Block-S.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/Block-T.png", UriKind.Relative)),
						new BitmapImage(new Uri("assets/images/Block-Z.png", UriKind.Relative))
					};
				private readonly Image[,] _ImageControls;
				private GameState _GameState = new GameState();

				// Constructors(Parameters)
				public MainWindow()
					{
						InitializeComponent();
						_ImageControls = SetupGameCanvas(_GameState.GameGrid);
					}

				// Methods(Parameters)
				private Image[,] SetupGameCanvas(GameGrid grid)
					{
						Image[,] imageControls = new Image[grid.Rows, grid.Columns];
						int cellSize = 25;

						for (int r = 0; r < grid.Rows; r++)
							{
								for (int c = 0; c < grid.Columns; c++)
									{
										Image imageControl = new Image
											{
												Width = cellSize,
												Height = cellSize
											};

										Canvas.SetTop(imageControl, (r - 2) * cellSize);
										Canvas.SetLeft(imageControl, c * cellSize);
										GameCanvas.Children.Add(imageControl);
										imageControls[r, c] = imageControl;
									}
							}
						return imageControls;
					}

				private void DrawGrid(GameGrid grid)
					{
						for (int r = 0; r < grid.Rows; r++)
							{
								for (int c = 0; c < grid.Columns; c++)
									{
										int id = grid[r, c];
										_ImageControls[r, c].Source = _TileImages[id];
									}
							}
					}

				private void DrawBlock(Block block)
					{
						foreach (Position p in block.TilePositions())
							{
								_ImageControls[p.Row, p.Column].Source = _TileImages[block.Id];
							}
					}

				private void Draw(GameState gameState)
					{
						DrawGrid(gameState.GameGrid);
						DrawBlock(gameState.CurrentBlock);
					}

				private void Window_KeyDown(object sender, KeyEventArgs e)
					{

					}

				private void GameCanvas_Loaded(object sender, RoutedEventArgs e)
					{
						Draw(_GameState);

					}

				private void PlayAgain_Click(object sender, RoutedEventArgs e)
					{

					}
			}
	}
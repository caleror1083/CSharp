using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tetris;
	
public partial class MainWindow : Window
{
    private readonly ImageSource[] _TileImages =
    [
        new BitmapImage(new Uri("assets/images/TileEmpty.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/TileCyan.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/TileBlue.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/TileOrange.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/TileYellow.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/TileGreen.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/TilePurple.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/TileRed.png", UriKind.Relative))
	  ];
    private readonly ImageSource[] _BlockImages =
	  [
		    new BitmapImage(new Uri("assets/images/Block-Empty.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/Block-I.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/Block-J.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/Block-L.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/Block-O.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/Block-S.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/Block-T.png", UriKind.Relative)),
		    new BitmapImage(new Uri("assets/images/Block-Z.png", UriKind.Relative))
	  ];
    private readonly Image[,] _ImageControls;
    private readonly int _MaxDelay = 1000;
    private readonly int _MinDelay = 75;
    private readonly int _DelayDecrease = 25;
    private GameState _GameState = new();

    public MainWindow()
	  {
		    InitializeComponent();
		    _ImageControls = SetupGameCanvas(_GameState.GameGrid);
	  }

    private Image[,] SetupGameCanvas(GameGrid grid)
	  {
		    Image[,] imageControls = new Image[grid.Rows, grid.Columns];
		    int cellSize = 25;

		    for (int r = 0; r < grid.Rows; r++)
			  {
				    for (int c = 0; c < grid.Columns; c++)
					  {
						    Image imageControl = new()
                {
								    Width = cellSize,
								    Height = cellSize
							  };
						    Canvas.SetTop(imageControl, (r - 2) * cellSize + 10);
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
						    _ImageControls[r, c].Opacity = 1;
						    _ImageControls[r, c].Source = _TileImages[id];
					  }
			  }
	  }

private void DrawBlock(Block block)
	{
		foreach (Position p in block.TilePositions())
			{
				_ImageControls[p.Row, p.Column].Opacity = 1;
				_ImageControls[p.Row, p.Column].Source = _TileImages[block.Id];
			}
	}

private void DrawNextBlock(BlockQueue blockQueue)
	{
		Block next = blockQueue.NextBlock;
		NextImage.Source = _BlockImages[next.Id];
	}

private void DrawHeldBlock(Block heldBlock)
	{
		if (heldBlock == null)
			{
				HoldImage.Source = _BlockImages[0];
			}
		else
			{
				HoldImage.Source = _BlockImages[heldBlock.Id];
			}
	}

private void DrawGhostBlock(Block block)
	{
		int dropDistance = _GameState.BlockDropDistance();

		foreach (Position p in block.TilePositions())
			{
				_ImageControls[p.Row + dropDistance, p.Column].Opacity = 0.25;
				_ImageControls[p.Row + dropDistance, p.Column].Source = _TileImages[block.Id];
			}
	}


private void Draw(GameState gameState)
	{
		DrawGrid(gameState.GameGrid);
		DrawGhostBlock(gameState.CurrentBlock);
		DrawBlock(gameState.CurrentBlock);
		DrawNextBlock(gameState.BlockQueue);
		DrawHeldBlock(gameState.HeldBlock);
		ScoreText.Text = $"Score: {gameState.Score}";
	}

private async Task GameLoop()
	{
		Draw(_GameState);

		while (!_GameState.GameOver)
			{
				int delay = Math.Max(_MinDelay, _MaxDelay - (_GameState.Score * _DelayDecrease));
				await Task.Delay(delay);
				_GameState.MoveBlockDown();
				Draw(_GameState);
			}
		GameOverMenu.Visibility = Visibility.Visible;
		FinalScoreText.Text = $"Score: {_GameState.Score}";
	}

private void Window_KeyDown(object sender, KeyEventArgs e)
	{
		if (_GameState.GameOver)
			{
				return;
			}

		switch (e.Key)
			{
				case Key.Left:
					_GameState.MoveBlockLeft();
					break;
				case Key.Right:
					_GameState.MoveBlockRight();
					break;
				case Key.Down:
					_GameState.MoveBlockDown();
					break;
				case Key.Up:
					_GameState.RotateBlockCW();
					break;
				case Key.Z:
					_GameState.RotateBlockCCW();
					break;
				case Key.C:
					_GameState.HoldBlock();
					break;
				case Key.Space:
					_GameState.DropBlock();
					break;
				default:
					return;
			}
		Draw(_GameState);
	}

private async void GameCanvas_Loaded(object sender, RoutedEventArgs e)
	{
		await GameLoop();
	}

private async void PlayAgain_Click(object sender, RoutedEventArgs e)
	{
		_GameState = new GameState();
		GameOverMenu.Visibility = Visibility.Hidden;
		await GameLoop();
	}
}
	
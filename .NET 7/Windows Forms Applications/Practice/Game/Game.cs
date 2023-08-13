using Game.Elements;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game;

public partial class Game : Form
{
    private readonly GameTime _gameTime;
    private readonly Timer _timer;
    public event EventHandler<MouseEventArgs> Canvas_MouseUp;

    protected Keyboard Keyboard { get; set; }

    public Game()
    {
        InitializeComponent();
        _gameTime = new GameTime();
        Keyboard = new Keyboard();
        _timer = new Timer { Interval = 1000 / 30 };

        _timer.Tick += (sender, e) =>
        {
            var _now = DateTime.Now;
            _gameTime.FrameMilliseconds = (int)(_now - _gameTime.FrameDate).TotalMilliseconds;
            _gameTime.FrameDate = _now;
            Application.DoEvents();
            Update(_gameTime);
            Keyboard.Clear();

            using var drawHandler = new DrawHandler(Canvas.Width, Canvas.Height);
            Draw(drawHandler);
            Canvas.Image = drawHandler.BaseImage;
        };

        _timer.Start();
    }

    private void PcCanvas_MouseUp(object sender, MouseEventArgs e)
    {
        Canvas_MouseUp?.Invoke(sender, e);
    }

    private void Game_KeyDown(object sender, KeyEventArgs e)
    {
        Keyboard.SetKey(e.KeyData);
    }

    protected static Image Load_Image(string path)
    {
        try
        {
            return Image.FromFile(path);
        }
        catch
        {
            MessageBox.Show($"Load File Error\n{path}");
            return null;
        }
    }

    protected new virtual void Update(GameTime gameTime) {}
    public virtual void Draw(DrawHandler drawHandler) {}
}
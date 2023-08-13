using System.Windows.Forms;

namespace Game.Elements;

public class Keyboard
{
    public bool Left { get; private set; }
    public bool Right { get; private set; }
    public bool Up { get; private set; }
    public bool Down { get; private set; }
    public bool Space { get; private set; }

    public void SetKey(Keys key)
    {
        if (key == Keys.Left) Left = true;
        if (key == Keys.Right) Right = true;
        if (key == Keys.Up) Up = true;
        if (key == Keys.Down) Down = true;
        if (key == Keys.Space) Space = true;
    }

    public void Clear()
    {
        Left = false;
        Right = false;
        Up = false;
        Down = false;
        Space = false;
    }
}
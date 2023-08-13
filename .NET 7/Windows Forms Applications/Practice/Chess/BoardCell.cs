using System.Drawing;

namespace Chess;

public class BoardCell
{
    public Point ScreenPosition { get; set; }
    public bool CanMove { get; set; }
}
using System.Drawing;

namespace Chess.Elements;

public class Piece_Move
{
    public Point Direction { get; set; }
    public Move_Type Type { get; set; }
    public bool IsLinear { get; set; }

    public Piece_Move(int x, int y, bool isLinear = true, Move_Type type = Move_Type.General)
    {
        Direction = new Point(x, y);
        Type = type;
        IsLinear = isLinear;
    }
}
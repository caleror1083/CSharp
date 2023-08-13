using Game.Elements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Elements;

public abstract class Piece_Base : Sprite
{
    public Piece_Color Color { get; set; }
    public Point Location { get; set; }
    public bool Selected { get; set; }
    public Piece_Move[] Moves { get; set; }
    public Point[] EnabledMoves { get; set; }
    public Image SelectedImage { get; set; }

    public Piece_Base(Image image, Piece_Color color) : base(image, new Point())
    {
        Color = color;
    }

    public override void Draw(DrawHandler drawHandler)
    {
        if (Selected)
        {
            drawHandler.Draw(SelectedImage, Position);
        }

        base.Draw(drawHandler);
    }
}
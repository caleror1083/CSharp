using System.Drawing;

namespace Game.Elements;

public class Sprite
{
    public Image Image { get; set; }
    public Point Position { get; set; }
    public bool Visible { get; set; }

    public Sprite(Image image, Point position)
    {
        Image = image;
        Position = position;
        Visible = true;
    }

    public virtual void Draw(DrawHandler drawHandler)
    {
        if (Visible)
        {
            drawHandler.Draw(Image, Position);
        }
    }
}
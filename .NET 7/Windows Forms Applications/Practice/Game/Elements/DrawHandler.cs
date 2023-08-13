using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Game.Elements;

[SupportedOSPlatform("windows")]
public class DrawHandler : IDisposable
{
    public Image BaseImage { get; private set; }
    private Graphics Graphics { get; set; }

    public DrawHandler(int width, int height)
    {
        BaseImage = new Bitmap(width, height);
        Graphics = Graphics.FromImage(BaseImage);
    }

    public void Dispose()
    {
        Graphics.Dispose();
        BaseImage = null;
        GC.SuppressFinalize(this);
    }

    public void Draw(Image image, Point position)
    {
        if (image != null)
        {
            Graphics.DrawImage(image, position.X, position.Y, image.Width, image.Height);
        }
    }
}
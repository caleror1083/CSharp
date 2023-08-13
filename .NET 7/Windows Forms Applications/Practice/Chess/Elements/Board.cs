using Game.Elements;
using System.Drawing;

namespace Chess.Elements;

public class Board : Sprite
{
    private int TileSize { get; set; }
    public Image Image_BlackTiles { get; set; }
    public Image Image_WhiteTiles { get; set; }
    private Image Move_Image { get; set; }
    public BoardCell[,] Cells { get; set; }

    public Board(Image whiteTileImage, Image blackTileImage, Image moveTileImage, int tileSize) : base(null, new Point())
    {
        TileSize = tileSize;
        Move_Image = moveTileImage;
        Image_BlackTiles = blackTileImage;
        Image_WhiteTiles = whiteTileImage;
        Cells = new BoardCell[8, 8];

        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                int _x = (x * TileSize) + 5 * (x + 1);
                int _y = (y * TileSize) + 5 * (y + 1);

                Cells[x, y] = new BoardCell()
                {
                    ScreenPosition = new Point(_x, _y),
                };
            }
        }
    }

    public void Clear_EnabledMoves()
    {
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                Cells[x, y].CanMove = false;
            }
        }
    }

    public override void Draw(DrawHandler drawHandler)
    {
        drawHandler.Draw(Image, Position);

        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8 ; y++)
            {
                Image _tile = (x + y) % 2 == 0 ? Image_WhiteTiles : Image_BlackTiles;
                drawHandler.Draw(_tile, Cells[x, y].ScreenPosition);

                if (Cells[x, y].CanMove)
                {
                    drawHandler.Draw(Move_Image, Cells[x, y].ScreenPosition);
                }
            }
        }
    }
}
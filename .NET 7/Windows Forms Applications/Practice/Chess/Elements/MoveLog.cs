using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Elements;

public class MoveLog
{
    public Piece_Base Piece { get; set; }
    public Point Original_Location { get; set; }
    public Point New_Location { get; set; }
}
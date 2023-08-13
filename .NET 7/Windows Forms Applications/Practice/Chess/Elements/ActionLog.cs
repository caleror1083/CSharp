using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Elements;

public class ActionLog
{
    public List<MoveLog> Moves { get; set; }
    public List<Piece_Base> Removed_Pieces { get; set; }
    public Piece_Base Added_Piece { get; set; }

    public ActionLog()
    {
        Moves = new List<MoveLog>();
        Removed_Pieces = new List<Piece_Base>();
    }
}
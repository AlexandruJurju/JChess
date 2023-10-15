using ChessText.Model;
using ChessText.Model.PieceLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessText.ChessLogic.Pieces
{
	public class Rook : Piece
	{
		public override PieceType Type => PieceType.Pawn;

		public override Player Color { get; }

		public Piece(Player color)
		{
			Color = color;
		}
	}
}

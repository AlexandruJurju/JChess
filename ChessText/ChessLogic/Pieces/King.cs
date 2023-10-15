using ChessText.Model.PieceLogic;
using ChessText.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
	public class King : Piece
	{
		public override PieceType Type => PieceType.Pawn;

		public override Player Color { get; }

		public King(Player color)
		{
			Color = color;
		}
	}
}

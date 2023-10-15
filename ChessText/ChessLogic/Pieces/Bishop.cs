using ChessText.Model;
using ChessText.Model.PieceLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
	internal class Bishop : Piece
	{
		public override PieceType Type => PieceType.Bishop;

		public override Player Color { get; }

		public Bishop(Player color)
		{
			Color = color;
		}
	}
}

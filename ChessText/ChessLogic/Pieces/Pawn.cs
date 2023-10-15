using ChessText.Model;
using ChessText.Model.PieceLogic;

namespace ChessText.ChessLogic.PieceLogic
{
	public class Pawn : Piece
	{
		public override PieceType Type => PieceType.Pawn;

		public override Player Color { get; }

		public Pawn(Player color)
		{
			Color = color;
		}
	}
}

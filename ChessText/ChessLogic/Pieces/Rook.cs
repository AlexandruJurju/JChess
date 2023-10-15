using ChessText.Model;

namespace ChessLogic
{
	public class Rook : Piece
	{
		public override PieceType Type => PieceType.Pawn;

		public override Player Color { get; }

		public Rook(Player color)
		{
			Color = color;
		}
	}
}

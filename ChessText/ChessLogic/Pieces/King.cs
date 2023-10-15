using System.Collections.Generic;

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

		public override IEnumerable<Move> GenerateMoves(Position origin, Position destination)
		{
			throw new System.NotImplementedException();
		}
	}
}

using System.Collections.Generic;

namespace ChessLogic
{
	public class Bishop : Piece
	{
		public override PieceType Type => PieceType.Bishop;

		public override Player Color { get; }

		public Bishop(Player color)
		{
			Color = color;
		}

		public override IEnumerable<Move> GenerateMoves(Position origin, Position destination)
		{
			throw new System.NotImplementedException();
		}
	}
}

using System.Collections.Generic;

namespace ChessLogic {
	public class Queen : Piece {
		public override PieceType Type => PieceType.Pawn;

		public override Player Color { get; }

		public Queen(Player color) {
			Color = color;
		}

		public override List<Move> GenerateMoves(Position origin, BoardModel board) {
			throw new System.NotImplementedException();
		}
	}
}

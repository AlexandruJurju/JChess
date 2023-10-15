using System.Collections.Generic;

namespace ChessLogic {
	public class Rook : Piece {
		public override PieceType Type => PieceType.Pawn;

		public override Player Color { get; }

		public Rook(Player color) {
			Color = color;
		}

		public override List<Move> GenerateMoves(Position origin, BoardModel board) {
			throw new System.NotImplementedException();
		}
	}
}

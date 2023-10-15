using System.Collections.Generic;

namespace ChessLogic {
	public abstract class Piece {
		public abstract PieceType Type { get; }
		public abstract Player Color { get; }

		public abstract List<Move> GenerateMoves(Position origin, BoardModel board);

		public abstract List<Position> GetAllPossibleDestinations(Position origin, BoardModel board);
	}
}

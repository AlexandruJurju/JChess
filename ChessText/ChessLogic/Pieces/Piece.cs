using System.Collections.Generic;

namespace ChessLogic {
	public abstract class Piece {
		public abstract PieceType Type { get; }
		public abstract Player Color { get; }

		public List<Move> GenerateMoves(Position origin, Board board) {
			List<Move> moves = new List<Move>();
			List<Position> finalPositions = GetAllPossibleDestinations(origin, board);
			foreach (Position finalPosition in finalPositions) {
				moves.Add(new Move(origin, finalPosition));
			}
			return moves;
		}

		public abstract List<Position> GetAllPossibleDestinations(Position origin, Board board);
	}
}

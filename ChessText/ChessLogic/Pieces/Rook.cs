using System.Collections.Generic;

namespace ChessLogic {
	public class Rook : Piece {
		public override PieceType Type => PieceType.Pawn;

		public override Player Color { get; }

		public Rook(Player color) {
			Color = color;
		}

		private static readonly Direction[] moveDirections = new Direction[]{
			Direction.N, Direction.S, Direction.E, Direction.W
		};

		public override List<Move> GenerateMoves(Position origin, BoardModel board) {
			List<Move> moves = new List<Move>();
			List<Position> finalPositions = GetAllPossibleDestinations(origin, board);
			foreach (Position finalPosition in finalPositions) {
				moves.Add(new Move(origin, finalPosition));
			}
			return moves;
		}

		public override List<Position> GetAllPossibleDestinations(Position origin, BoardModel board) {
			List<Position> result = new List<Position>();

			foreach (Direction dir in moveDirections) {
				for (Position pos = origin + dir; board.IsInsideBoard(pos); pos += dir) {
					if (board.IsEmptyPosition(pos)) {
						result.Add(pos);
					} else if (board[pos].Color != this.Color) {
						result.Add(pos);
						continue;
					}
				}
			}

			return result;
		}
	}
}

using System.Collections.Generic;

namespace ChessLogic {
	public class King : Piece {
		public override PieceType Type => PieceType.King;

		public override Player Color { get; }

		// array with all possible move directions
		private static readonly Direction[] moveDirections = new Direction[]
		{
			Direction.N, Direction.S,Direction.E, Direction.W, Direction.NE, Direction.SE, Direction.NW,Direction.SW
		};

		public King(Player color) {
			Color = color;
		}

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
				Position newPos = origin + dir;

				if (!board.IsInsideBoard(newPos)) {
					continue;
				}

				if (board.IsEmptyPosition(newPos)) {
					result.Add(newPos);
				} else if (board[newPos].Color != this.Color) {
					result.Add(newPos);
					continue;
				}
			}

			return result;
		}
	}
}

using System;
using System.Collections.Generic;

namespace ChessLogic {
	public class Bishop : Piece {

		private static readonly Direction[] moveDirections = new Direction[]
		{
			Direction.NW, Direction.NE, Direction.SW, Direction.SE
		};

		public override PieceType Type => PieceType.Bishop;

		public override Player Color { get; }

		public Bishop(Player color) {
			Color = color;
		}

		public override List<Move> GenerateMoves(Position origin, BoardModel board) {
			throw new NotImplementedException("This method or functionality is not implemented yet.");
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

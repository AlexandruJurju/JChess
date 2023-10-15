using System.Collections.Generic;

namespace ChessLogic {
	public class Pawn : Piece {
		public override PieceType Type => PieceType.Pawn;

		public override Player Color { get; }

		public bool FirstMove { get; set; }

		public Direction MainDirection { get; set; }

		private static readonly Direction[] moveDirections = new Direction[]{
			Direction.E, Direction.W
		};

		public Pawn(Player color) {
			Color = color;

			if (Color == Player.White) {
				MainDirection = Direction.N;
			} else {
				MainDirection = Direction.S;
			}

			FirstMove = false;
		}

		public override List<Position> GetAllPossibleDestinations(Position origin, Board board) {
			List<Position> result = new List<Position>();

			Position OneAway = origin + MainDirection;
			if (CanMoveTo(OneAway, board)) {
				result.Add(OneAway);
			}

			if (FirstMove) {
				Position TwoAway = origin + MainDirection * 2;

				if (CanMoveTo(TwoAway, board)) {
					result.Add(TwoAway);
				}

				FirstMove = false;
			} else {
				foreach (Direction dir in moveDirections) {
					Position dest = origin + MainDirection + dir;

					if (CanCapture(dest, board)) {
						result.Add(dest);
					}
				}
			}

			return result;
		}

		private bool CanMoveTo(Position pos, Board board) {
			return board.IsInsideBoard(pos) && board.IsEmptyPosition(pos);
		}

		private bool CanCapture(Position pos, Board board) {
			return board.IsInsideBoard(pos) && board[pos].Color != Color;
		}
	}
}

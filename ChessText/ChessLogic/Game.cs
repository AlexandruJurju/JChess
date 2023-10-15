using System.Collections.Generic;

namespace ChessLogic {
	public class Game {

		public Board Board { get; set; }
		public Player CurrentPlayer { get; set; }

		public Game(Board board) {
			CurrentPlayer = Player.White;
			Board = board;
		}

		public List<Move> GetValidMoves(Position pos) {
			if (Board.IsEmptyPosition(pos) || Board[pos].Color != CurrentPlayer) {
				return new List<Move>();
			}

			return Board[pos].GenerateMoves(pos, Board);
		}

		public void MovePiece(Move move) {
			move.Execute(Board);
			if (CurrentPlayer == Player.White) {
				CurrentPlayer = Player.Black;
			} else {
				CurrentPlayer = Player.White;
			}
		}
	}
}

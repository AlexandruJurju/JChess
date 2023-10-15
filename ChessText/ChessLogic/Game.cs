namespace ChessLogic {
	public class Game {

		public BoardModel Board { get; set; }
		public Player CurrentPlayer { get; set; }

		public Game(BoardModel board) {
			CurrentPlayer = Player.White;
			Board = board;
		}
	}
}

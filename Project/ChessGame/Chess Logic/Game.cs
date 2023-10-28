namespace ChessLogic {
    public class Game {
        public Board Board { get; set; }
        public Player CurrentPlayer { get; set; }

        public Stack<Move> History { get; set; }

        public Game(Board board) {
            CurrentPlayer = Player.White;
            Board = board;
            History = new Stack<Move>();
        }

        public List<Move> GetValidMoves(Position pos) {
            if (Board.IsEmptyPosition(pos) || Board[pos].Color != CurrentPlayer) {
                return new List<Move>();
            }

            return Board[pos].GenerateMoves(pos, Board);
        }

        public void MovePiece(Move move) {
            move.Execute(Board);
            History.Push(move);
            if (CurrentPlayer == Player.White) {
                CurrentPlayer = Player.Black;
            }
            else {
                CurrentPlayer = Player.White;
            }
        }
    }
}
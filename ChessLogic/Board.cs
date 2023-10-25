using ChessLogic.Pieces;

namespace ChessLogic {
    public class Board {
        private Piece[,] board = new Piece[8, 8];

        // indexer, acess elements as if it was an array
        // takes ints row and col as parameters for indexing the board array
        public Piece this[int row, int col] {
            get { return board[row, col]; }
            set { board[row, col] = value; }
        }

        // indexer that takes a position as parameter
        public Piece this[Position pos] {
            get { return board[pos.Row, pos.Col]; }
            set { board[pos.Row, pos.Col] = value; }
        }

        public void InitBoard() {
            // Initialize Black pieces
            board[0, 0] = new Rook(Player.Black);
            board[0, 1] = new Knight(Player.Black);
            board[0, 2] = new Bishop(Player.Black);
            board[0, 3] = new Queen(Player.Black);
            board[0, 4] = new King(Player.Black);
            board[0, 5] = new Bishop(Player.Black);
            board[0, 6] = new Knight(Player.Black);
            board[0, 7] = new Rook(Player.Black);

            /*			for (int i = 0; i < 8; i++) {
                            board[1, i] = new Pawn(Player.Black);
                        }*/

            // Initialize White pieces
            board[7, 0] = new Rook(Player.White);
            board[7, 1] = new Knight(Player.White);
            board[7, 2] = new Bishop(Player.White);
            board[7, 3] = new Queen(Player.White);
            board[7, 4] = new King(Player.White);
            board[7, 5] = new Bishop(Player.White);
            board[7, 6] = new Knight(Player.White);
            board[7, 7] = new Rook(Player.White);

            /*			for (int i = 0; i < 8; i++) {
                            board[6, i] = new Pawn(Player.White);
                        }*/
        }

        public bool IsInsideBoard(Position pos) {
            if (pos.Row >= 0 && pos.Row < 8 && pos.Col >= 0 && pos.Col < 8) {
                return true;
            }

            return false;
        }

        public Board() {
            InitBoard();
        }

        public void PrintBoard() {
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    Console.Write(board[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public bool IsEmptyPosition(Position pos) {
            return this[pos] is null;
        }

        public List<Position> GetAllFilledPositions() {
            List<Position> list = new List<Position>();
            for (int row = 0; row < 8; row++) {
                for (int col = 0; col < 8; col++) {
                    Position currentPos = new Position(row, col);
                    if (!IsEmptyPosition(currentPos)) {
                        list.Add(currentPos);
                    }
                }
            }

            return list;
        }

        public List<Position> GetAllPicePositionsForPlayer(Player player) {
            List<Position> list = new List<Position>();
            foreach (Position pos in GetAllFilledPositions()) {
                if (this[pos].Color == player) {
                    list.Add(pos);
                }
            }

            return list;
        }
    }
}
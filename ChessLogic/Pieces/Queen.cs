namespace ChessLogic.Pieces {
    public class Queen : Piece {
        public override PieceType Type => PieceType.Queen;

        public override Player Color { get; }

        public Queen(Player color) {
            Color = color;
        }

        private static readonly Direction[] MoveDirections = new Direction[] {
            Direction.N, Direction.S, Direction.E, Direction.W, Direction.NE, Direction.SE, Direction.NW, Direction.SW
        };

        public override List<Position> GetAllPossibleDestinations(Position origin, Board board) {
            List<Position> result = new List<Position>();

            foreach (Direction dir in MoveDirections) {
                for (Position pos = origin + dir; board.IsInsideBoard(pos); pos += dir) {
                    if (board.IsEmptyPosition(pos)) {
                        result.Add(pos);
                    }
                    else if (board[pos].Color != this.Color) {
                        result.Add(pos);
                        continue;
                    }
                }
            }

            return result;
        }
    }
}
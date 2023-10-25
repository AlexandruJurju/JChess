namespace ChessLogic.Pieces {
    public class King : Piece {
        public override PieceType Type => PieceType.King;

        public override Player Color { get; }

        // array with all possible move directions
        private static readonly Direction[] MoveDirections = new Direction[] {
            Direction.N, Direction.S, Direction.E, Direction.W, Direction.NE, Direction.SE, Direction.NW, Direction.SW
        };

        public King(Player color) {
            Color = color;
        }

        public override List<Position> GetAllPossibleDestinations(Position origin, Board board) {
            List<Position> result = new List<Position>();

            foreach (Direction dir in MoveDirections) {
                Position newPos = origin + dir;

                if (!board.IsInsideBoard(newPos)) {
                    continue;
                }

                if (board.IsEmptyPosition(newPos)) {
                    result.Add(newPos);
                }
                else if (board[newPos].Color != this.Color) {
                    result.Add(newPos);
                    continue;
                }
            }

            return result;
        }
    }
}
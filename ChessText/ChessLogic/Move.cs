using ChessText.Board;

namespace ChessLogic
{
	public class Move
	{
		public Position Origin { get; set; }
		public Position Destination { get; set; }

		public Move(Position origin, Position destination)
		{
			Origin = origin;
			Destination = destination;
		}

		public void Execute(BoardModel board)
		{
			board[Destination] = board[Origin];
			board[Origin] = null;
		}
	}
}

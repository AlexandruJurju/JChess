using ChessText.ChessLogic;

namespace ChessText.Model
{
	public class Position
	{
		public int Row { get; set; }
		public int Col { get; set; }

		public Position(int row, int column)
		{
			Row = row;
			Col = column;
		}

		// overload + operator for direction, now when adding a position with a direction the result will be the final position
		public static Position operator +(Position a, Direction dir)
		{
			return new Position(a.Row + dir.RowDelta, a.Col + dir.ColumnDelta);
		}
	}
}

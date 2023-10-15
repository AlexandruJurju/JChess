using ChessText.ChessLogic;

namespace ChessText.Model
{
	public class Position
	{
		public int Row { get; set; }
		public int Column { get; set; }

		public Position(int row, int column)
		{
			Row = row;
			Column = column;
		}

		public static Position operator +(Position a, Direction dir)
		{
			return new Position(a.Row + dir.RowDelta, a.Column + dir.ColumnDelta);
		}
	}
}

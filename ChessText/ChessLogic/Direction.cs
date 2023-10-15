using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessText.ChessLogic
{
	public class Direction
	{

		// cardinal directions
		// matrix logic, when going up i index has to decrease, when going left j index decreses
		public readonly static Direction N = new Direction(-1, 0);
		public readonly static Direction S = new Direction(+1, 0);
		public readonly static Direction W = new Direction(0, -1);
		public readonly static Direction E = new Direction(0, +1);

		public readonly static Direction NE = Direction.N + Direction.E;
		public readonly static Direction NW = Direction.N + Direction.W;
		public readonly static Direction SE = Direction.S + Direction.E;
		public readonly static Direction SW = Direction.S + Direction.W;


		// store the changes for index i and j necessary for the move in that direction
		public int RowDelta { get; set; }
		public int ColumnDelta { get; set; }

		public Direction(int rowDelta, int columnDelta)
		{
			RowDelta = rowDelta;
			ColumnDelta = columnDelta;
		}

		public static Direction operator +(Direction a, Direction b)
		{
			return new Direction(a.RowDelta + b.RowDelta, a.ColumnDelta + b.ColumnDelta);
		}

		public static Direction operator -(Direction a, Direction b)
		{
			return new Direction(a.RowDelta - b.RowDelta, a.ColumnDelta - b.ColumnDelta);
		}

		public static Direction operator *(Direction direction, int scalar)
		{
			return new Direction(direction.RowDelta * scalar, direction.ColumnDelta * scalar);
		}

	}
}

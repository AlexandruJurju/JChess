using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessText.ChessLogic
{
	public class Direction
	{
		public int RowDelta { get; set; }
		public int ColumnDelta { get; set; }

		public Direction(int rowDelta, int columnDelta)
		{
			RowDelta = rowDelta;
			ColumnDelta = columnDelta;
		}
	}
}

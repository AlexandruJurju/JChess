using ChessText.Model.PieceLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessText.Board
{

	public class BoardModel
	{
		private Piece[,] board = new Piece[8, 8];

		// indexer, acess elements as if it was an array
		// takes ints row and col as parameters for indexing the board array
		public Piece this[int row, int col]
		{
			get { return board[row, col]; }
			set { board[row, col] = value; }
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessText.Board
{

	public class BoardModel
	{
		private char[,] board = new char[8, 8];
		int size = 8;

		public BoardModel()
		{
			for (int row = 2; row <= 5; row++)
			{
				for (int col = 0; col < size; col++)
				{
					board[row, col] = 'X';
				}
			}

			// Initialize the board with pieces
			board[0, 0] = 'r'; board[0, 1] = 'n'; board[0, 2] = 'b'; board[0, 3] = 'q';
			board[0, 4] = 'k'; board[0, 5] = 'b'; board[0, 6] = 'n'; board[0, 7] = 'r';

			board[1, 0] = 'p'; board[1, 1] = 'p'; board[1, 2] = 'p'; board[1, 3] = 'p';
			board[1, 4] = 'p'; board[1, 5] = 'p'; board[1, 6] = 'p'; board[1, 7] = 'p';

			board[6, 0] = 'P'; board[6, 1] = 'P'; board[6, 2] = 'P'; board[6, 3] = 'P';
			board[6, 4] = 'P'; board[6, 5] = 'P'; board[6, 6] = 'P'; board[6, 7] = 'P';

			board[7, 0] = 'R'; board[7, 1] = 'N'; board[7, 2] = 'B'; board[7, 3] = 'Q';
			board[7, 4] = 'K'; board[7, 5] = 'B'; board[7, 6] = 'N'; board[7, 7] = 'R';

		}

		public void printModel()
		{
			for (int row = 0; row < size; row++)
			{
				for (int col = 0; col < size; col++)
				{
					System.Diagnostics.Debug.Write(board[row, col] + " ");
				}
				System.Diagnostics.Debug.Write("\n");
			}
			System.Diagnostics.Debug.Write("\n");
		}
	}
}

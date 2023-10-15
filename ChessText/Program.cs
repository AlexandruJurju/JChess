using ChessLogic;
using System;
using System.Collections.Generic;

namespace ChessText {
	internal class Program {
		static void Main(string[] args) {
			BoardModel boardModel = new BoardModel();
			boardModel.PrintBoard();

			List<Move> moves = boardModel[0, 4].GenerateMoves(new Position(0, 4), boardModel);
			Console.WriteLine(moves.Count);
		}
	}
}

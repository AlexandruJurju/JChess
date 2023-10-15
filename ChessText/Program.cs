using ChessLogic;
using System;
using System.Collections.Generic;

namespace ChessText {
	internal class Program {
		static void Main(string[] args) {
			BoardModel boardModel = new BoardModel();

			List<Move> moves = boardModel[0, 2].GenerateMoves(new Position(0, 2), boardModel);
			Console.WriteLine(moves.Count);
		}
	}
}

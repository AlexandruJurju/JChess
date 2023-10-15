﻿using System.Collections.Generic;

namespace ChessLogic
{
	public class Knight : Piece
	{
		public override PieceType Type => PieceType.Pawn;

		public override Player Color { get; }

		public Knight(Player color)
		{
			Color = color;
		}

		public override List<Move> GenerateMoves(Position origin, BoardModel board)
		{
			throw new System.NotImplementedException();
		}

		public override List<Position> GetAllPossibleDestinations(Position origin, BoardModel board) {
			throw new System.NotImplementedException();
		}
	}
}

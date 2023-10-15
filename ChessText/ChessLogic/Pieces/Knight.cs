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

		public override IEnumerable<Move> GenerateMoves(Position origin, Position destination)
		{
			throw new System.NotImplementedException();
		}
	}
}

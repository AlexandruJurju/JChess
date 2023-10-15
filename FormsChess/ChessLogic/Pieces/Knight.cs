using System.Collections.Generic;

namespace ChessLogic {
	public class Knight : Piece {
		public override PieceType Type => PieceType.Knight;

		public override Player Color { get; }

		public Knight(Player color) {
			Color = color;
		}

		public override List<Position> GetAllPossibleDestinations(Position origin, Board board) {
			List<Position> positions = new List<Position>();

			Position NEEdge = origin + Direction.NE * 2;
			positions.Add(NEEdge + Direction.S);
			positions.Add(NEEdge + Direction.W);

			Position NWEdge = origin + Direction.NW * 2;
			positions.Add(NEEdge + Direction.E);
			positions.Add(NEEdge + Direction.S);

			Position SWEdge = origin + Direction.SW * 2;
			positions.Add(NEEdge + Direction.N);
			positions.Add(NEEdge + Direction.E);

			Position SEEdge = origin + Direction.SE * 2;
			positions.Add(NEEdge + Direction.E);
			positions.Add(NEEdge + Direction.N);

			return positions;
		}
	}
}

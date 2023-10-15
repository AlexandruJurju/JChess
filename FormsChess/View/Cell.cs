using ChessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View {
	public class Cell : PictureBox {
		public Piece Piece { get; set; }
		public Color Color { get; set; }
		public int XCoord { get; set; }
		public int YCoord { get; set; }

		public Cell(int xCoord, int yCoord) {
			XCoord = xCoord;
			YCoord = yCoord;
			this.Paint += new PaintEventHandler(paintCellByColor);
		}

		public void removePiece() {
			this.Piece = null;
		}

		public Tuple<int, int> getCoord() {
			return new Tuple<int, int>(XCoord, YCoord);
		}

		public void setPiece(Piece piece) {
			this.Piece = piece;
			//this.Image = piece.Image;
			this.SizeMode = PictureBoxSizeMode.CenterImage;
		}

		public void paintCellByColor(object sender, PaintEventArgs e) {
			Graphics g = e.Graphics;

			if (Piece != null) {
				if (Piece.Color == Player.White) {
					g.FillEllipse(Brushes.White, 7, 7, 10, 10);
				} else {
					g.FillEllipse(Brushes.Black, 45, 45, 10, 10);
				}
			}
		}
	}
}

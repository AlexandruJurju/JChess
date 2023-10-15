using ChessLogic;
using View;

namespace FormsChess {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();

			this.Size = new Size(1250, 750);
			this.Location = new Point(0, 0);
			this.CenterToScreen();

			Display display = new Display(this);


			for (int i = 0; i < 8; i++) {
				for (int j = 0; j < 8; j++) {
					PictureBox pictureBox = new PictureBox();
					pictureBox.Size = new Size(60, 60);
					pictureBox.Location = new Point(i * 60 + 75, j * 60 + 75);
					if (i % 2 == j % 2) {
						pictureBox.BackColor = Color.FromArgb(255, 102, 68, 58);
					} else {
						pictureBox.BackColor = Color.FromArgb(255, 245, 230, 191);
					}

					this.Controls.Add(pictureBox);
				}
			}


		}
	}
}
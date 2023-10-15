using ChessLogic;
using View;

namespace FormsChess {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();

			this.Size = new Size(1250, 750);
			this.Location = new Point(0, 0);
			this.CenterToScreen();

			Display display = new Display();
			this.Controls.Add(display.PlayerIndicator);
			this.Controls.Add(display.DepthComboBox);
			this.Controls.Add(display.DepthLabel);


		}
	}
}
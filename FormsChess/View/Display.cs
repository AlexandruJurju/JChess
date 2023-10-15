using ChessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View {
	public class Display {
		public ComboBox DepthComboBox { get; set; }
		public Label DepthLabel { get; set; }
		public Label PlayerIndicator { get; set; }

		public Display() {
			DepthComboBox = new ComboBox();
			DepthComboBox.Location = new Point(950, 300);
			DepthComboBox.Size = new Size(100, 100);
			DepthComboBox.Items.Add("Random");
			DepthComboBox.Items.Add("1");
			DepthComboBox.Items.Add("2");
			DepthComboBox.Items.Add("3");
			DepthComboBox.Items.Add("4");
			DepthComboBox.SelectedItem = "Random";
			DepthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			DepthLabel = new Label();
			DepthLabel.Text = "Max depth";
			DepthLabel.Size = new Size(150, 150);
			DepthLabel.Location = new Point(950, 260);
			DepthLabel.Font = new Font("Roboto", 12, FontStyle.Regular);

			PlayerIndicator = new Label();
			PlayerIndicator.Visible = true;
			PlayerIndicator.Location = new Point(850, 300);
			PlayerIndicator.ForeColor = Color.Black;
			PlayerIndicator.Text = "P1";
			PlayerIndicator.Size = new Size(50, 50);
			PlayerIndicator.BackColor = Color.White;
			PlayerIndicator.Font = new Font("Times New Roman", 20);
			PlayerIndicator.TextAlign = ContentAlignment.MiddleCenter;
		}

		public void UpdateIndicatorColor(Player player) {
			if (player == Player.White) {
				PlayerIndicator.ForeColor = Color.White;
				PlayerIndicator.Text = "P1";
			} else {
				PlayerIndicator.ForeColor = Color.Black;
				PlayerIndicator.Text = "P2";
			}
		}

	}
}

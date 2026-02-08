using System.Windows.Forms;

namespace Tic_Tac_Game_team1.Models
{
	public class HumanPlayer : Player
	{
		public HumanPlayer(string symbol) : base(symbol) { }

		public override void MakeMove(Button[,] gridButtons)
			   private void Button_Click(object sender, EventArgs e)
				{
					Button btn = sender as Button;
					if (!string.IsNullOrEmpty(btn.Text)) return;

					btn.Text = "X";
					btn.BackColor = Color.LightBlue;

					game.SwitchTurn();
					lblStatus.Text = "Turn: " + (game.IsXTurn ? "X" : "O");

					CheckWinner();

					if (comboBoxOptions.SelectedIndex == 0 && !game.IsXTurn)
						timerPlay.Start();
				}
	}
	}
}

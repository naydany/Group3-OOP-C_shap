using System.Windows.Forms;

namespace Tic_Tac_Game_team1.Models
{
    public class Game
    {
        public Player PlayerX { get; private set; }
        public Player PlayerO { get; private set; }
        public bool IsXTurn { get; private set; }

        public Game(Player x, Player o)
        {
            PlayerX = x;
            PlayerO = o;
            IsXTurn = true;
        }

        public Player CurrentPlayer => IsXTurn ? PlayerX : PlayerO;

        public void SwitchTurn() => IsXTurn = !IsXTurn;

        public void MakeMove(Button[,] gridButtons)
        {
            CurrentPlayer.MakeMove(gridButtons);
            SwitchTurn();
        }
    }
}

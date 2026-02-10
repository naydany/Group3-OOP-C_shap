using System.Windows.Forms;

namespace Tic_Tac_Game_team1.Models
{
    public class Game
    {
        private Player playerX;
        private Player playerO;
        private bool isXTurn;

        public Game(Player x, Player o)
        {
            playerX = x;
            playerO = o;
            isXTurn = true;
        }

        public Player CurrentPlayer => isXTurn ? playerX : playerO;

        public void SwitchTurn() => isXTurn = !isXTurn;

        public void MakeMove(Button[,] gridButtons)
        {
            CurrentPlayer.MakeMove(gridButtons);
            SwitchTurn();
        }
    }
}

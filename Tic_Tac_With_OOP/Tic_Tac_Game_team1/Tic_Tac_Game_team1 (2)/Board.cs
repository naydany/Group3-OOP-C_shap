using System.Windows.Forms;

namespace Tic_Tac_Game_team1.Models
{
    public class Board
    {
        public Button[,] GridButtons { get; private set; }
        public int Size { get; private set; }

        public Board(int size, Button[,] buttons)
        {
            Size = size;
            GridButtons = buttons;
        }

        public bool IsCellEmpty(int row, int col) => string.IsNullOrEmpty(GridButtons[row, col].Text);
    }
}

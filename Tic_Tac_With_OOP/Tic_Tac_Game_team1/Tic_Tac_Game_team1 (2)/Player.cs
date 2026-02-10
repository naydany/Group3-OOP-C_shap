namespace Tic_Tac_Game_team1.Models
{
    public abstract class Player
    {
        public string Symbol { get; private set; }

        protected Player(string symbol)
        {
            Symbol = symbol;
        }

        public abstract void MakeMove(Button[,] gridButtons);
    }
}

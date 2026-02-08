namespace Tic_Tac_Game.Services
{
    public static class WinnerChecker
    {
        public static string Check(string[,] board, int size)
        {
            // rows
            for (int r = 0; r < size; r++)
            {
                string first = board[r, 0];
                if (string.IsNullOrEmpty(first)) continue;

                bool win = true;
                for (int c = 1; c < size; c++)
                    if (board[r, c] != first) win = false;

                if (win) return first;
            }

            // columns
            for (int c = 0; c < size; c++)
            {
                string first = board[0, c];
                if (string.IsNullOrEmpty(first)) continue;

                bool win = true;
                for (int r = 1; r < size; r++)
                    if (board[r, c] != first) win = false;

                if (win) return first;
            }

            // diagonals
            string d1 = board[0, 0];
            if (!string.IsNullOrEmpty(d1))
            {
                bool win = true;
                for (int i = 1; i < size; i++)
                    if (board[i, i] != d1) win = false;
                if (win) return d1;
            }

            string d2 = board[0, size - 1];
            if (!string.IsNullOrEmpty(d2))
            {
                bool win = true;
                for (int i = 1; i < size; i++)
                    if (board[i, size - 1 - i] != d2) win = false;
                if (win) return d2;
            }

            return null;
        }
    }
}

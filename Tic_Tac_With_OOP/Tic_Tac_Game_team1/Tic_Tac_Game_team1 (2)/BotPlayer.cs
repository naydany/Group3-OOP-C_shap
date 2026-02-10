using System;
using System.Collections.Generic;
using System.Drawing;
using Tic_Tac_Game_team1.Models;

public class BotPlayer : Player
{
    private Random random = new Random();

    public BotPlayer(string symbol) : base(symbol) { }

    public override void MakeMove(Button[,] gridButtons)
    {
        List<Button> emptyButtons = new List<Button>();
        int gridSize = gridButtons.GetLength(0);

        for (int row = 0; row < gridSize; row++)
            for (int col = 0; col < gridSize; col++)
                if (string.IsNullOrEmpty(gridButtons[row, col].Text))
                    emptyButtons.Add(gridButtons[row, col]);

        if (emptyButtons.Count == 0) return;

        Button btn = emptyButtons[random.Next(emptyButtons.Count)];
        btn.Text = Symbol;
        btn.BackColor = Color.Red;
    }
}

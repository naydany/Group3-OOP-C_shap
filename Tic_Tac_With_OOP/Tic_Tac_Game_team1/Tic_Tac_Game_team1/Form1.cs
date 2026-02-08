using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Game_team1.Models;
namespace Tic_Tac_Game_team1
{
    public partial class Form1 : Form
    {
        private Button[,] gridButtons;
        private int gridSize;
        private Game game;
        private BotPlayer bot;
        private Timer timerPlay;
        public Form1()
        {
            InitializeComponent();
            setValueToComboBox();
        }
        private void setValueToComboBox()
        {
            comboBoxOptions.Items.Clear();
            comboBoxOptions.Items.Add("Play with bot");
            comboBoxOptions.Items.Add("Play with Friend");
            comboBoxOptions.SelectedIndex = 0;
        }
        private void GenerateGrid(int size)
        {
            panelGrid.Controls.Clear();
            gridSize = size;
            gridButtons = new Button[gridSize, gridSize];
            int spacing = 5;
            int buttonWidth = (panelGrid.Width - (gridSize + 1) * spacing) / gridSize;
            int buttonHeight = (panelGrid.Height - (gridSize + 1) * spacing) / gridSize;

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(buttonWidth, buttonHeight);
                    btn.Location = new Point(spacing + col * (buttonWidth + spacing),
                                             spacing + row * (buttonHeight + spacing));
                    btn.Font = new Font("Arial", buttonHeight / 2, FontStyle.Bold);
                    btn.Click += Button_Click;
                    panelGrid.Controls.Add(btn);
                    gridButtons[row, col] = btn;
                }
            }
        }
        private void startGame_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxGrids.Text, out int size) || size < 3)
            {
                MessageBox.Show("Enter a valid grid size >= 3");
                return;
            }
            GenerateGrid(size);
            HumanPlayer human = new HumanPlayer("X");
            bot = new BotPlayer("O");
            game = new Game(human, bot);
            timerPlay = new Timer();
            timerPlay.Interval = 500;
            timerPlay.Tick += TimerPlay_Tick;
            lblStatus.Text = "Turn: X";
        }

        private void TimerPlay_Tick(object sender, EventArgs e)
        {
            timerPlay.Stop();
            game.MakeMove(gridButtons);
            lblStatus.Text = "Turn: X";
            CheckWinner();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (gridButtons == null) return;
            foreach (var btn in gridButtons)
            {
                btn.Text = "";
                btn.BackColor = SystemColors.Control;
            }

            game = new Game(new HumanPlayer("X"), bot);
            lblStatus.Text = "Turn: X";
        }
    
    }
}

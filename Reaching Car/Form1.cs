using System.Drawing.Drawing2D;

namespace Reaching_Car
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            panelOver.Visible = false;
            RoundPanel(panelOver, 10);

            try
            {
                GameManager.Initialize(enamy1, enamy2, enamy3, coin1, coin2, coin3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Initialization error: " + ex.Message, "Init Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            try
            {
                roadMove(5);

                // Update all game objects (enemies & coins)
                GameManager.UpdateAll();

                UpdateScore();       // check and collect coins
                CheckGameOver();     // check collisions with enemies
            }
            catch (Exception ex)
            {
                MessageBox.Show("Game loop error: " + ex.Message, "Game Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateScore()
        {
            try
            {
                int score = GameManager.TotalCoinsCollected;

                foreach (var coin in GameManager.Coins)
                {
                    if (mainCar.Bounds.IntersectsWith(coin.Picture.Bounds))
                    {
                        score++;
                        coin.Picture.Top = -100;
                        coin.Picture.Left = GameManager.GetSafeCoinX(coin.Picture);
                    }
                }

                GameManager.TotalCoinsCollected = score;
                totalCoin.Text = "Total Coin: " + score.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("totalPoint error: " + ex.Message);
            }
        }

        private void CheckGameOver()
        {
            try
            {
                foreach (var enemy in GameManager.Enemies)
                {
                    if (mainCar.Bounds.IntersectsWith(enemy.Picture.Bounds))
                    {
                        timerGame.Enabled = false;
                        panelOver.Visible = true;
                        break;
                    }
                }

                totalScore.Text = "Your Coin is: " + GameManager.TotalCoinsCollected;
            }
            catch (Exception ex)
            {
                Console.WriteLine("gameOver check error: " + ex.Message);
            }
        }

        // ===== ADD BACK THE MISSING METHODS =====

        private void roadMove(int speed)
        {
            if (lineOne.Top >= 700) lineOne.Top = -20;
            else lineOne.Top += speed;

            if (lineTwo.Top >= 700) lineTwo.Top = -20;
            else lineTwo.Top += speed;

            if (lineThree.Top >= 700) lineThree.Top = -20;
            else lineThree.Top += speed;

            if (lineFour.Top >= 700) lineFour.Top = -20;
            else lineFour.Top += speed;

            if (lineFive.Top >= 700) lineFive.Top = -20;
            else lineFive.Top += speed;
        }

        private void moveObject(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && mainCar.Left > 0)
                mainCar.Left -= 10;

            if (e.KeyCode == Keys.Right && mainCar.Right < this.ClientSize.Width)
                mainCar.Left += 10;

            if (e.KeyCode == Keys.Up && mainCar.Top > 0)
                mainCar.Top -= 10;

            if (e.KeyCode == Keys.Down && mainCar.Bottom < this.ClientSize.Height)
                mainCar.Top += 7;
        }

        public void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void resetGame_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            this.Hide();
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

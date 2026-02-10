using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Reaching_Car
{
    public partial class FormDashboard : Form
    {
        private int baseSpeed = 5;
        private int currentSpeed = 7;
        private const int maxSpeed = 15;

        private int totalValue = 0;

        // OOP objects
        private Enemy enemy1Obj;
        private Enemy enemy2Obj;
        private Enemy enemy3Obj;

        private Coin coin1Obj;
        private Coin coin2Obj;
        private Coin coin3Obj;

        // Key states for smooth movement
        private bool leftPressed = false;
        private bool rightPressed = false;
        private bool upPressed = false;
        private bool downPressed = false;

        public FormDashboard()
        {
            InitializeComponent();

            // Enable smooth drawing
            this.DoubleBuffered = true;
            this.KeyPreview = true; // capture key events at the form level

            panelOver.Visible = false;
            RoundPanel(panelOver, 10);

            // Initialize objects
            enemy1Obj = new Enemy(enamy1);
            enemy2Obj = new Enemy(enamy2);
            enemy3Obj = new Enemy(enamy3);

            coin1Obj = new Coin(coin1);
            coin2Obj = new Coin(coin2);
            coin3Obj = new Coin(coin3);

            // Subscribe to key events
            this.KeyDown += FormDashboard_KeyDown;
            this.KeyUp += FormDashboard_KeyUp;
        }

        // ================= SPEED =================
        private void UpdateSpeed()
        {
            currentSpeed = baseSpeed + (totalValue / 5);
            if (currentSpeed > maxSpeed)
                currentSpeed = maxSpeed;
        }

        // ================= GAME LOOP =================
        private void timerGame_Tick(object? sender, EventArgs e)
        {
            try
            {
                UpdateSpeed();

                MoveCar();      // Smooth car movement
                roadMove(currentSpeed);

                enemy1Obj.Move(currentSpeed);
                enemy2Obj.Move(currentSpeed);
                enemy3Obj.Move(currentSpeed);

                coin1Obj.Move(currentSpeed);
                coin2Obj.Move(currentSpeed);
                coin3Obj.Move(currentSpeed);

                gameOver();
                totalPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Game error: " + ex.Message);
            }
        }

        // ================= SMOOTH CAR MOVEMENT =================
        private void MoveCar()
        {
            int step = 8;

            if (leftPressed && mainCar.Left > 0)
                mainCar.Left -= step;

            if (rightPressed && mainCar.Right < ClientSize.Width)
                mainCar.Left += step;

            if (upPressed && mainCar.Top > 0)
                mainCar.Top -= step;

            if (downPressed && mainCar.Bottom < ClientSize.Height)
                mainCar.Top += step;
        }

        private void FormDashboard_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) leftPressed = true;
            if (e.KeyCode == Keys.Right) rightPressed = true;
            if (e.KeyCode == Keys.Up) upPressed = true;
            if (e.KeyCode == Keys.Down) downPressed = true;
        }

        private void FormDashboard_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) leftPressed = false;
            if (e.KeyCode == Keys.Right) rightPressed = false;
            if (e.KeyCode == Keys.Up) upPressed = false;
            if (e.KeyCode == Keys.Down) downPressed = false;
        }

        // ================= ROAD MOVE =================
        private void roadMove(int speed)
        {
            MoveLine(lineOne, speed);
            MoveLine(lineTwo, speed);
            MoveLine(lineThree, speed);
            MoveLine(lineFour, speed);
            MoveLine(lineFive, speed);
        }

        private void MoveLine(PictureBox line, int speed)
        {
            if (line.Top >= 700)
                line.Top = -20;
            else
                line.Top += speed;
        }

        // ================= GAME OVER =================
        private void gameOver()
        {
            if (enemy1Obj.IsColliding(mainCar) ||
                enemy2Obj.IsColliding(mainCar) ||
                enemy3Obj.IsColliding(mainCar))
            {
                timerGame.Enabled = false;
                panelOver.Visible = true;
                totalScore.Text = "Your Coin is: " + totalValue;
            }
        }

        // ================= SCORE =================
        private void totalPoint()
        {
            if (coin1Obj.Collect(mainCar)) totalValue++;
            if (coin2Obj.Collect(mainCar)) totalValue++;
            if (coin3Obj.Collect(mainCar)) totalValue++;

            totalCoin.Text = "Total Coin: " + totalValue;
        }

        // ================= UI HELPERS =================
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

        // ================= RESET =================
        private void resetGame_Click(object? sender, EventArgs e)
        {
            Hide();
            new FormDashboard().Show();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enamy2_Click(object sender, EventArgs e)
        {

        }
    }
}

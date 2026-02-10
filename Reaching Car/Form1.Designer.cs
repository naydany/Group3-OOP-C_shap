using System.CodeDom;

namespace Reaching_Car
{
    partial class FormDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            lineOne = new PictureBox();
            lineTwo = new PictureBox();
            lineThree = new PictureBox();
            lineFour = new PictureBox();
            lineFive = new PictureBox();
            timerGame = new System.Windows.Forms.Timer(components);
            lineRoad2 = new PictureBox();
            mainCar = new PictureBox();
            lineRoad1 = new PictureBox();
            enamy1 = new PictureBox();
            enamy2 = new PictureBox();
            enamy3 = new PictureBox();
            coin1 = new PictureBox();
            coin2 = new PictureBox();
            coin3 = new PictureBox();
            panelOver = new Panel();
            totalScore = new Label();
            label1 = new Label();
            button1 = new Button();
            resetGame = new Button();
            totalCoin = new Label();
            ((System.ComponentModel.ISupportInitialize)lineOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineFour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineFive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineRoad2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineRoad1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enamy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enamy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enamy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            panelOver.SuspendLayout();
            SuspendLayout();
            // 
            // lineOne
            // 
            lineOne.BackColor = SystemColors.ButtonHighlight;
            lineOne.Location = new Point(225, -50);
            lineOne.Name = "lineOne";
            lineOne.Size = new Size(13, 141);
            lineOne.TabIndex = 0;
            lineOne.TabStop = false;
            // 
            // lineTwo
            // 
            lineTwo.BackColor = SystemColors.ButtonHighlight;
            lineTwo.Location = new Point(225, 118);
            lineTwo.Name = "lineTwo";
            lineTwo.Size = new Size(13, 141);
            lineTwo.TabIndex = 1;
            lineTwo.TabStop = false;
            // 
            // lineThree
            // 
            lineThree.BackColor = SystemColors.ButtonHighlight;
            lineThree.Location = new Point(225, 289);
            lineThree.Name = "lineThree";
            lineThree.Size = new Size(13, 141);
            lineThree.TabIndex = 2;
            lineThree.TabStop = false;
            // 
            // lineFour
            // 
            lineFour.BackColor = SystemColors.ButtonHighlight;
            lineFour.Location = new Point(225, 461);
            lineFour.Name = "lineFour";
            lineFour.Size = new Size(13, 141);
            lineFour.TabIndex = 3;
            lineFour.TabStop = false;
            // 
            // lineFive
            // 
            lineFive.BackColor = SystemColors.ButtonHighlight;
            lineFive.Location = new Point(225, 631);
            lineFive.Name = "lineFive";
            lineFive.Size = new Size(13, 141);
            lineFive.TabIndex = 4;
            lineFive.TabStop = false;
            // 
            // timerGame
            // 
            timerGame.Enabled = true;
            timerGame.Interval = 10;
            timerGame.Tick += timerGame_Tick;
            // 
            // lineRoad2
            // 
            lineRoad2.BackColor = SystemColors.ButtonHighlight;
            lineRoad2.Location = new Point(471, -8);
            lineRoad2.Name = "lineRoad2";
            lineRoad2.Size = new Size(13, 685);
            lineRoad2.TabIndex = 6;
            lineRoad2.TabStop = false;
            // 
            // mainCar
            // 
            mainCar.BackColor = Color.Transparent;
            mainCar.BackgroundImageLayout = ImageLayout.None;
            mainCar.Image = (Image)resources.GetObject("mainCar.Image");
            mainCar.Location = new Point(207, 475);
            mainCar.Name = "mainCar";
            mainCar.Size = new Size(54, 92);
            mainCar.SizeMode = PictureBoxSizeMode.Zoom;
            mainCar.TabIndex = 7;
            mainCar.TabStop = false;
            // 
            // lineRoad1
            // 
            lineRoad1.BackColor = SystemColors.ButtonHighlight;
            lineRoad1.Location = new Point(0, -18);
            lineRoad1.Name = "lineRoad1";
            lineRoad1.Size = new Size(13, 685);
            lineRoad1.TabIndex = 5;
            lineRoad1.TabStop = false;
            // 
            // enamy1
            // 
            enamy1.BackColor = Color.Transparent;
            enamy1.BackgroundImageLayout = ImageLayout.None;
            enamy1.Image = (Image)resources.GetObject("enamy1.Image");
            enamy1.Location = new Point(36, 475);
            enamy1.Name = "enamy1";
            enamy1.Size = new Size(54, 92);
            enamy1.SizeMode = PictureBoxSizeMode.Zoom;
            enamy1.TabIndex = 8;
            enamy1.TabStop = false;
            // 
            // enamy2
            // 
            enamy2.BackColor = Color.Transparent;
            enamy2.BackgroundImageLayout = ImageLayout.None;
            enamy2.Image = (Image)resources.GetObject("enamy2.Image");
            enamy2.Location = new Point(172, 23);
            enamy2.Name = "enamy2";
            enamy2.Size = new Size(54, 89);
            enamy2.SizeMode = PictureBoxSizeMode.Zoom;
            enamy2.TabIndex = 9;
            enamy2.TabStop = false;
            enamy2.Click += enamy2_Click;
            // 
            // enamy3
            // 
            enamy3.BackColor = Color.Transparent;
            enamy3.BackgroundImageLayout = ImageLayout.None;
            enamy3.Image = (Image)resources.GetObject("enamy3.Image");
            enamy3.Location = new Point(397, 234);
            enamy3.Name = "enamy3";
            enamy3.Size = new Size(54, 87);
            enamy3.SizeMode = PictureBoxSizeMode.Zoom;
            enamy3.TabIndex = 10;
            enamy3.TabStop = false;
            // 
            // coin1
            // 
            coin1.BackColor = Color.Transparent;
            coin1.BackgroundImageLayout = ImageLayout.None;
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(36, 271);
            coin1.Name = "coin1";
            coin1.Size = new Size(44, 42);
            coin1.SizeMode = PictureBoxSizeMode.Zoom;
            coin1.TabIndex = 13;
            coin1.TabStop = false;
            // 
            // coin2
            // 
            coin2.BackColor = Color.Transparent;
            coin2.BackgroundImageLayout = ImageLayout.None;
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(385, 136);
            coin2.Name = "coin2";
            coin2.Size = new Size(45, 46);
            coin2.SizeMode = PictureBoxSizeMode.Zoom;
            coin2.TabIndex = 14;
            coin2.TabStop = false;
            // 
            // coin3
            // 
            coin3.BackColor = Color.Transparent;
            coin3.BackgroundImageLayout = ImageLayout.None;
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(207, 329);
            coin3.Name = "coin3";
            coin3.Size = new Size(45, 47);
            coin3.SizeMode = PictureBoxSizeMode.Zoom;
            coin3.TabIndex = 15;
            coin3.TabStop = false;
            // 
            // panelOver
            // 
            panelOver.BackColor = SystemColors.ButtonHighlight;
            panelOver.Controls.Add(totalScore);
            panelOver.Controls.Add(label1);
            panelOver.Controls.Add(button1);
            panelOver.Controls.Add(resetGame);
            panelOver.Location = new Point(73, 174);
            panelOver.Name = "panelOver";
            panelOver.Size = new Size(318, 281);
            panelOver.TabIndex = 16;
            // 
            // totalScore
            // 
            totalScore.AutoSize = true;
            totalScore.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalScore.Location = new Point(83, 117);
            totalScore.Name = "totalScore";
            totalScore.Size = new Size(157, 30);
            totalScore.TabIndex = 3;
            totalScore.Text = "Your score is : 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LimeGreen;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(278, 65);
            label1.TabIndex = 2;
            label1.Text = "Game Over";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(171, 188);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 1;
            button1.Text = "Exit Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // resetGame
            // 
            resetGame.BackColor = Color.DeepSkyBlue;
            resetGame.ForeColor = SystemColors.ButtonHighlight;
            resetGame.Location = new Point(56, 188);
            resetGame.Name = "resetGame";
            resetGame.Size = new Size(94, 42);
            resetGame.TabIndex = 0;
            resetGame.Text = "Reset Game";
            resetGame.UseVisualStyleBackColor = false;
            resetGame.Click += resetGame_Click;
            // 
            // totalCoin
            // 
            totalCoin.AutoSize = true;
            totalCoin.BackColor = Color.Chocolate;
            totalCoin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalCoin.ForeColor = SystemColors.ButtonHighlight;
            totalCoin.Location = new Point(13, 1);
            totalCoin.Name = "totalCoin";
            totalCoin.Size = new Size(153, 32);
            totalCoin.TabIndex = 17;
            totalCoin.Text = "Total Coin : 0";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(484, 661);
            Controls.Add(totalCoin);
            Controls.Add(panelOver);
            Controls.Add(coin3);
            Controls.Add(coin2);
            Controls.Add(coin1);
            Controls.Add(enamy3);
            Controls.Add(enamy2);
            Controls.Add(enamy1);
            Controls.Add(mainCar);
            Controls.Add(lineRoad2);
            Controls.Add(lineRoad1);
            Controls.Add(lineFive);
            Controls.Add(lineFour);
            Controls.Add(lineThree);
            Controls.Add(lineTwo);
            Controls.Add(lineOne);
            Name = "FormDashboard";
            Text = "Game Reaching Car";
            KeyDown += FormDashboard_KeyDown;
            KeyUp += FormDashboard_KeyUp;
            ((System.ComponentModel.ISupportInitialize)lineOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineThree).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineFour).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineFive).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineRoad2).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineRoad1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enamy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enamy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enamy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            panelOver.ResumeLayout(false);
            panelOver.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox lineOne;
        private PictureBox lineTwo;
        private PictureBox lineThree;
        private PictureBox lineFour;
        private PictureBox lineFive;
        private System.Windows.Forms.Timer timerGame;
        private PictureBox lineRoad2;
        private PictureBox mainCar;
        private PictureBox lineRoad1;
        private PictureBox enamy1;
        private PictureBox enamy2;
        private PictureBox enamy3;
        private Label labelOver;
        private PictureBox coin1;
        private PictureBox coin2;
        private PictureBox coin3;
        private Panel panelOver;
        private Button resetGame;
        private Label label1;
        private Button button1;
        private Label totalCoin;
        private Label totalScore;
    }
}

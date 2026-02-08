namespace Tic_Tac_Game_team1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBoxOptions = new System.Windows.Forms.ComboBox();
            this.labelOption = new System.Windows.Forms.Label();
            this.labelGrid = new System.Windows.Forms.Label();
            this.textBoxGrids = new System.Windows.Forms.TextBox();
            this.startGame = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.Location = new System.Drawing.Point(38, 102);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 17);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Player time";
            // 
            // comboBoxOptions
            // 
            this.comboBoxOptions.FormattingEnabled = true;
            this.comboBoxOptions.Location = new System.Drawing.Point(134, 43);
            this.comboBoxOptions.Name = "comboBoxOptions";
            this.comboBoxOptions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOptions.TabIndex = 10;
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOption.Location = new System.Drawing.Point(36, 43);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(80, 17);
            this.labelOption.TabIndex = 11;
            this.labelOption.Text = "Option play";
            // 
            // labelGrid
            // 
            this.labelGrid.AutoSize = true;
            this.labelGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelGrid.Location = new System.Drawing.Point(301, 47);
            this.labelGrid.Name = "labelGrid";
            this.labelGrid.Size = new System.Drawing.Size(42, 17);
            this.labelGrid.TabIndex = 12;
            this.labelGrid.Text = "Grids";
            // 
            // textBoxGrids
            // 
            this.textBoxGrids.Location = new System.Drawing.Point(362, 44);
            this.textBoxGrids.Name = "textBoxGrids";
            this.textBoxGrids.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrids.TabIndex = 13;
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(510, 44);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(82, 24);
            this.startGame.TabIndex = 14;
            this.startGame.Text = "Start";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Location = new System.Drawing.Point(39, 139);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(553, 471);
            this.panelGrid.TabIndex = 15;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(510, 84);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 24);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 648);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.textBoxGrids);
            this.Controls.Add(this.labelGrid);
            this.Controls.Add(this.labelOption);
            this.Controls.Add(this.comboBoxOptions);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label labelOption;
        private System.Windows.Forms.Label labelGrid;
        private System.Windows.Forms.TextBox textBoxGrids;
        private System.Windows.Forms.Button startGame;
        internal System.Windows.Forms.ComboBox comboBoxOptions;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.Button btnReset;
    }
}


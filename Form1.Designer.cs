namespace Tic_Tac_Toe_Game
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
            this.pctIcon = new System.Windows.Forms.PictureBox();
            this.LblPlayer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LplWinner = new System.Windows.Forms.Label();
            this.BtnRestartGame = new System.Windows.Forms.Button();
            this.picXO1 = new System.Windows.Forms.Button();
            this.picXO4 = new System.Windows.Forms.Button();
            this.picXO5 = new System.Windows.Forms.Button();
            this.picXO6 = new System.Windows.Forms.Button();
            this.picXO3 = new System.Windows.Forms.Button();
            this.picXO2 = new System.Windows.Forms.Button();
            this.picXO7 = new System.Windows.Forms.Button();
            this.picXO8 = new System.Windows.Forms.Button();
            this.picXO9 = new System.Windows.Forms.Button();
            this.BtnResetScores = new System.Windows.Forms.Button();
            this.lblScorePlayer2 = new System.Windows.Forms.Label();
            this.lblScorePlayer1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pctIcon
            // 
            this.pctIcon.BackColor = System.Drawing.Color.Black;
            this.pctIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctIcon.Image = global::Tic_Tac_Toe_Game.Properties.Resources.icon;
            this.pctIcon.Location = new System.Drawing.Point(79, 45);
            this.pctIcon.Name = "pctIcon";
            this.pctIcon.Size = new System.Drawing.Size(129, 122);
            this.pctIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctIcon.TabIndex = 1;
            this.pctIcon.TabStop = false;
            // 
            // LblPlayer
            // 
            this.LblPlayer.AutoSize = true;
            this.LblPlayer.BackColor = System.Drawing.Color.Blue;
            this.LblPlayer.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.LblPlayer.Location = new System.Drawing.Point(441, 21);
            this.LblPlayer.Name = "LblPlayer";
            this.LblPlayer.Size = new System.Drawing.Size(222, 43);
            this.LblPlayer.TabIndex = 12;
            this.LblPlayer.Text = "Turn : Player1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(32, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 80);
            this.label3.TabIndex = 13;
            this.label3.Text = "winner";
            // 
            // LplWinner
            // 
            this.LplWinner.AutoSize = true;
            this.LplWinner.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LplWinner.ForeColor = System.Drawing.Color.LawnGreen;
            this.LplWinner.Location = new System.Drawing.Point(49, 277);
            this.LplWinner.Name = "LplWinner";
            this.LplWinner.Size = new System.Drawing.Size(197, 43);
            this.LplWinner.TabIndex = 11;
            this.LplWinner.Text = "In Prograce";
            // 
            // BtnRestartGame
            // 
            this.BtnRestartGame.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestartGame.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnRestartGame.Location = new System.Drawing.Point(12, 476);
            this.BtnRestartGame.Name = "BtnRestartGame";
            this.BtnRestartGame.Size = new System.Drawing.Size(262, 58);
            this.BtnRestartGame.TabIndex = 14;
            this.BtnRestartGame.Text = "Restart Game";
            this.BtnRestartGame.UseVisualStyleBackColor = false;
            this.BtnRestartGame.Click += new System.EventHandler(this.BtnRestartGame_Click);
            // 
            // picXO1
            // 
            this.picXO1.AllowDrop = true;
            this.picXO1.AutoSize = true;
            this.picXO1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picXO1.Cursor = System.Windows.Forms.Cursors.Default;
            this.picXO1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.picXO1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.picXO1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.picXO1.Location = new System.Drawing.Point(350, 95);
            this.picXO1.Name = "picXO1";
            this.picXO1.Size = new System.Drawing.Size(104, 104);
            this.picXO1.TabIndex = 15;
            this.picXO1.Tag = "?";
            this.picXO1.UseVisualStyleBackColor = false;
            this.picXO1.Click += new System.EventHandler(this.picXO_Click);
            // 
            // picXO4
            // 
            this.picXO4.AllowDrop = true;
            this.picXO4.AutoSize = true;
            this.picXO4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picXO4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.picXO4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.picXO4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.picXO4.Location = new System.Drawing.Point(350, 227);
            this.picXO4.Name = "picXO4";
            this.picXO4.Size = new System.Drawing.Size(104, 104);
            this.picXO4.TabIndex = 16;
            this.picXO4.Tag = "?";
            this.picXO4.UseVisualStyleBackColor = false;
            this.picXO4.Click += new System.EventHandler(this.picXO_Click);
            // 
            // picXO5
            // 
            this.picXO5.AllowDrop = true;
            this.picXO5.AutoSize = true;
            this.picXO5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picXO5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.picXO5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.picXO5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.picXO5.Location = new System.Drawing.Point(501, 227);
            this.picXO5.Name = "picXO5";
            this.picXO5.Size = new System.Drawing.Size(104, 104);
            this.picXO5.TabIndex = 17;
            this.picXO5.Tag = "?";
            this.picXO5.UseVisualStyleBackColor = false;
            this.picXO5.Click += new System.EventHandler(this.picXO_Click);
            // 
            // picXO6
            // 
            this.picXO6.AllowDrop = true;
            this.picXO6.AutoSize = true;
            this.picXO6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picXO6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.picXO6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.picXO6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.picXO6.Location = new System.Drawing.Point(652, 227);
            this.picXO6.Name = "picXO6";
            this.picXO6.Size = new System.Drawing.Size(104, 104);
            this.picXO6.TabIndex = 18;
            this.picXO6.Tag = "?";
            this.picXO6.UseVisualStyleBackColor = false;
            this.picXO6.Click += new System.EventHandler(this.picXO_Click);
            // 
            // picXO3
            // 
            this.picXO3.AllowDrop = true;
            this.picXO3.AutoSize = true;
            this.picXO3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picXO3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.picXO3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.picXO3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.picXO3.Location = new System.Drawing.Point(652, 95);
            this.picXO3.Name = "picXO3";
            this.picXO3.Size = new System.Drawing.Size(104, 104);
            this.picXO3.TabIndex = 19;
            this.picXO3.Tag = "?";
            this.picXO3.UseVisualStyleBackColor = false;
            this.picXO3.Click += new System.EventHandler(this.picXO_Click);
            // 
            // picXO2
            // 
            this.picXO2.AllowDrop = true;
            this.picXO2.AutoSize = true;
            this.picXO2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picXO2.Cursor = System.Windows.Forms.Cursors.Default;
            this.picXO2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.picXO2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.picXO2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.picXO2.Location = new System.Drawing.Point(501, 95);
            this.picXO2.Name = "picXO2";
            this.picXO2.Size = new System.Drawing.Size(104, 104);
            this.picXO2.TabIndex = 20;
            this.picXO2.Tag = "?";
            this.picXO2.UseVisualStyleBackColor = false;
            this.picXO2.Click += new System.EventHandler(this.picXO_Click);
            // 
            // picXO7
            // 
            this.picXO7.AllowDrop = true;
            this.picXO7.AutoSize = true;
            this.picXO7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picXO7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.picXO7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.picXO7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.picXO7.Location = new System.Drawing.Point(350, 359);
            this.picXO7.Name = "picXO7";
            this.picXO7.Size = new System.Drawing.Size(104, 104);
            this.picXO7.TabIndex = 21;
            this.picXO7.Tag = "?";
            this.picXO7.UseVisualStyleBackColor = false;
            this.picXO7.Click += new System.EventHandler(this.picXO_Click);
            // 
            // picXO8
            // 
            this.picXO8.AllowDrop = true;
            this.picXO8.AutoSize = true;
            this.picXO8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picXO8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.picXO8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.picXO8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.picXO8.Location = new System.Drawing.Point(501, 359);
            this.picXO8.Name = "picXO8";
            this.picXO8.Size = new System.Drawing.Size(104, 104);
            this.picXO8.TabIndex = 22;
            this.picXO8.Tag = "?";
            this.picXO8.UseVisualStyleBackColor = false;
            this.picXO8.Click += new System.EventHandler(this.picXO_Click);
            // 
            // picXO9
            // 
            this.picXO9.AllowDrop = true;
            this.picXO9.AutoSize = true;
            this.picXO9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picXO9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.picXO9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.picXO9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.picXO9.Location = new System.Drawing.Point(652, 359);
            this.picXO9.Name = "picXO9";
            this.picXO9.Size = new System.Drawing.Size(104, 104);
            this.picXO9.TabIndex = 23;
            this.picXO9.Tag = "?";
            this.picXO9.UseVisualStyleBackColor = false;
            this.picXO9.Click += new System.EventHandler(this.picXO_Click);
            // 
            // BtnResetScores
            // 
            this.BtnResetScores.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnResetScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetScores.ForeColor = System.Drawing.Color.Gold;
            this.BtnResetScores.Location = new System.Drawing.Point(575, 476);
            this.BtnResetScores.Name = "BtnResetScores";
            this.BtnResetScores.Size = new System.Drawing.Size(262, 58);
            this.BtnResetScores.TabIndex = 24;
            this.BtnResetScores.Text = "Reset Scores";
            this.BtnResetScores.UseVisualStyleBackColor = false;
            this.BtnResetScores.Click += new System.EventHandler(this.BtnResetScores_Click);
            // 
            // lblScorePlayer2
            // 
            this.lblScorePlayer2.AutoSize = true;
            this.lblScorePlayer2.BackColor = System.Drawing.Color.Gold;
            this.lblScorePlayer2.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblScorePlayer2.Location = new System.Drawing.Point(46, 402);
            this.lblScorePlayer2.Name = "lblScorePlayer2";
            this.lblScorePlayer2.Size = new System.Drawing.Size(178, 43);
            this.lblScorePlayer2.TabIndex = 25;
            this.lblScorePlayer2.Text = "Player 2: 0";
            // 
            // lblScorePlayer1
            // 
            this.lblScorePlayer1.AutoSize = true;
            this.lblScorePlayer1.BackColor = System.Drawing.Color.Gold;
            this.lblScorePlayer1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblScorePlayer1.Location = new System.Drawing.Point(49, 336);
            this.lblScorePlayer1.Name = "lblScorePlayer1";
            this.lblScorePlayer1.Size = new System.Drawing.Size(173, 43);
            this.lblScorePlayer1.TabIndex = 26;
            this.lblScorePlayer1.Text = "Player 1: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(849, 546);
            this.Controls.Add(this.lblScorePlayer1);
            this.Controls.Add(this.lblScorePlayer2);
            this.Controls.Add(this.BtnResetScores);
            this.Controls.Add(this.picXO9);
            this.Controls.Add(this.picXO8);
            this.Controls.Add(this.picXO7);
            this.Controls.Add(this.picXO2);
            this.Controls.Add(this.picXO3);
            this.Controls.Add(this.picXO6);
            this.Controls.Add(this.picXO5);
            this.Controls.Add(this.picXO4);
            this.Controls.Add(this.picXO1);
            this.Controls.Add(this.BtnRestartGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPlayer);
            this.Controls.Add(this.LplWinner);
            this.Controls.Add(this.pctIcon);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            ((System.ComponentModel.ISupportInitialize)(this.pctIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctIcon;
        private System.Windows.Forms.Label LblPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LplWinner;
        private System.Windows.Forms.Button BtnRestartGame;
        private System.Windows.Forms.Button picXO1;
        private System.Windows.Forms.Button picXO4;
        private System.Windows.Forms.Button picXO5;
        private System.Windows.Forms.Button picXO6;
        private System.Windows.Forms.Button picXO3;
        private System.Windows.Forms.Button picXO2;
        private System.Windows.Forms.Button picXO7;
        private System.Windows.Forms.Button picXO8;
        private System.Windows.Forms.Button picXO9;
        private System.Windows.Forms.Button BtnResetScores;
        private System.Windows.Forms.Label lblScorePlayer2;
        private System.Windows.Forms.Label lblScorePlayer1;
    }
}


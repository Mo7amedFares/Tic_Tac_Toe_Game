using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        int scorePlayer1 = 0;
        int scorePlayer2 = 0;
        int gameCounter = 0;

        enum enWinner
        {
            player1,
            player2,
            draw,
            IN_PROGRESS
        }
        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        void isEndGame()
        {
            switch (IsWinner())
            {
                case enWinner.player1:
                    LplWinner.Text = "Player1 Wins";
                    DisableAllCells();
                    LblPlayer.Text = "Game Over";
                    scorePlayer1++;
                    gameCounter++;
                    UpdateScoreboard();
                    break;
                case enWinner.player2:
                    LplWinner.Text = "Player2 Wins";
                    DisableAllCells();
                    LblPlayer.Text = "Game Over";
                    scorePlayer2++;
                    gameCounter++;
                    UpdateScoreboard();
                    break;
                case enWinner.draw:
                    LplWinner.Text = "Draw";
                    DisableAllCells();
                    LblPlayer.Text = "Game Over";
                    gameCounter++;
                    break;
                case enWinner.IN_PROGRESS:
                    break;
            }
        }

        private enWinner IsWinner()
        {
            if (picXO1.Tag == picXO2.Tag && picXO2.Tag == picXO3.Tag && picXO1.Tag.ToString() != "?")
            {
                if (picXO1.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;

            }
            else if (picXO4.Tag == picXO5.Tag && picXO5.Tag == picXO6.Tag && picXO6.Tag.ToString() != "?")
            {
                if (picXO4.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (picXO7.Tag == picXO8.Tag && picXO8.Tag == picXO9.Tag && picXO9.Tag.ToString() != "?")
            {
                if (picXO7.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (picXO1.Tag == picXO4.Tag && picXO4.Tag == picXO7.Tag && picXO7.Tag.ToString() != "?")
            {
                if (picXO1.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (picXO2.Tag == picXO5.Tag && picXO5.Tag == picXO8.Tag && picXO8.Tag.ToString() != "?")
            {
                if (picXO2.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (picXO3.Tag == picXO6.Tag && picXO6.Tag == picXO9.Tag && picXO9.Tag.ToString() != "?")
            {
                if (picXO3.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (picXO1.Tag == picXO5.Tag && picXO5.Tag == picXO9.Tag && picXO9.Tag.ToString() != "?")
            {
                if (picXO1.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (picXO3.Tag == picXO5.Tag && picXO5.Tag == picXO7.Tag && picXO7.Tag.ToString() != "?")
            {
                if (picXO3.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (picXO1.Tag.ToString() != "?" && picXO2.Tag.ToString() != "?" && picXO3.Tag.ToString() != "?" && picXO4.Tag.ToString() != "?" && picXO5.Tag.ToString() != "?" && picXO6.Tag.ToString() != "?" && picXO7.Tag.ToString() != "?" && picXO8.Tag.ToString() != "?" && picXO9.Tag.ToString() != "?")
            {
                return enWinner.draw;
            }

            return enWinner.IN_PROGRESS;

        }

        void ResetGame()
        {
            picXO1.Image = Properties.Resources.question_mark_96;
            picXO2.Image = Properties.Resources.question_mark_96;
            picXO3.Image = Properties.Resources.question_mark_96;
            picXO4.Image = Properties.Resources.question_mark_96;
            picXO5.Image = Properties.Resources.question_mark_96;
            picXO6.Image = Properties.Resources.question_mark_96;
            picXO7.Image = Properties.Resources.question_mark_96;
            picXO8.Image = Properties.Resources.question_mark_96;
            picXO9.Image = Properties.Resources.question_mark_96;

            picXO1.Tag = "?";
            picXO2.Tag = "?";
            picXO3.Tag = "?";
            picXO4.Tag = "?";
            picXO5.Tag = "?";
            picXO6.Tag = "?";
            picXO7.Tag = "?";
            picXO8.Tag = "?";
            picXO9.Tag = "?";

            EnableAllCells();

            LblPlayer.Text = "Turn : Player1";
            LplWinner.Text = "In Progress";
        }

        void DisableAllCells()
        {
            picXO1.Enabled = false;
            picXO2.Enabled = false;
            picXO3.Enabled = false;
            picXO4.Enabled = false;
            picXO5.Enabled = false;
            picXO6.Enabled = false;
            picXO7.Enabled = false;
            picXO8.Enabled = false;
            picXO9.Enabled = false;
        }

        void EnableAllCells()
        {
            picXO1.Enabled = true;
            picXO2.Enabled = true;
            picXO3.Enabled = true;
            picXO4.Enabled = true;
            picXO5.Enabled = true;
            picXO6.Enabled = true;
            picXO7.Enabled = true;
            picXO8.Enabled = true;
            picXO9.Enabled = true;
        }

        void Clicked(Button button)
        {
            if (button.Tag.ToString() == "?")
            {
                if (LblPlayer.Text == "Turn : Player1")
                {
                    button.Image = Properties.Resources.X;
                    LblPlayer.Text = "Turn : Player2";
                    button.Tag = "X";
                }
                else
                {
                    button.Image = Properties.Resources.O;
                    LblPlayer.Text = "Turn : Player1";
                    button.Tag = "O";
                }
                isEndGame();
            }
            else
            {
                MessageBox.Show("This cell is already taken");
            }
        }

        void UpdateScoreboard()
        {
            lblScorePlayer1.Text = $"Player 1: {scorePlayer1}";
            lblScorePlayer2.Text = $"Player 2: {scorePlayer2}";
        }

        private void picXO1_Click(object sender, EventArgs e)
        {
            Clicked(picXO1);
        }

        private void BtnRestartGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }



        private void picXO2_Click(object sender, EventArgs e)
        {
            Clicked(picXO2);
        }

        private void picXO3_Click(object sender, EventArgs e)
        {
            Clicked(picXO3);
        }

        private void picXO4_Click(object sender, EventArgs e)
        {
            Clicked(picXO4);
        }

        private void picXO5_Click(object sender, EventArgs e)
        {
            Clicked(picXO5);
        }

        private void picXO6_Click(object sender, EventArgs e)
        {
            Clicked(picXO6);
        }

        private void picXO7_Click(object sender, EventArgs e)
        {
            Clicked(picXO7);
        }

        private void picXO8_Click(object sender, EventArgs e)
        {
            Clicked(picXO8);
        }

        private void picXO9_Click(object sender, EventArgs e)
        {
            Clicked(picXO9);
        }

        private void BtnResetScores_Click(object sender, EventArgs e)
        {
            scorePlayer1 = 0;
            scorePlayer2 = 0;
            UpdateScoreboard();
            ResetGame();
        }
    }
}

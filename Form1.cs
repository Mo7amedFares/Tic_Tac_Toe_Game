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
        int gameCount = 0;

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
                    gameCount++;
                    UpdateScoreboard();
                    break;
                case enWinner.player2:
                    LplWinner.Text = "Player2 Wins";
                    DisableAllCells();
                    LblPlayer.Text = "Game Over";
                    scorePlayer2++;
                    gameCount++;
                    UpdateScoreboard();
                    break;
                case enWinner.draw:
                    LplWinner.Text = "Draw";
                    DisableAllCells();
                    LblPlayer.Text = "Game Over";
                    gameCount++;
                    break;
                case enWinner.IN_PROGRESS:
                    break;
            }
        }
        bool chickValue(Button button1 , Button button2 , Button button3)
        {
            if (button1.Tag == button2.Tag && button2.Tag == button3.Tag && button1.Tag.ToString() != "?")
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                return true;
            }
            return false;
        }
        private enWinner IsWinner()
        {
            if (chickValue(picXO1 , picXO2 , picXO3))
            {
                if (picXO1.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;

            }
            else if (chickValue(picXO4 , picXO5 , picXO6 ))
            {
                if (picXO4.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (chickValue(picXO7, picXO8, picXO9))
            {
                if (picXO7.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (chickValue(picXO1, picXO4, picXO7))
            {
                if (picXO1.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (chickValue(picXO2, picXO5, picXO8))
            {
                if (picXO2.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (chickValue(picXO3, picXO6, picXO9))
            {
                if (picXO3.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (chickValue(picXO1, picXO5, picXO9))
            {
                if (picXO1.Tag.ToString() == "X")
                    return enWinner.player1;
                else
                    return enWinner.player2;
            }
            else if (chickValue(picXO3, picXO5, picXO7))
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
        void ResetButton(Button button)
        {
            button.Image = Properties.Resources.question_mark_96;
            button.Tag = "?";
            button.BackColor = Color.Black;
            button.Enabled = true;
        }

        void ResetGame()
        {
            ResetButton(picXO1);
            ResetButton(picXO2);
            ResetButton(picXO3);
            ResetButton(picXO4);
            ResetButton(picXO5);
            ResetButton(picXO6);
            ResetButton(picXO7);
            ResetButton(picXO8);
            ResetButton(picXO9);

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

        private void BtnRestartGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void BtnResetScores_Click(object sender, EventArgs e)
        {
            scorePlayer1 = 0;
            scorePlayer2 = 0;
            UpdateScoreboard();
            ResetGame();
        }
        private void picXO_Click(object sender, EventArgs e)
        {
            Clicked((Button)sender);
        }

    }
}

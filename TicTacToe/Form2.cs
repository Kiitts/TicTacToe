using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        // initialize if it's first turn or not and initialize the 3x3 array to be used to check
        // if there's a winning combination
        public static bool firstTurn = true;
        public static string[,] rcv = new string[3,3] {{"","",""}, {"","",""}, {"","",""}};
        public Form2()
        {
            InitializeComponent();
        }
        private void resetScore_Click(object sender, EventArgs e)
        {
            Reset(false);
        }
        private void goBack_Click(object sender, EventArgs e)
        {
            // clicking back will reset all the data created in the gamearea and go back to main menu form
            Reset(false);
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }
        private void gameInput(ref string rcv, PictureBox rc)
        {
            // reference rcv will update the new value outside this function when it changes inside the function
            // PictureBox rc will be the picturebox to be sended in this function so that it will change
            // it's according image
            // this function will put the input on every picture box created by players
            if (rcv == string.Empty)
            {
                // if the according rcv doesn't have any input
                if (firstTurn)
                {
                    // if it's players 1 turn cross will be the input
                    rc.Image = Properties.Resources.cross;
                    rcv = "cross";
                    firstTurn = false;
                    whoNext.Image = Properties.Resources.circle;
                }
                else
                {
                    rc.Image = Properties.Resources.circle;
                    rcv = "circle";
                    firstTurn = true;
                    whoNext.Image = Properties.Resources.cross;
                }
            }
        }
        private void Reset(bool winningReset = true)
        {
            // winningReset will know if these reset are because there's a winner or not
            // this will reset all the data created inside gameArea
            PictureBox[] rc = { r1c1, r1c2, r1c3, r2c1, r2c2, r2c3, r3c1, r3c2, r3c3 };
            for (int i = 0; i < rc.Length; i++)
            {
                rc[i].Image = null;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rcv[i, j] = "";
                }
            }
            whoNext.Image = Properties.Resources.cross;
            firstTurn = true;
            if(!winningReset)
            {
                // if there's no winner for this reset it will also reset the scores
                player1Score.Text = "0";
                player2Score.Text = "0";
            }
        }
        private void checkWinning()
        {
            // this will check if there's a winner or a draw
            bool draw = false;
            if ((rcv[0,0] == "cross" && rcv[0,1] == "cross" && rcv[0,2] == "cross")||
                (rcv[0,0] == "cross" && rcv[1,0] == "cross" && rcv[2,0] == "cross")||
                (rcv[0,0] == "cross" && rcv[1,1] == "cross" && rcv[2,2] == "cross")||
                (rcv[1,0] == "cross" && rcv[1,1] == "cross" && rcv[1,2] == "cross")||
                (rcv[2,0] == "cross" && rcv[1,1] == "cross" && rcv[0,2] == "cross")||
                (rcv[2,0] == "cross" && rcv[2,1] == "cross" && rcv[2,2] == "cross")||
                (rcv[0,1] == "cross" && rcv[1,1] == "cross" && rcv[2,1] == "cross")||
                (rcv[0,2] == "cross" && rcv[1,2] == "cross" && rcv[2,2] == "cross"))
            {
                // if player 1 won
                MessageBox.Show("Player 1 WINS!", "Winner Winner Chicken Dinner!");
                Reset();
                player1Score.Text = (int.Parse(player1Score.Text) + 1).ToString();
            }
            else if ((rcv[0, 0] == "circle" && rcv[0, 1] == "circle" && rcv[0, 2] == "circle") ||
                (rcv[0, 0] == "circle" && rcv[1, 0] == "circle" && rcv[2, 0] == "circle") ||
                (rcv[0, 0] == "circle" && rcv[1, 1] == "circle" && rcv[2, 2] == "circle") ||
                (rcv[1, 0] == "circle" && rcv[1, 1] == "circle" && rcv[1, 2] == "circle") ||
                (rcv[2, 0] == "circle" && rcv[1, 1] == "circle" && rcv[0, 2] == "circle") ||
                (rcv[2, 0] == "circle" && rcv[2, 1] == "circle" && rcv[2, 2] == "circle") ||
                (rcv[0, 1] == "circle" && rcv[1, 1] == "circle" && rcv[2, 1] == "circle") ||
                (rcv[0, 2] == "circle" && rcv[1, 2] == "circle" && rcv[2, 2] == "circle"))
            {
                // if player 2 won
                MessageBox.Show("Player 2 WINS!", "Winner Winner Chicken Dinner!");
                Reset();
                player2Score.Text = (int.Parse(player2Score.Text) + 1).ToString();
            }
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (rcv[i, j] == string.Empty)
                    {
                        draw = false;
                        break;
                    }
                    draw = true;
                }
                if(!draw)
                {
                    break;
                }
            }
            if(draw)
            {
                // if draw
                MessageBox.Show("DRAW!", "No chicken dinner.");
                Reset();
            }
        }
        private void r1c1_Click(object sender, EventArgs e)
        {
            gameInput(ref rcv[0, 0], r1c1);
            checkWinning();
        }

        private void r1c2_Click(object sender, EventArgs e)
        {
            gameInput(ref rcv[0, 1], r1c2);
            checkWinning();
        }

        private void r1c3_Click(object sender, EventArgs e)
        {
            gameInput(ref rcv[0, 2], r1c3);
            checkWinning();
        }

        private void r2c1_Click(object sender, EventArgs e)
        {
            gameInput(ref rcv[1, 0], r2c1);
            checkWinning();
        }

        private void r2c2_Click(object sender, EventArgs e)
        {
            gameInput(ref rcv[1, 1], r2c2);
            checkWinning();
        }

        private void r2c3_Click(object sender, EventArgs e)
        {
            gameInput(ref rcv[1, 2], r2c3);
            checkWinning();
        }

        private void r3c1_Click(object sender, EventArgs e)
        {
            gameInput(ref rcv[2, 0], r3c1);
            checkWinning();
        }

        private void r3c2_Click(object sender, EventArgs e)
        {
            gameInput(ref rcv[2, 1], r3c2);
            checkWinning();
        }

        private void r3c3_Click(object sender, EventArgs e)
        {
            gameInput(ref rcv[2, 2], r3c3);
            checkWinning();
        }

    }
}

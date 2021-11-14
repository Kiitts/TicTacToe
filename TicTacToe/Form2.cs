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
        // initialize if it's first turn or what
        public static bool firstTurn = true;
        public static string[,] rcv = new string[3,3] {{"","",""}, {"","",""}, {"","",""}};
        public Form2()
        {
            InitializeComponent();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Reset(false);
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }
        private void gameInput(ref string rcv, PictureBox rc)
        {
            if (rcv == string.Empty)
            {
                if (firstTurn)
                {
                    rc.Image = Image.FromFile("../../img/cross.png");
                    rcv = "cross";
                    firstTurn = false;
                    whoNext.Image = Image.FromFile("../../img/circle.png");
                }
                else
                {
                    rc.Image = Image.FromFile("../../img/circle.png");
                    rcv = "circle";
                    firstTurn = true;
                    whoNext.Image = Image.FromFile("../../img/cross.png");
                }
            }
        }
        private void Reset(bool winningReset = true)
        {
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
            whoNext.Image = Image.FromFile("../../img/cross.png");
            firstTurn = true;
            if(!winningReset)
            {
                player1Score.Text = "0";
                player2Score.Text = "0";
            }
        }
        private void checkWinning()
        {
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

        private void resetScore_Click(object sender, EventArgs e)
        {
            Reset(false);
        }
    }
}

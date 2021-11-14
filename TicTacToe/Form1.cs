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
    public partial class MainMenu : Form
    {
        public static bool player2Game = false;
        public static Form2 gameArea = new Form2();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void player1Btn_Click(object sender, EventArgs e)
        {
            //player2Game = false;
            //this.Hide();

            //AiSettings settings = new AiSettings();
            //settings.TopMost = true;
            //gameArea.Show();
            //settings.ShowDialog();

        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // if the form 1 will be closed the whole application will shutdown
            Application.Exit();
        }

        private void player2Btn_Click(object sender, EventArgs e)
        {
            // after clicking button we will be redirect to another form which is the gaming area
            // this is only for 2 players hotseated games which means this can be only played in 1 device
            player2Game = true;
            this.Hide();
            gameArea.Show();
        }
    }
}

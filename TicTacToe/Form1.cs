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
            Application.Exit();
        }

        private void player2Btn_Click(object sender, EventArgs e)
        {
            player2Game = true;
            this.Hide();
            gameArea.Show();
        }
    }
}

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
        public static Form2 gameArea = new Form2();
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // if the form 1 will be closed the whole application will shutdown
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // this is only for 2 players hotseated games which means this can be only played in 1 device
            this.Hide();
            gameArea.Show();
        }
    }
}

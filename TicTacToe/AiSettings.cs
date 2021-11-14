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
    public partial class AiSettings : Form
    {
        private bool playerFirst = false;

        public AiSettings()
        {
            InitializeComponent();
        }

        private void aiGoFirst_Click(object sender, EventArgs e)
        {
            playerFirst = true;
            this.Close();
        }

        private void btnGoBack_Click_1(object sender, EventArgs e)
        {
            MainMenu.gameArea.Hide();
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void aiGoSecond_Click(object sender, EventArgs e)
        {
            playerFirst = true;
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clue
{
    public partial class PlayerChoose : Form
    {
        public PlayerChoose()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int playerCount = 0;
            string playerName = comboBox1.Text;
            playerCount = Convert.ToInt32(playerName);


            // Assuming you have a method to start the game with the selected number of players
            StartGame(playerCount);
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        public void StartGame(int playerCount)
        {
            // Logic to start the game with the selected number of players
            // For example, you can create a new game instance and pass the player count to it
            // Game game = new Game(playerCount);
            // game.Start();

            
        }
    }
}

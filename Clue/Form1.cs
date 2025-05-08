using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://github.com/ckdghks5179/clue_game
//https://github.com/ckdghks5179/clue_game.git


namespace Clue
{
    public partial class Form1 : Form
    {
        int[,] clue_map; // Declare the field without initialization here
        Point[,] clue_map_point;

        struct Player_info
        {
            public string name;
            public int id;
            public PictureBox player;

            public int x;
            public int y;
        }

        private void InitializeClueMap() // Initialize the array in a method
        {
            //empty = 0, wall = 1, door = 2, player = 3
            clue_map = new int[,]
            {
                { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1}, 
                { 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 0, 0, 2, 1, 1, 1, 1, 1, 1, 2, 0, 0, 0, 2, 1, 1, 1, 1},
                { 1, 1, 1, 1, 2, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 1, 1, 1, 1, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 2, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 1, 2, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 2, 1},
                { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 2, 1, 1, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 2, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 2, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 2, 1, 1, 0, 0, 2, 1, 1, 1, 1, 1, 1},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 2, 2, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 2, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 1, 2, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1},
                { 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1}
            };
            //player(7,0) (17,0) (24,7) (0,14) (6,23) (19,23)
            //주방(6,4), 공부방 비밀통로
            //무도회장(5,8) (5,15) (7,9) (7,14)
            //온실(5,19), 라운지 비밀통로
            //식당(12,7) (15,6)
            //최종추리방(10,12) (13,10) (13, 14) (16,12)
            //당구장 (9,18) (12,22)
            //서재 (14,20) (16,17)
            //라운지 (19,5), 온실 비밀통로
            //홀(18,11) (18,12) (20,14)
            //공부방(21,18), 주방 비밀통로

            player1.Location = clue_map_point[0, 0];
            clue_map[7, 0] = 3;
            Player_info firstPlayer = new Player_info();
            firstPlayer.x = 7;
            firstPlayer.y = 0;

            player2.Location = clue_map_point[24, 7];
            clue_map[24, 7] = 3;
            Player_info secondPlayer = new Player_info();
            secondPlayer.x = 24;
            secondPlayer.y = 7;
        }

        private void InitializeClueMap_Point()
        {
            clue_map_point = new Point[25, 24];
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    clue_map_point[i, j] = new Point(8+i*20, 8+j*16);
                }
            }
        }

        private int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public Form1()
        {
            InitializeComponent();
            InitializeClueMap_Point();
            InitializeClueMap();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            player1.SizeMode = PictureBoxSizeMode.StretchImage;
            player2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int dice1Value = RollDice();
            int dice2Value = RollDice();
            dice1.Text = dice1Value.ToString();
            dice2.Text = dice2Value.ToString();

            int total = dice1Value + dice2Value;
            lbRemain.Text = total.ToString();
            btnRoll.Enabled = false;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lbRemain.Text != "0")
            {
                /*
                if (clue_map[firstPlayer.x-1, firstPlayer.y] != 1)
                {
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 16);
                    lbRemain.Text = (int.Parse(lbRemain.Text) - 1).ToString();

                    clue_map[firstPlayer.x, firstPlayer.y] = 0;
                    firstPlayer.x -= 1;
                    clue_map[firstPlayer.x, firstPlayer.y] = 3;

                }*/
                player1.Location = new Point(player1.Location.X, player1.Location.Y - 16);
                lbRemain.Text = (int.Parse(lbRemain.Text) - 1).ToString();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lbRemain.Text != "0")
            {

                player1.Location = new Point(player1.Location.X, player1.Location.Y + 16);
                lbRemain.Text = (int.Parse(lbRemain.Text) - 1).ToString();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lbRemain.Text != "0")
            {
                player1.Location = new Point(player1.Location.X + 20, player1.Location.Y);
                lbRemain.Text = (int.Parse(lbRemain.Text) - 1).ToString();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lbRemain.Text != "0")
            {
                player1.Location = new Point(player1.Location.X - 20, player1.Location.Y);
                lbRemain.Text = (int.Parse(lbRemain.Text) - 1).ToString();
            }
        }

        private void btnTurnEnd_Click(object sender, EventArgs e)
        {
            lbRemain.Text = "0";
            btnRoll.Enabled = true;
        }
    }
}

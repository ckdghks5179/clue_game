using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


//https://github.com/ckdghks5179/clue_game
//https://github.com/ckdghks5179/clue_game.git


namespace Clue
{





    public partial class Form1 : Form
    {
        Form2 notePad;

        private GameState gameState;
        private int playerId;
        private PictureBox myPlayerBox;
        private Dictionary<int, PictureBox> playerBoxes = new Dictionary<int, PictureBox>();
        //private Point[,] clue_map_point;
        private int[,] clue_map => gameState.clue_map;

        private Player[] playerList => gameState.Players;
        private Player player;
        List<Card> cardList = new List<Card>();

        //int currentTurnPlayer = 0;

        List<string> mans = new List<string>();
        List<string> weapons = new List<string>();
        List<string> rooms = new List<string>();

        string[] man = { "Green", "Mustard", "Peacock", "Plum", "Scarlett", "White" };
        string[] weapon = { "촛대", "파이프", "리볼버", "밧줄", "렌치", "단검" };
        string[] room = { "주방", "공부방", "무도회장", "온실", "식당", "당구장", "서재", "라운지", "홀" };

        /* void EndTurn()
         {
             currentTurnPlayer = (currentTurnPlayer + 1) % playerList.Length;
         }*/



        /*   public void AddPlayer(int id, string name)
           {
               Player player = new Player();
               player.id = id;
               player.name = name;
               player.cards = new List<Card>();
               playerList[id] = player;

               //player(7,0) (17,0) (24,7) (0,14) (6,23) (19,23)
               int[] initialX = { 7, 17, 24, 0, 6, 19 };
               int[] initialY = { 0, 0, 7, 14, 23, 23 };

               player.x = initialX[id];
               player.y = initialY[id];
               player.isTurn = false;
               player.isInRoom = false;
               player.isAlive = true;
           }*/



        private void InitializeClueMap()
        {
            //empty = 0, wall = 1, door = 2, player = 3, room = 4
            //clue_map = gameState.clue_map;
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

            /*  player1.Location = clue_map_point[7, 0];
              clue_map[7, 0] = 3;
              Player firstPlayer = new Player();
              firstPlayer.x = 7;
              firstPlayer.y = 0;
              playerList[0] = firstPlayer;

              player2.Location = clue_map_point[6, 23];
              clue_map[6, 23] = 3;
              Player secondPlayer = new Player();
              secondPlayer.x = 23;
              secondPlayer.y = 6;
              playerList[1] = secondPlayer;*/

        }

        /*  private void InitializeClueMap_Point()
          {
              //Point(x = 열, y = 행)
              clue_map_point = new Point[25, 24];
              for (int i = 0; i < 25; i++)
              {
                  for (int j = 0; j < 24; j++)
                  {
                      clue_map_point[i, j] = new Point(8 + j * 20, 8 + i * 16);
                  }
              }
          }*/

        /* private void OpenPlayerChooseForm()
         {
             PlayerChoose ChooseForm = new PlayerChoose();
             ChooseForm.ShowDialog();  
         }
 */
        private int RollDice()
        {
            Random random = new Random();
            return random.Next(2, 13);
        }

       /* private bool isDoor(int x, int y)
        {
            if (clue_map[x, y] == 2)
            {
                return true;
            }
            return false;
        }*/

        public Form1(GameState gamestate1, int playerId)
        {
            InitializeComponent();
            //InitializeClueMap_Point();
            //InitializeClueMap();
            //OpenPlayerChooseForm();
            this.gameState = gamestate1;
            this.playerId = playerId;
            this.player = playerList[playerId];
        }

        private void UpdateControlState()
        {
            bool isMyTurn = gameState.CurrentTurn == playerId;
            btnRoll.Enabled = isMyTurn;
            btnTurnEnd.Enabled = isMyTurn;

            /* btnUp.Enabled = isMyTurn;
             btnDown.Enabled = isMyTurn;
             btnLeft.Enabled = isMyTurn;
             btnRight.Enabled = isMyTurn;
             btnTurnEnd.Enabled = isMyTurn;
            */
        }
        private Color GetPlayerColor(int id)
        {
            Color[] colors = new Color[] { Color.Green, Color.Red, Color.Blue, Color.Purple, Color.Orange, Color.White };
            return colors[id % colors.Length];
        }

        public void UpdatePlayerPositions()
        {
            for (int i = 0; i < gameState.TotalPlayers; i++)
            {
                var p = gameState.Players[i];
                if (playerBoxes.ContainsKey(i))
                {
                    playerBoxes[i].Location = gameState.clue_map_point[p.x, p.y];
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            for (int i = 0; i < gameState.TotalPlayers; i++)
            {
                Player p = gameState.Players[i];

                PictureBox playerBox = new PictureBox
                {
                    Name = $"playerBox{i}",
                    Size = new Size(20, 20),
                    BackColor = GetPlayerColor(i), // 각 플레이어마다 다른 색상
                    Location = gameState.clue_map_point[p.x, p.y],
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                playerBoxes[i] = playerBox;

                this.Controls.Add(playerBox);


                playerBox.BringToFront();
                // ⬇️ 현재 Form이 담당하는 플레이어라면 저장
                if (i == playerId)
                {
                    myPlayerBox = playerBox;
                }
            }

            UpdateControlState();

            
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int diceValue = RollDice();
            dice1.Text = diceValue.ToString();
            lbRemain.Text = diceValue.ToString();
            btnRoll.Enabled = false;
        }

        private void TryMove(int dx, int dy)
        {
            if (int.Parse(lbRemain.Text) <= 0) return;

            int newX = player.x + dx;
            int newY = player.y + dy;

            if (newX < 0 || newX >= 25 || newY < 0 || newY >= 24) return;
            if (gameState.clue_map[newX, newY] == 1) return;

            gameState.clue_map[player.x, player.y] = 0;
            player.x = newX;
            player.y = newY;
            gameState.clue_map[newX, newY] = 3;
            playerBoxes[playerId].Location = gameState.clue_map_point[newX, newY];
            lbRemain.Text = (int.Parse(lbRemain.Text) - 1).ToString();
        }


        private void btnUp_Click(object sender, EventArgs e)
        {

            TryMove(-1, 0);
            

        }   
        private void btnDown_Click(object sender, EventArgs e)
        {

            TryMove(1, 0);
           
        }

        private void btnRight_Click(object sender, EventArgs e)
        {

            TryMove(0, 1);
           
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            TryMove(0, -1);
           
        }

        private void btnTurnEnd_Click(object sender, EventArgs e)
        {
            //btnRoll.Enabled = true;
            lbRemain.Text = "0";
            gameState.AdvanceTurn();
            foreach (var form in PlayerChoose.AllPlayerForms)
            {
                form.UpdateControlState();
                form.UpdatePlayerPositions();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            notePad = new Form2();
            notePad.Show();
        }
    }
}

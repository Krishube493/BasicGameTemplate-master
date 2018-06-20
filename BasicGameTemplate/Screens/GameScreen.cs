using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace BasicGameTemplate
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys
        Boolean upArrowDown, spaceDown;
        //initial starting points for character 
        int drawX = 10;
        int drawY = 250;
        int heroWidth = 60;
        int heroHeight = 75; 
        //monster 
        int monsterHeight = 45;
        List<int> enemyImage = new List<int>();
        List<int> emyX = new List<int>();
        List<int> emyY = new List<int>();
        int speedcounter = 0;
        int emymove = 5;
        int generateCounter = 100;
        Random randGen = new Random();
        //Graphics objects
        SolidBrush heroBrush = new SolidBrush(Color.Black);
        int background = 1;
        int characterCounter = 0;
        int frame = 1;
        int jumptimer = 1;
        int change = 1;
        int score = 0;
        Boolean jump = false;
        Boolean dead = false;

        public GameScreen()
        {
            InitializeComponent();
            Form1.service.startGame();
            emyX.Add(675);
            emyY.Add(286);
            enemyImage.Add(1);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // opens a pause screen is escape is pressed. Depending on what is pressed
            // on pause screen the program will either continue or exit to main menu
            if (e.KeyCode == Keys.Escape)
            {
                gameTimer.Enabled = false;
                upArrowDown = spaceDown = false;

                DialogResult result = PauseForm.Show();

                if (result == DialogResult.Cancel)
                {
                    gameTimer.Enabled = true;
                }
                if (result == DialogResult.Abort)
                {
                    Form1.changeScreen(this, "MenuScreen");
                }
            }

            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
            }
        }

        /// <summary>
        /// Little dino game :)
        /// by Kristianna 
        /// </summary>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            background++;
            characterCounter++;
            generateCounter--;
            score++;
            speedcounter++;
            SoundPlayer jumpSound = new SoundPlayer(Properties.Resources.Jump_Sound_Effect);

            //background change 
            if (background == 450)
            {
                if (change == 1)
                {
                    change = 2;
                    background = 0;
                    this.BackgroundImage = Properties.Resources.Day_background;
                }

                else if (change == 2)
                {
                    change = 1;
                    background = 0;
                    this.BackgroundImage = Properties.Resources.Night_background;
                }
            }

            //main character movements 
            if (upArrowDown == true && drawY == 250 || spaceDown == true && drawY == 250)
            {
                jump = true;
            }

            if (jump == true)
            {
                if (jumptimer == 1)
                {
                    jumpSound.Play();
                    drawY = drawY - 28;
                    jumptimer++;
                }

                else if (jumptimer == 2)
                {
                    jumptimer++;
                }

                else if (jumptimer == 3)
                {
                    drawY = drawY - 28;
                    jumptimer++;
                }

                else if (jumptimer == 4)
                {
                    jumptimer++;
                }

                else if (jumptimer == 5)
                {
                    drawY = drawY - 20;
                    jumptimer++;
                }

                else if (jumptimer == 6)
                {
                    jumptimer++;
                }

                else if (jumptimer == 7)
                {
                    drawY = drawY - 20;
                    jumptimer++;
                }

                else if (jumptimer == 8)
                {
                    jumptimer++;
                }

                else if (jumptimer == 9)
                {
                    drawY = drawY - 12;
                    jumptimer++;
                }

                else if (jumptimer == 10)
                {
                    jumptimer++;
                }

                else if (jumptimer == 11)
                {
                    drawY = drawY - 12;
                    jumptimer++;
                }

                else if (jumptimer == 12)
                {
                    jumptimer++;
                }

                else if (jumptimer == 13)
                {
                    drawY = drawY - 4;
                    jumptimer++;
                }

                else if (jumptimer == 14)
                {
                    jumptimer++;
                }

                else if (jumptimer == 15)
                {
                    drawY = drawY - 4;
                    jumptimer++;
                }

                else if (jumptimer == 16)
                {
                    jumptimer++;
                }

                else if (jumptimer == 17)
                {
                    drawY = drawY + 4;
                    jumptimer++;
                }

                else if (jumptimer == 18)
                {
                    jumptimer++;
                }

                else if (jumptimer == 19)
                {
                    drawY = drawY + 4;
                    jumptimer++;
                }

                else if (jumptimer == 20)
                {
                    jumptimer++;
                }

                else if (jumptimer == 21)
                {
                    drawY = drawY + 12;
                    jumptimer++;
                }

                else if (jumptimer == 22)
                {
                    jumptimer++;
                }

                else if (jumptimer == 23)
                {
                    drawY = drawY + 12;
                    jumptimer++;
                }

                else if (jumptimer == 24)
                {
                    jumptimer++;
                }

                else if (jumptimer == 25)
                {
                    drawY = drawY + 20;
                    jumptimer++;
                }

                else if (jumptimer == 26)
                {
                    jumptimer++;
                }

                else if (jumptimer == 27)
                {
                    drawY = drawY + 20;
                    jumptimer++;
                }

                else if (jumptimer == 28)
                {
                    jumptimer++;
                }

                else if (jumptimer == 29)
                {
                    drawY = drawY + 28;
                    jumptimer++;
                }

                else if (jumptimer == 30)
                {
                    jumptimer++;
                }

                else
                {
                    drawY = drawY + 28;
                    jumptimer = 1;
                    jump = false;
                }
            }

            if (characterCounter == 5)
            {
                if (frame == 1)
                {
                    frame = 2;
                }

                else
                {
                    frame = 1;
                }
                characterCounter = 0;
            }

            //generating 
            if (generateCounter == 0)
            {
                if (emymove == 5 || emymove == 6)
                {
                    emyX.Add(675);
                    emyY.Add(286);
                    enemyImage.Add(randGen.Next(1, 4));
                    generateCounter = randGen.Next(100, 130);
                }

                else if (emymove == 7 || emymove == 8)
                {
                    emyX.Add(675);
                    emyY.Add(286);
                    enemyImage.Add(randGen.Next(1, 4));
                    generateCounter = randGen.Next(90, 120);
                }

                else if (emymove == 9 || emymove == 10)
                {
                    emyX.Add(675);
                    emyY.Add(286);
                    enemyImage.Add(randGen.Next(1, 4));
                    generateCounter = randGen.Next(80, 110);
                }

                else if (emymove == 11 || emymove == 12)
                {
                    emyX.Add(675);
                    emyY.Add(286);
                    enemyImage.Add(randGen.Next(1, 4));
                    generateCounter = randGen.Next(70, 100);
                }

                else if (emymove == 13 || emymove == 14)
                {
                    emyX.Add(675);
                    emyY.Add(286);
                    enemyImage.Add(randGen.Next(1, 4));
                    generateCounter = randGen.Next(60, 90);
                }

                else if (emymove == 15 || emymove == 16)
                {
                    emyX.Add(675);
                    emyY.Add(286);
                    enemyImage.Add(randGen.Next(1, 4));
                    generateCounter = randGen.Next(50, 80);
                }

                else if (emymove == 17 || emymove == 18)
                {
                    emyX.Add(675);
                    emyY.Add(286);
                    enemyImage.Add(randGen.Next(1, 4));
                    generateCounter = randGen.Next(40, 70);
                }

                else
                {
                    emyX.Add(675);
                    emyY.Add(286);
                    enemyImage.Add(randGen.Next(1, 4));
                    generateCounter = randGen.Next(30, 60);
                }
            }

            //Moving
            for (int i = 0; i < emyX.Count; i++)
            {
                emyX[i] = emyX[i] - emymove;
            }

            //Removing 
            if (emyX.Count > 0)
            {
                if (emyX[0] < -20)
                {
                    emyX.RemoveAt(0);
                    emyY.RemoveAt(0);
                    enemyImage.RemoveAt(0);
                }
            }

            Rectangle heroRec = new Rectangle(drawX, drawY, heroWidth, heroHeight);

            for (int i = 0; i < enemyImage.Count; i++)
            {
                Rectangle emyRec = new Rectangle();
                if (enemyImage[i] == 1)
                {
                    emyRec = new Rectangle(emyX[i], emyY[i], 30, monsterHeight);
                }

                else if (enemyImage[i] == 2)
                {
                    emyRec = new Rectangle(emyX[i], emyY[i], 50, monsterHeight);
                }

                else if (enemyImage[i] == 3)
                {
                    emyRec = new Rectangle(emyX[i], emyY[i], 75, monsterHeight);
                }

                if (emyRec.IntersectsWith(heroRec))
                {
                    frame = 3;
                    gameTimer.Enabled = false;
                    upArrowDown = spaceDown = false;
                    dead = true;
                }
            }

            if (speedcounter == 150)
            {
                emymove = emymove + 1;
                speedcounter = 0;
            }

            outputLabel.Text = score + " ";

            Refresh();
        }

        /// <summary>
        /// Everything that is to be drawn on the screen should be done here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //chaaracter 
            if (frame == 1)
            {
                e.Graphics.DrawImage(Properties.Resources.Run_1_dino_Edit, drawX, drawY, heroWidth, heroHeight);
            }

            else if (frame == 2)
            {
                e.Graphics.DrawImage(Properties.Resources.Run_2_dino_Edit, drawX, drawY, heroWidth, heroHeight);
            }

            else if (frame == 3)
            {
                e.Graphics.DrawImage(Properties.Resources.Dead_Dino, drawX, drawY, heroWidth, heroHeight);
            }

            //enemy 
            for (int i = 0; i < enemyImage.Count; i++)
            {
                if (enemyImage[i] == 1)
                {
                    e.Graphics.DrawImage(Properties.Resources.One, emyX[i], emyY[i], 30, monsterHeight);
                }

                else if (enemyImage[i] == 2)
                {
                    e.Graphics.DrawImage(Properties.Resources.Two, emyX[i], emyY[i], 50, monsterHeight);
                }

                else if (enemyImage[i] == 3)
                {
                    e.Graphics.DrawImage(Properties.Resources.Three, emyX[i], emyY[i], 75, monsterHeight);
                }
            }

            if (dead == true)
            {
                Form1.service.endGame(score);
                Form1.changeScreen(this, "GameOverScreen");
            } 
        }
    }
    
}

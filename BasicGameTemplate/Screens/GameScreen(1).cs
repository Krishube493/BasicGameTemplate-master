using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGameTemplate
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        //player2 button control keys - DO NOT CHANGE
        Boolean aDown, sDown, dDown, wDown, cDown, vDown, xDown, zDown;

        //initial starting points for black rectangle
        int drawX = 100;
        int drawY = 430;

        //Graphics objects
        SolidBrush heroBrush = new SolidBrush(Color.Black);

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // opens a pause screen is escape is pressed. Depending on what is pressed
            // on pause screen the program will either continue or exit to main menu
            if (e.KeyCode == Keys.Escape && gameTimer.Enabled)
            {
                gameTimer.Enabled = false;
                rightArrowDown = leftArrowDown = upArrowDown = downArrowDown = false;

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
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
            }
        }

        /// <summary>
        /// This is the Game Engine and repeats on each interval of the timer. For example
        /// if the interval is set to 16 then it will run each 16ms or approx. 50 times
        /// per second
        /// </summary>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //main character movements
            if (leftArrowDown == true)
            {
                drawX--;
            }
            if (downArrowDown == true)
            {
                drawY++;
            }
            if (rightArrowDown == true)
            {
                drawX++;
            }
            if (upArrowDown == true)
            {
                drawY--;
            }

            //npc character movements

            //collisions checks and other processing

            //calls the GameScreen_Paint method to draw the screen.
            Refresh();
        }

        /// <summary>
        /// Everything that is to be drawn on the screen should be done here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw rectangle to screen
            e.Graphics.FillRectangle(heroBrush, drawX, drawY, 20, 20);
        }
    }
}

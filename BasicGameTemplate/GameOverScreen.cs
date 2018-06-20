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
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            //restart game - go to GameScreen
            Form1.changeScreen(this, "GameScreen");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // go to MenuScreen
            Form1.changeScreen(this, "MenuScreen");
        }
    }
}

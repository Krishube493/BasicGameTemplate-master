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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.changeScreen(this, "GameScreen");
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            Form1.changeScreen(this, "ScoreScreen");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Enter(object sender, EventArgs e)
        {
            //start by changing all the buttons to the default colour
            foreach(Control c in this.Controls)
            {
                if (c is Button)
                c.BackColor = Color.White;
            }

            //change the current button to the active colour
            Button btn = (Button)sender;
            btn.BackColor = Color.Green;
        }


    }
}

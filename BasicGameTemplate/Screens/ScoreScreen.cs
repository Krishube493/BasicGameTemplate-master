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
    public partial class ScoreScreen : UserControl
    {
        private int index = 0;

        IList<GameSystemServices.Highscore> highscoreList = new List<GameSystemServices.Highscore>();

        public ScoreScreen()
        {
            InitializeComponent();
        }

        private void scoreScreen_Load(object sender, EventArgs e)
        {
            loadHighscoreAtIndex();
        }

        private void loadHighscoreAtIndex()
        {
            if (index < 0) index = 0;

            highscoreList = Form1.service.getHighscores(skip: index * 10, limit: 10);

            if (highscoreList.Count == 0)
            {
                index--;
                highscoreList = Form1.service.getHighscores(skip: index * 10, limit: 10);
            }

            updateHighscoreLabels();
        }

        private void updateHighscoreLabels()
        {
            outputLabel.Text = "";
            foreach (GameSystemServices.Highscore highscore in highscoreList)
            {
                outputLabel.Text += highscore.Rank + ". " + highscore.Name + "  " + highscore.Score + "\n";
            }
        }

        private void ScoreScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                index++;
                loadHighscoreAtIndex();
            }

            if (e.KeyCode == Keys.Left)
            {
                index--;
                loadHighscoreAtIndex();
            }
            
            //when the escape key is pressed the game ends and goes back to the main menu
            if (e.KeyCode == Keys.Escape)
            {
                Form1.changeScreen(this, "MenuScreen");
            }
        }
    }
}

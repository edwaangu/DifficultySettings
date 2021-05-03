using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    public partial class Form1 : Form
    {
        string heroName = "";
        string difficultyLevel = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.LimeGreen;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;

            difficultyLevel = "easy";

            heroName = nameBox.Text;

        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.DarkOrange;
            hardButton.BackColor = Color.Black;

            difficultyLevel = "medium";

            heroName = nameBox.Text;

        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Tomato;

            difficultyLevel = "hard";

        }

        private void beginButton_Click(object sender, EventArgs e)
        {

            heroName = nameBox.Text;

            switch (difficultyLevel)
            {
                case "hard":
                    dialogueText.Text = $"Welcome {heroName}!\nOh dear, the {difficultyLevel} path. Good luck conquering that.";
                    break;
                case "medium":
                    dialogueText.Text = $"Welcome {heroName}!\nA challenge eh? Sounds like the {difficultyLevel} path is right for you to conquer.";
                    break;
                case "easy":
                    dialogueText.Text = $"Welcome {heroName}!\nWanting some casual fun? Head off conquering the {difficultyLevel} path.";
                    break;
                case "":
                    dialogueText.Text = $"Select a difficulty, {heroName}";
                    break;
            }

            if (heroName == "")
            {
                dialogueText.Text = "Enter a name first lad!";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Asteroid_Belt_2019
{
    public partial class frmHighscores : Form
    {
        string binPath = Application.StartupPath + @"\highScores.txt";
        List<Highscores> highScores = new List<Highscores>();

        private void frmHighscores_Load(object sender, EventArgs e)
        {
            int lowest_score = highScores[(highScores.Count - 1)].Lives;
            if (int.Parse(lblPlayerLives.Text) > lowest_score)
            {
                lblMessage.Text = "You have made the Top Ten! Well Done!";
                highScores.Add(new Highscores(lblPlayerName.Text, int.Parse(lblPlayerLives.Text)));
            }
            else
            {
                lblMessage.Text = "Keep trying to make the top ten!";
            }

            SortHighScores();
            DisplayHighScores();
        }

        public frmHighscores(string playerName, string playerLives)
        {
            InitializeComponent();
            // get name and score from frmGame and show in lblPlayerName and lblPlayerScore         
            lblPlayerName.Text = playerName;
            lblPlayerLives.Text = playerLives;
            var reader = new StreamReader(binPath);
            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the name and the score.
                var values = line.Split(',');
                highScores.Add(new Highscores(values[0], Int32.Parse(values[1])));
            }
            reader.Close();
        }

        public void DisplayHighScores()
        {
            foreach (Highscores s in highScores)
            {
                listBoxName.Items.Add(s.Name);
                listBoxLives.Items.Add(s.Lives);

            }
        }

        public void SortHighScores()
        {
            highScores = highScores.OrderByDescending(hs => hs.Lives).Take(10).ToList();
        }

        public void SaveHighScores()
        {
            StringBuilder builder = new StringBuilder();
            foreach (Highscores score in highScores)
            {
                //{0} is for the Name, {1} is for the Score and {2} is for a new line
                builder.Append(string.Format("{0},{1}{2}", score.Name, score.Lives, Environment.NewLine));
            }
            File.WriteAllText(binPath, builder.ToString());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SaveHighScores();
            Form1 Form2 = new Form1();
            Hide();
            Form2.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Asteroid_Belt_2019
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
        // declare space for an array of 7 objects called planet 
        Asteroid[] asteroid = new Asteroid[7];
        Random xspeed = new Random();
        Spaceship spaceship = new Spaceship();
        bool left, right, up, down;
        string move;
        int score, lives;
        string playerName; //create a string value called playerName


        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {
                int y = 10 + (i * 70);
                asteroid[i] = new Asteroid(y);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Use W, A, S and D to move the spaceship. \n Don't get hit by the asteroids! \n Every asteroid that you avoid scores one point. \n If your spaceship hits an asteroid, you will lose a life! \n \n Enter your name to begin the game and press start to begin.", "Game Instructions");
            txtName.Focus();
            tmrAsteroid.Enabled = false;
            tmrShip.Enabled = false;
            mnuStop.Enabled = false;
            mnuStart.Enabled = false;
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;

            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = xspeed.Next(5, 20);
                asteroid[i].x -= rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                asteroid[i].drawAsteroid(g);
            }

            spaceship.drawSpaceship(g);
        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            tmrShip.Enabled = false;
            tmrAsteroid.Enabled = false;
            mnuStop.Enabled = false;
            mnuStart.Enabled = true;
        }

        private void mnuStart_Click(object sender, EventArgs e)
        {
            score = 0;
            lblScore.Text = score.ToString();
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
            tmrAsteroid.Enabled = true;
            tmrShip.Enabled = true;
            mnuStart.Enabled = false;
            mnuStop.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { left = true; }
            if (e.KeyData == Keys.D) { right = true; }
            if (e.KeyData == Keys.W) { up = true; }
            if (e.KeyData == Keys.S) { down = true; }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            playerName = txtName.Text;

            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                //if playerName valid (only letters) 
                mnuStart.Enabled = true;
                txtName.Enabled = false;//disables textbox to enter new name
                btnEnter.Enabled = false;
            }
            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("Please enter a name using letters only!");
                txtName.Clear();
                txtName.Focus();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { left = false; }
            if (e.KeyData == Keys.D) { right = false; }
            if (e.KeyData == Keys.W) { up = false; }
            if (e.KeyData == Keys.S) { down = false; }
        }

        private void tmrShip_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                spaceship.moveSpaceship(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                spaceship.moveSpaceship(move);
            }
            if (up) // if left arrow key pressed
            {
                move = "up";
                spaceship.moveSpaceship(move);
            }
            if (down) // if left arrow key pressed
            {
                move = "down";
                spaceship.moveSpaceship(move);
            }
        }

        private void tmrAsteroid_Tick(object sender, EventArgs e)
        {
            score = 0;
            for (int i = 0; i < 7; i++)
            {
                asteroid[i].moveAsteroid();
                if (spaceship.spaceRec.IntersectsWith(asteroid[i].asteroidRec))
                {
                    //reset planet[i] back to top of panel
                    asteroid[i].x = 530; // set  y value of planetRec
                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    checkLives();
                }
                score += asteroid[i].score;// get score from Asteroid class (in moveAsteroid method)
                lblScore.Text = score.ToString();// display score

            }

            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void checkLives()
        {
            if (lives == 0)
            {
                tmrAsteroid.Enabled = false;
                tmrShip.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }

    }
}

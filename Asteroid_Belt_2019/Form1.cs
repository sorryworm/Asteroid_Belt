using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid_Belt_2019
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
        // declare space for an array of 7 objects called planet 
        Asteroid[] asteroid = new Asteroid[7];
        Random yspeed = new Random();
        Spaceship spaceship = new Spaceship();
        bool left, right;
        string move;
        int score, lives;


        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 75);
                asteroid[i] = new Asteroid(x);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;

            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 20);
                asteroid[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                asteroid[i].drawAsteroid(g);
            }

            spaceship.drawSpaceship(g);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
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
                    asteroid[i].y = 30; // set  y value of planetRec
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

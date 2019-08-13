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
using System.Reflection;

namespace Asteroid_Belt_2019
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
        Asteroid[] asteroid = new Asteroid[7]; //declare array for 7 objects called asteroid
        Random xspeed = new Random(); //random speed variable
        Spaceship spaceship = new Spaceship(); //variable for spaceship object
        bool left, right, up, down; //movement variables
        string move;
        int score, lives; //score and lives variable
        string playerName; //create a string value called playerName
        List<Plasma> plasma = new List<Plasma>(); //create a new list called plasma
        int plasmaNumber = 2; //create an integer value called plasmaNumber
        int plasmaTime = 10; //create an integer value called plasmaTime


        public Form1()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
            //stops the panel from flickering

            for (int i = 0; i < 7; i++) //code to spawn the asteroids
            {
                int y = 10 + (i * 70);
                asteroid[i] = new Asteroid(y);
            }

        }

        private void Form1_Load(object sender, EventArgs e) //code for when the form first loads
        {
            MessageBox.Show(" Use the W, A, S, D to move the spaceship. \n Use the left mouse button to fire a projectile (Press it again to reload). \n Don't get hit by the asteroids! \n Every asteroid that gets past score a point. \n If an asteroid hits the spaceship a life is lost! \n Escape the asteroid belt to view your highscore! \n \n Enter your name to unlock the start button \n Press Start to begin \n Try to escape the asteroid belt!", "Game Instructions");
            txtName.Focus();
            tmrAsteroid.Enabled = false;
            tmrShip.Enabled = false;
            mnuStop.Enabled = false;
            mnuStart.Enabled = false;
            btnCheck.Enabled = false;
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

            foreach (Plasma m in plasma)
            {
                m.draw(g);
            }
        }

        private void mnuStop_Click(object sender, EventArgs e) //if stop menu is pressed
        {
            tmrShip.Enabled = false;
            tmrAsteroid.Enabled = false;
            mnuStop.Enabled = false;
            mnuStart.Enabled = true;
        }

        private void mnuStart_Click(object sender, EventArgs e) //if start menu is pressed
        {
            score = 0;
            lblScore.Text = score.ToString();
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
            tmrAsteroid.Enabled = true;
            tmrShip.Enabled = true;
            mnuStart.Enabled = false;
            mnuStop.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //if a key is pressed
        {
            if (e.KeyData == Keys.A) { left = true; }
            if (e.KeyData == Keys.D) { right = true; }
            if (e.KeyData == Keys.W) { up = true; }
            if (e.KeyData == Keys.S) { down = true; }
        }

        private void btnEnter_Click(object sender, EventArgs e) //if enter button is pressed
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

        private void pnlGame_MouseDown(object sender, MouseEventArgs e)
        {
            plasmaNumber--; //if left mouse button is pressed add a missile to the form
            if ((e.Button == MouseButtons.Left) && plasmaNumber > 0)
            {
                plasma.Add(new Plasma(spaceship.spaceRec));
                lblReload.Text = "Reload";
            }
            if (plasmaNumber == 0) //if plasma number = 0 start reload timer
            {
                tmrPlasmaRegeneration.Start();
            }
        }

        private void tmrAsteroid_Tick(object sender, EventArgs e)
        {
            score = 0;
            for (int i = 0; i < 7; i++)
            {
                checkScoreLvl1();
                checkScoreLvl2();
                checkScoreLvl3();
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

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            foreach (Asteroid i in asteroid)
            {
                foreach (Plasma m in plasma)
                {
                    if (i.asteroidRec.IntersectsWith(m.plasmaRec)) //if an asteroid intersects with plasma, remove the plasma and relocate the asteroid back to the top of the form
                    {
                        plasma.Remove(m);
                        i.x = 530;
                        break;
                    }
                }
            }
        }

        private void tmrPlasmaRegenration_Tick(object sender, EventArgs e) 
        {
            plasmaTime--;
            lblReload.Text = plasmaTime.ToString(); //convert plasma reload time to string
            if (plasmaTime == 0) //if plasma time = 0 then stop the reload timer and set plasma number to 2, plasma time to 7 and display ready on the reload text
            {
                tmrPlasmaRegeneration.Stop();
                plasmaNumber = 2;
                plasmaTime = 10;
                lblReload.Text = "Ready";
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmHighscores frmHighscore2 = new frmHighscores(txtName.Text, txtLives.Text); //create a new form instance called frmHighscore2
            Hide();
            frmHighscore2.ShowDialog();
        }

        private void checkLives()
        {
            if (lives == 0) //if lives = 0, disable timers and display game over message
            {
                tmrAsteroid.Enabled = false;
                tmrShip.Enabled = false;
                mnuStart.Enabled = false;
                mnuStop.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }

        private void checkScoreLvl1()
        {
            if (score >= 15) //if score is equal to or over 20 then increase asteroid speed and display level 2
            {
                tmrAsteroid.Interval = 50;
                lblLevel.Text = "Level 2";
            }
        }
        private void checkScoreLvl2()
        {
            if (score >= 40) //is score is equal to or over 40 then increase asteroid speed and display level 3
            {
                tmrAsteroid.Interval = 35;
                lblLevel.Text = "Level 3";
            }
        }
        private void checkScoreLvl3()
        {
            if (score >= 80) //if score is equal to or over 80 disable timers to stop the game and display a message saying you won
            {
                tmrAsteroid.Enabled = false;
                tmrShip.Enabled = false;
                tmrShoot.Enabled = false;
                mnuStart.Enabled = false;
                mnuStop.Enabled = false;
                btnCheck.Enabled = true;
                MessageBox.Show("You have successfully escaped the astroid belt", "You Win!");
                lblLevel.Text = "Well Done!";
            }
        }

    }
}

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


        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 75);
                asteroid[i] = new Asteroid(x);
            }

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


        }

        private void tmrAsteroid_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                asteroid[i].moveAsteroid();
            }

         pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Asteroid_Belt_2019
{
    class Asteroid
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image asteroidImage;//variable for the planet's image
        public Rectangle asteroidRec;//variable for a rectangle to place our image in
        public int score;

        //Create a constructor (initialises the values of the fields)
        public Asteroid(int spacing)
        {
            x = 530;
            y = spacing;
            width = 30;
            height = 30;
            asteroidImage = Image.FromFile("Asteroid.png");
            asteroidRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Asteroid class
        public void drawAsteroid(Graphics g)
        {
            asteroidRec = new Rectangle(x, y, width, height);
            g.DrawImage(asteroidImage, asteroidRec);
        }

        public void moveAsteroid()
        {
            asteroidRec.Location = new Point(x, y);

            if (asteroidRec.Location.X < -20)
            {
                x = 530;
                score += 1;// add 1 to score when planet reaches bottom of panel
                asteroidRec.Location = new Point(x, y);
            }

        }

    }
}

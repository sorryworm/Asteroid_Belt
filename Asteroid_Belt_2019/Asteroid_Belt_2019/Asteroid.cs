using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Asteroid_Belt_2019
{
    class Asteroid
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        Image[] images = new Image[5];//variable for the asteroid's image
        public Rectangle asteroidRec;//variable for a rectangle to place our image in
        public int score;
        Animation animate;//create an object called animate

        //Create a constructor (initialises the values of the fields)
        public Asteroid(int spacing)
        {
            x = 530;
            y = spacing;
            width = 30;
            height = 30;
            asteroidRec = new Rectangle(x, y, width, height);
            for (int i = 1; i <= 4; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\asteroid" + i.ToString() + ".gif");
            }
            animate = new Animation(images);
        }

        // Methods for the Asteroid class
        public void drawAsteroid(Graphics g)
        {
            asteroidRec = new Rectangle(x, y, width, height);
            //instead of just drawing the planet we use the GetNextImage() method to animate the planet
            g.DrawImage(animate.GetNextImage(), asteroidRec);
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

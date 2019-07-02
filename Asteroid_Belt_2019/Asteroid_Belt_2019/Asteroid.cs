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
        public Image planetImage;//variable for the planet's image

        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Asteroid()
        {
            x = 10;
            y = 10;
            width = 20;
            height = 20;
            planetImage = Image.FromFile("Asteroid.png");
            planetRec = new Rectangle(x, y, width, height);
        }

    }
}

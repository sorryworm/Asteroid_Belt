using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Asteroid_Belt_2019
{
    class Spaceship
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image spaceship;//variable for the planet's image
        public Rectangle spaceRec;//variable for a rectangle to place our image in

        //constructor to make values for spaceship
        public Spaceship()
        {
            x = 10;
            y = 360;
            width = 40;
            height = 40;
            spaceship = Image.FromFile("Spaceship.png");
            spaceRec = new Rectangle(x, y, width, height);
        }

        //draw the spaceship image
        public void drawSpaceship(Graphics g)
        {
            spaceRec = new Rectangle(x, y, width, height);
            g.DrawImage(spaceship, spaceRec);
        }


        //move the spaceship
        public void moveSpaceship(string move)
        {
            spaceRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (spaceRec.Location.X > 450) //if spaceship goes past right side of game panel move it back left
                {

                    x = 450;
                    spaceRec.Location = new Point(x, y);
                }
                else //else keep on moving right
                {
                    x += 5;
                    spaceRec.Location = new Point(x, y);
                }

            }

            if (move == "left")
            {
                if (spaceRec.Location.X < 10) //if spaceship goes past left side of game panel move it back right
                {

                    x = 10;
                    spaceRec.Location = new Point(x, y);
                }
                else //else keep moving left
                {
                    x -= 5;
                    spaceRec.Location = new Point(x, y);
                }

            }

            if (move == "up")
            {
                if (spaceRec.Location.Y < 10) //if spaceship goes past top side of game panel move it back down
                {

                    y = 10;
                    spaceRec.Location = new Point(x, y);
                }
                else //else keep moving up
                {
                    y -= 5;
                    spaceRec.Location = new Point(x, y);
                }

            }
            if (move == "down")
            {
                if (spaceRec.Location.Y > 355) //if spaceship goes past bottom side of game panel move it back up
                {

                    y = 355;
                    spaceRec.Location = new Point(x, y);
                }
                else //else keep moving down
                {
                    y += 5;
                    spaceRec.Location = new Point(x, y);
                }
            }
        }
    }
}

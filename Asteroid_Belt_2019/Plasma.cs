using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Asteroid_Belt_2019
{
    class Plasma
    {
        public int x, y, width, height;//variables for dimensions

        public Image plasma;//variable for the missile's image

        public Rectangle plasmaRec;//variable for a rectangle to place our image in

        // in the following constructor we pass in the values of spaceRec which
        // gives us the position of the spaceship which we can then use to place the
        // missile where the spaceship is located
        public Plasma(Rectangle spaceRec)
        {
            x = spaceRec.X; // move missile to middle of spaceship
            y = spaceRec.Y + 13;
            width = 20;
            height = 20;
            plasma = Image.FromFile("plasma.png");
            plasmaRec = new Rectangle(x, y, width, height);
        }

        //draw the missile
        public void draw(Graphics g)
        {
            x += 30;//speed of missile
            plasmaRec = new Rectangle(x, y, width, height);
            g.DrawImage(plasma, plasmaRec);

        }
    }
}

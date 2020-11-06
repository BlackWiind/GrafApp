using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrafApp
{
    class Ellipse : Circle
    {
        public Ellipse()
        {
            x = rnd.Next(maxX);
            y = rnd.Next(maxY);
            width = rnd.Next(maxX / 3);
            hieght = rnd.Next(maxX / 3);
            pn = new Pen(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
        }
    }
}

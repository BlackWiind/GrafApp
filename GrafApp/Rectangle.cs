using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrafApp
{
    class Rectangle : tPoint
    {
        public Rectangle()
        {
            x = rnd.Next(maxX);
            y = rnd.Next(maxY);
            width = rnd.Next(maxX/3);
            hieght = rnd.Next(maxY/3);
            pn = new Pen(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
        }
    }
}

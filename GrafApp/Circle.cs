using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrafApp
{
    class Circle : tPoint
    {
        public Circle()
        {
            x = rnd.Next(maxX);
            y = rnd.Next(maxY);
            width = rnd.Next(maxX/3);
            hieght = width;
            pn = new Pen(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
        }

        public override void SomeDraw(Graphics g)
        {
            g.DrawEllipse(pn, x, y, width, hieght);
        }
    }
}

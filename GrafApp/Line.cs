using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrafApp
{
    class Line : tPoint
    {
        protected int x1, y1;

        public Line()
        {
            x = rnd.Next(maxX);
            y = rnd.Next(maxY);
            x1 = rnd.Next(maxX);
            y1 = rnd.Next(maxY);
            pn = new Pen(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
        }

        public override void SomeDraw(Graphics g)
        {
            g.DrawLine(pn, x, y, x1, y1);
        }

        public override void KeyRight()
        {
            x += 30;
            x1 += 30;
            if (x > maxX)
            { x = 0 + (x - maxX); }
            if (x1 > maxX)
            { x1 = 0 + (x1 - maxX); }
        }

        public override void KeyLeft()
        {
            x -= 30;
            x1 -= 30;
            if (x < 0)
            { x = maxX + x; }
            if (x1 < 0)
            { x1 = maxX + x1; }
        }

        public override void KeyDown()
        {
            y += 30;
            y1 += 30;
            if (y > maxY)
            { y = 0 + (y - maxY); }
            if (y1 > maxY)
            { y1 = 0 + (y1 - maxY); }
        }

        public override void KeyUp()
        {
            y -= 30;
            y1 -= 30;
            if (y < 0)
            { y = maxY + y; }
            if (y1 < 0)
            { y1 = maxY + y1; }
        }

        public override void Random()
        {
            int tmpX = rnd.Next(maxX) - x;
            int tmpY = rnd.Next(maxY) - y;
            x += tmpX;
            y += tmpY;
            x1 += tmpX;
            y1 += tmpY;
        }
    }
}

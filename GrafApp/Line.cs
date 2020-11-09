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

        public static void KeyRight(Line var)
        {
            var.x += 30;
            if (var.x > maxX)
            { var.x = 0 + (var.x - maxX); }
        }

        public static void KeyLeft(Line var)
        {
            var.x -= 30;
            if (var.x < 0)
            { var.x = maxX + var.x; }
        }

        public static void KeyDown(Line var)
        {
            var.y += 30;
            if (var.y > maxY)
            { var.y = 0 + (var.y - maxY); }
        }

        public static void KeyUp(Line var)
        {
            var.y -= 30;
            if (var.y < 0)
            { var.y = maxY + var.y; }
        }
    }
}

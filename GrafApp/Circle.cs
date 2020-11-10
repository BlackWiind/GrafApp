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

        public static void KeyRight(Circle var)
        {
            var.x += 30;
            if (var.x > maxX)
            { var.x = 0 + (var.x - maxX); }
        }

        public static void KeyLeft(Circle var)
        {
            var.x -= 30;
            if (var.x < 0)
            { var.x = maxX + var.x; }
        }

        public static void KeyDown(Circle var)
        {
            var.y += 30;
            if (var.y > maxY)
            { var.y = 0 + (var.y - maxY); }
        }

        public static void KeyUp(Circle var)
        {
            var.y -= 30;
            if (var.y < 0)
            { var.y = maxY + var.y; }
        }

        public static void Random(Circle var)
        {
            var.x = rnd.Next(maxX);
            var.y = rnd.Next(maxY);
        }
    }
}

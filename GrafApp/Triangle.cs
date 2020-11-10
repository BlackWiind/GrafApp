using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrafApp
{
    class Triangle : tPoint
    {
        Point[] points = new Point[3];

        public Triangle()
        {

            for(int i = 0; i < points.Length; i++) {
                x = rnd.Next(maxX);
                y = rnd.Next(maxY);
                points[i] = new Point(x, y); 
            }
        }

        public override void SomeDraw(Graphics g)
        {
            g.DrawPolygon(pn, points);
        }

        public static void KeyRight(Triangle var)
        {
            for (int i = 0; i < 3; i++)
            {
                var.points[i].Offset(30, 0);
            }      
        }

        public static void KeyLeft(Triangle var)
        {
            for (int i = 0; i < 3; i++)
            {
                var.x -= 30;
                if (var.x < 0)
                { var.x = maxX + var.x; }
            }          
        }

        public static void KeyDown(Triangle var)
        {
            {
                var.y += 30;
                if (var.y > maxY)
                { var.y = 0 + (var.y - maxY); }
            }
        }

        public static void KeyUp(Triangle var)
        {
            {
                var.y -= 30;
                if (var.y < 0)
                { var.y = maxY + var.y; }
            }
        }
    }
}


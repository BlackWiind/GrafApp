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
                points[i] = new Point(rnd.Next(maxX), rnd.Next(maxY)); 
            }
        }

        public override void SomeDraw(Graphics g)
        {
            g.DrawPolygon(pn, points);
        }

        public static void KeyRight(Triangle var)
        {
            {
                int tmp = 30;
                for (int i = 0; i < 3; i++)
                {
                    if (var.points[i].X + tmp > maxX)
                    { tmp = 30 - (var.points[i].X + tmp - maxX); }
                }
                for (int i = 0; i < 3; i++)
                {
                    var.points[i].X += tmp;
                }
            }
        }

        public static void KeyLeft(Triangle var)
        {
            {
                int tmp = 30;
                for (int i = 0; i < 3; i++)
                {
                    if (var.points[i].X - tmp < 0)
                    { tmp = 30 + (var.points[i].X - tmp); }
                }
                for (int i = 0; i < 3; i++)
                {
                    var.points[i].X -= tmp;
                }
            }
        }

        public static void KeyDown(Triangle var)
        {
            {
                int tmp = 30;
                for (int i = 0; i < 3; i++)
                {
                    if (var.points[i].Y + tmp > maxY)
                    { tmp = 30 - (var.points[i].Y + tmp - maxY); }
                }
                for (int i = 0; i < 3; i++)
                {                    
                    var.points[i].Y += tmp;
                }
            }
        }

        public static void KeyUp(Triangle var)
        {
            {
                int tmp = 30;
                for (int i = 0; i < 3; i++)
                {
                    if (var.points[i].Y - tmp < 0)
                    { tmp = 30 + (var.points[i].Y - tmp); }
                }
                for (int i = 0; i < 3; i++)
                {
                    var.points[i].Y -= tmp;
                }
            }
        }
        
        public static void Random(Triangle var)
        {
            int tmpX = rnd.Next(maxX) - var.points[1].X;
            int tmpY = rnd.Next(maxY) - var.points[1].Y;
            for (int i = 0; i < 3; i++)
            {
                var.points[i].X += tmpX;
                var.points[i].Y += tmpY;
            }
        }
    }
}


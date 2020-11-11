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
                var.points[i].X += 30;
               if (var.points[i].X > maxX)
                { var.points[i].X = 0 + (var.points[i].X - maxX); }
            }      
        }

        public static void KeyLeft(Triangle var)
        {
            for (int i = 0; i < 3; i++)
            {
                var.points[i].X -= 30;
                if (var.points[i].X < 0)
                { var.points[i].X = maxX + var.points[i].X; }
            }          
        }

        public static void KeyDown(Triangle var)
        {
            {
                for (int i = 0; i < 3; i++)
                {
                    var.points[i].Y += 30;
                    if (var.points[i].Y > maxY)
                    { var.points[i].Y = 0 + (var.points[i].Y - maxY); }
                }
            }
        }

        public static void KeyUp(Triangle var)
        {
            {
                for (int i = 0; i < 3; i++)
                {
                    var.points[i].Y -= 30;
                    if (var.points[i].Y < 0)
                    { var.points[i].Y = maxY + var.points[i].Y; }
                }
            }
        }
    }
}


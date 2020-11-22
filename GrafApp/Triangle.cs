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

        public override void KeyRight()
        {
            {
                int tmp = 30;
                for (int i = 0; i < 3; i++)
                {
                    if (points[i].X + tmp > maxX)
                    { tmp = tmp - (points[i].X + tmp - maxX); }
                }
                for (int i = 0; i < 3; i++)
                {
                    points[i].X += tmp;
                }
            }
        }

        public override void KeyLeft()
        {
            {
                int tmp = 30;
                for (int i = 0; i < 3; i++)
                {
                    if (points[i].X - tmp < 0)
                    { tmp = tmp + (points[i].X - tmp); }
                }
                for (int i = 0; i < 3; i++)
                {
                    points[i].X -= tmp;
                }
            }
        }

        public override void KeyDown()
        {
            {
                int tmp = 30;
                for (int i = 0; i < 3; i++)
                {
                    if (points[i].Y + tmp > maxY)
                    { tmp = tmp - (points[i].Y + tmp - maxY); }
                }
                for (int i = 0; i < 3; i++)
                {                    
                    points[i].Y += tmp;
                }
            }
        }

        public override void KeyUp()
        {
            {
                int tmp = 30;
                for (int i = 0; i < 3; i++)
                {
                    if (points[i].Y - tmp < 0)
                    { tmp = tmp + (points[i].Y - tmp); }
                }
                for (int i = 0; i < 3; i++)
                {
                    points[i].Y -= tmp;
                }
            }
        }
        
        public override void Random()
        {
            int tmpX = rnd.Next(maxX) - points[1].X;
            int tmpY = rnd.Next(maxY) - points[1].Y;
            for (int i = 0; i < 3; i++)
            {
                points[i].X += tmpX;
                points[i].Y += tmpY;
            }
        }
    }
}


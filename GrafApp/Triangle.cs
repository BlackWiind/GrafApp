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
    }
}

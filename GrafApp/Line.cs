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
        private int x1,y1;

        public Line()
        {
            x = rnd.Next(maxX);
            y = rnd.Next(maxY);
            pn = new Pen(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
        }
    }
}

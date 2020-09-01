using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrafApp
{
    class tPoint
    {
        private int x , y;
        private static int maxX = 466, maxY = 376;
        static Random rnd = new Random();
        Pen pn;
        public tPoint()
        {
            x = rnd.Next(maxX);
            y = rnd.Next(maxY);
            pn = new Pen(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
        }
        public tPoint(int x,int y,int pen)
        {
            this.x = x;
            this.y = y;
            this.pn = new Pen(Color.FromArgb(pen, pen, pen));
        }
        
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public Pen Pn
        {
            get { return pn; }
        }

        public void KeyRight()
        {
            x += 30;
            if (x > maxX)
            { x = 0 + (x - maxX); }
        }

        public void KeyLeft()
        {
            x -= 30;
            if (x < 0)
            { x = maxX + x; }
        }

        public void KeyDown()
        {
            y += 30;
            if (y > maxY)
            { y = 0 + (y - maxY); }
        }

        public void KeyUp()
        {
            y -= 30;
            if (y < 0)
            { y = maxY + y; }
        }
    }
}

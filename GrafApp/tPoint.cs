using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GrafApp
{
    class tPoint
    {
        protected int x , y, width, hieght;
        protected static int maxX = 774, maxY = 493;
        protected static Random rnd = new Random();
        protected Pen pn;
        public tPoint()
        {
            x = rnd.Next(maxX);
            y = rnd.Next(maxY);
            width = 1;
            hieght = 1;
            pn = new Pen(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
        }
        public tPoint(int x,int y,int pen)
        {
            this.x = x;
            this.y = y;
            this.pn = new Pen(Color.FromArgb(pen, pen, pen));
        }

        public virtual void SomeDraw(Graphics g)
        {
            g.DrawRectangle(Pn, x, y, width, hieght);
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

        public static void KeyRight(tPoint var)
        {
            var.x += 30;
            if (var.x > maxX)
            { var.x = 0 + (var.x - maxX); }
        }

        public static void KeyLeft(tPoint var)
        {
            var.x -= 30;
            if (var.x < 0)
            {var. x = maxX + var.x; }
        }

        public static void KeyDown(tPoint var)
        {
            var.y += 30;
            if (var.y > maxY)
            { var.y = 0 + (var.y - maxY); }
        }

        public static void KeyUp(tPoint var)
        {
            var.y -= 30;
            if (var.y < 0)
            { var.y = maxY + var.y; }
        }

        public static void Random(tPoint var)
        {
            var.x = rnd.Next(maxX);
            var.y = rnd.Next(maxY);
            var.width = 1;
            var.hieght = 1;
            var.pn = new Pen(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
        }
    }
}

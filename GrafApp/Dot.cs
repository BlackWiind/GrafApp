using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrafApp
{
    class Dot
    {
        public int x , y;
        private readonly Random rnd = new Random();
        Pen pn;
        public Dot()
        {
            x = rnd.Next(0, 400);
            y = rnd.Next(0, 400);
            pn = new Pen(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));
        }
        
        public int X
        {
            get
            {
                
             return x;
            }
        }
        public int Y
        {
            get
            {
                
                return y;
            }
        }

        public Pen Pn
        {
            get
            {
                
                return pn;
            }
        }
    }
}

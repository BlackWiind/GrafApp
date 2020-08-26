using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafApp
{
    public partial class Form1 : Form
    {
        Dot[] dots = new Dot[100];
        public Form1()
        {
            Init();
            InitializeComponent();
            Draw();
        }
        private void Init()
        {
            for(int i = 0; i < 100; i++)
            {
                dots[i] = new Dot();
            }
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics grph = Graphics.FromImage(bmp);
            grph.DrawRectangle(dots[2].Pn, dots[2].X, dots[2].Y, 10, 10);
            grph.DrawRectangle(dots[20].Pn, dots[20].X, dots[20].Y, 10, 10);
            /*for (int i = 0; i < 100; i++)
            foreach(Dot d in dots)
            {
                grph.DrawRectangle(d.Pn,d.X,d.Y,10,10);
            }*/
            pictureBox1.Image = bmp;
        }
    }
}

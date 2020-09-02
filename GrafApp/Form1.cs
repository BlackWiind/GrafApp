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
    public partial class Lab1 : Form
    {
        tPoint[] dots = new tPoint[100];
        public Lab1()
        {
            InitializeComponent();
            Init();
            Draw();
        }

        private void Init()
        {
            for (int i = 0; i < dots.Length; i++)
            {
                dots[i] = new tPoint();
            }
        }
     
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics grph = Graphics.FromImage(bmp);
            foreach(tPoint d in dots)
            {
                grph.DrawRectangle(d.Pn,d.X,d.Y,1,1);
            }
            pictureBox1.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Init();
            Draw();
            pictureBox1.Focus();
            
        }

        private void Lab1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Right)
            {
                foreach (tPoint d in dots) { d.KeyRight(); }
                Draw();
            }

            if (e.KeyValue == (char)Keys.Left)
            {
                foreach (tPoint d in dots) { d.KeyLeft(); }
                Draw();
            }

            if (e.KeyValue == (char)Keys.Up)
            {
                foreach (tPoint d in dots) { d.KeyUp(); }
                Draw();
            }

            if (e.KeyValue == (char)Keys.Down)
            {
                foreach (tPoint d in dots) { d.KeyDown(); }
                Draw();
            }
        }
    }
}

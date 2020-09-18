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
            
        }

        private void Init()
        {
            for (int i = 0; i < dots.Length; i++)
            {
                dots[i] = new tPoint();
            }
            Draw(dots[0]);
            pictureBox1.Focus();
        }
     
        private void Draw(Object obj)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            if (obj is tPoint)
            {
                foreach (tPoint d in dots) { d.PointDraw(g); }                
            }
            pictureBox1.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void Lab1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Right)
            {
                foreach (tPoint d in dots) { d.KeyRight(); Draw(d); }
            }

            if (e.KeyValue == (char)Keys.Left)
            {
                foreach (tPoint d in dots) { d.KeyLeft(); Draw(d); }
            }

            if (e.KeyValue == (char)Keys.Up)
            {
                foreach (tPoint d in dots) { d.KeyUp(); Draw(d); }
            }

            if (e.KeyValue == (char)Keys.Down)
            {
                foreach (tPoint d in dots) { d.KeyDown(); Draw(d); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          pictureBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }
    }
}

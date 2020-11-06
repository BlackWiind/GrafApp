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

        List<tPoint> list = new List<tPoint>();
        
        public Lab1()
        {
            InitializeComponent();
            Init();
            
        }

        private void Init()
        {
            list.Clear();
            for (int i = 0; i < 100; i++)
            {
                list.Add(new tPoint());
            }
            Draw();
            pictureBox1.Focus();
        }
     
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            foreach(var tPoint in list)
            {
                tPoint.SomeDraw(g);
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
                foreach (tPoint d in list) { d.KeyRight(); Draw(); }
            }

            if (e.KeyValue == (char)Keys.Left)
            {
                foreach (tPoint d in list) { d.KeyLeft(); Draw(); }
            }

            if (e.KeyValue == (char)Keys.Up)
            {
                foreach (tPoint d in list) { d.KeyUp(); Draw(); }
            }

            if (e.KeyValue == (char)Keys.Down)
            {
                foreach (tPoint d in list) { d.KeyDown(); Draw(); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(new Circle());
            Draw();
            pictureBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(new Ellipse());
            Draw();
            pictureBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(new Line());
            Draw();
            pictureBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(new Triangle());
            Draw();
            pictureBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(new Rectangle());
            Draw();
            pictureBox1.Focus();
        }
    }
}

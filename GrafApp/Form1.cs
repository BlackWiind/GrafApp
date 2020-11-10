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
                foreach (tPoint d in list) 
                { if (d is Ellipse) 
                    { 
                        Ellipse.KeyRight(d); 
                    }
                  else if (d is Circle)
                    {
                        Circle.KeyRight(d);
                    }
                  else if (d is Triangle)
                    {
                        Triangle.KeyRight(d);
                    }
                  else if (d is Rectangle)
                    {
                        Rectangle.KeyRight(d);
                    }
                    else
                    {
                        Line.KeyRight(d);
                    }
                    Draw(); }
            }

            if (e.KeyValue == (char)Keys.Left)
            {
                foreach (tPoint d in list)
                {
                    if (d is Ellipse)
                    {
                        Ellipse.KeyLeft(d);
                    }
                    else if (d is Circle)
                    {
                        Circle.KeyLeft(d);
                    }
                    else if (d is Triangle)
                    {
                        Triangle.KeyLeft(d);
                    }
                    else if (d is Rectangle)
                    {
                        Rectangle.KeyLeft(d);
                    }
                    else
                    {
                        Line.KeyLeft(d);
                    }
                    Draw();
                }
            }

            if (e.KeyValue == (char)Keys.Up)
            {
                foreach (tPoint d in list)
                {
                    if (d is Ellipse)
                    {
                        Ellipse.KeyUp(d);
                    }
                    else if (d is Circle)
                    {
                        Circle.KeyUp(d);
                    }
                    else if (d is Triangle)
                    {
                        Triangle.KeyUp(d);
                    }
                    else if (d is Rectangle)
                    {
                        Rectangle.KeyUp(d);
                    }
                    else
                    {
                        Line.KeyUp(d);
                    }
                    Draw();
                }
            }

            if (e.KeyValue == (char)Keys.Down)
            {
                foreach (tPoint d in list)
                {
                    if (d is Ellipse)
                    {
                        Ellipse.KeyDown(d);
                    }
                    else if (d is Circle)
                    {
                        Circle.KeyDown(d);
                    }
                    else if (d is Triangle)
                    {
                        Triangle.KeyDown(d);
                    }
                    else if (d is Rectangle)
                    {
                        Rectangle.KeyDown(d);
                    }
                    else
                    {
                        Line.KeyDown(d);
                    }
                    Draw();
                }
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

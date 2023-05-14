using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WinForm_Paint
{
    public partial class Form1 : Form
    {
        SolidBrush sb;
        Graphics g;
        private bool isDrawing = false;

        private bool isPen = true;
        private bool isRec = false;
        private bool isEll = false;
        private bool isLin = false;
        private bool isEra = false;

        private Point p1, p2=new Point(),p3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            sb = new SolidBrush(panel2.BackColor);
            g = panel1.CreateGraphics();
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                panel2.BackColor = colorDialog1.Color;
                sb.Color = colorDialog1.Color;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            p1 = new Point(e.X,e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
            isDrawing = false;
            Pen pn = new Pen(panel2.BackColor, trackBar1.Value);
            if (isRec == true)//p1.X, p1.Y, Math.Abs(p1.X - p3.X), Math.Abs(p1.Y - p3.Y
            {             
               
                if (p1.X < p3.X)
                {
                    p2.X = p3.X - p1.X;
                }
                else if (p1.X > p3.X)
                {
                    p2.X = p1.X- p3.X;
                    p1.X = p3.X;
                }
                if (p1.Y < p3.Y)
                {
                    p2.Y = p3.Y - p1.Y;
                }
                else if (p1.Y > p3.Y)
                {
                    p2.Y = p1.Y- p3.Y;
                    p1.Y = p3.Y;
                }
                Rectangle r2 = new Rectangle(p1.X, p1.Y, p2.X, p2.Y);
                g.DrawRectangle(pn, r2);
            }
            else if (isEll == true)
            {
                if (p1.X < p3.X)
                {
                    p2.X = p3.X - p1.X;
                }
                else if (p1.X > p3.X)
                {
                    p2.X = p1.X - p3.X;
                    p1.X = p3.X;
                }
                if (p1.Y < p3.Y)
                {
                    p2.Y = p3.Y - p1.Y;
                }
                else if (p1.Y > p3.Y)
                {
                    p2.Y = p1.Y - p3.Y;
                    p1.Y = p3.Y;
                }
                Rectangle r2 = new Rectangle(p1.X, p1.Y, p2.X, p2.Y);
                g.DrawEllipse(pn, r2);
            }
            else if (isLin==true)
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                Pen pen = new Pen(sb, trackBar1.Value);
                g.DrawLine(pen, p1.X, p1.Y,p3.X, p3.Y);
                //pen.Dispose();
                //g.Dispose();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            p3 = new Point(e.X, e.Y);

            if (isDrawing == true && isPen == true)
            {
                g.FillEllipse(sb, e.X,e.Y, trackBar1.Value, trackBar1.Value);
            }
            else if (isDrawing == true && isEra == true)
            {
                SolidBrush sb2= new SolidBrush(panel1.BackColor);
                g.FillEllipse(sb2, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            }



        }

        private void button_rectangle_Click(object sender, EventArgs e)
        {
            isRec = true;
            isEll = false;
            isLin = false;
            isEra = false;
            isPen = false;
        }
        private void button_pen_Click(object sender, EventArgs e)
        {
            isRec = false;
            isEll = false;
            isLin = false;
            isEra = false;
            isPen = true;
        }
        private void button_Ellipse_Click(object sender, EventArgs e)
        {
            isRec = false;
            isEll = true;
            isLin = false;
            isEra = false;
            isPen = false;
        }
        private void button_line_Click(object sender, EventArgs e)
        {
            isRec = false;
            isEll = false;
            isLin = true;
            isEra = false;
            isPen = false;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            panel1.BackColor = sb.Color;
        }
        private void button_eraser_Click(object sender, EventArgs e)
        {
            isRec = false;
            isEll = false;
            isLin = false;
            isEra = true;
            isPen = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // My graphics objects
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 5);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            //This is a test comment
            
            // Code for drawing all shapes
            g.DrawLine(drawPen, 0, 0, 100, 100);
            g.DrawRectangle(drawPen, 30, 30, 100, 200);
            g.FillRectangle(drawBrush, 30, 30, 100, 200);
            g.DrawEllipse(drawPen, 30, 30, 100, 200);

            // Code for all text
            g.DrawPie(drawPen, 200, 20, 50, 50, 330, 60);
            g.DrawString("Hello\nHow are you?", drawFont, drawBrush, 200, 100);
        }
    }
}

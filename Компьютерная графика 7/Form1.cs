using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Компьютерная_графика_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        Graphics G;
        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Blue);
            g.DrawEllipse(Pens.Yellow, 0, 0, 150, 150);
            SolidBrush solidBrush = new SolidBrush(Color.Yellow);
            e.Graphics.FillEllipse(solidBrush, 0, 0, 150, 150);
            Pen pen = new Pen(Color.Blue);

            SolidBrush grass = new SolidBrush(Color.Brown);
            g.FillRectangle(grass, 0, 300, 1000, 200);
           
   
            for (int i = 0; i < 100; i++)
                g.DrawLine(new Pen(Brushes.Green, 2),0+10*i, 300, 100+i*10, 250);




        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cercuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.pictureBox = pictureBox1;
            Engine.listBox = listBox1;
            Engine.maxPoints = MaxPoints;
            Engine.xResult = XResult;
            Engine.yResult = YResult;

            Engine.Init();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Engine.GeneratePoints();
            Engine.Do();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            Engine.numPoints = Engine.points.Count;
            Engine.Do();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y, Color.Red);
            Engine.points.Add(p);
            p.Draw();
            Engine.pictureBox.Image = Engine.bitmap;
        }

        
    }
}

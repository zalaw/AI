using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistantaMinima
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

            Engine.Init();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Engine.points.Add(new Point(e.X, e.Y));
            Engine.graphics.FillEllipse(new SolidBrush(Color.Black), e.X - 4, e.Y - 4, 8, 8);
            Engine.pictureBox.Image = Engine.bitmap;
        }

        private void Go_Click(object sender, EventArgs e)
        {
            Engine.Do();
        }
    }
}

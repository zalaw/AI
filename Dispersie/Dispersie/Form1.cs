using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispersie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.width = pictureBox1.Width;
            Engine.height = pictureBox1.Height;
            Engine.pictureBox = pictureBox1;
            Engine.listBox = listBox1;

            Engine.generation = Generation;
            Engine.penalty = Penalty;
            Engine.bestPenalty = BestPenalty;

            Engine.Init();

            Engine.Do();
        }
    }
}

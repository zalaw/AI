﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cercuri
{
    public class Point
    {
        public int x;
        public int y;
        public Color color;

        public Point(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public void Draw()
        {
            Engine.graphics.FillEllipse(new SolidBrush(color), x - Engine.pointSize / 2, y - Engine.pointSize / 2, Engine.pointSize, Engine.pointSize);
        }
    }
}

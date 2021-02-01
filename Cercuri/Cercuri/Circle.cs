using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cercuri
{
    public class Circle
    {
        public Point center;
        public int points;
        public static int radius = 64;

        public Circle()
        {
            center = new Point(Engine.rnd.Next(Engine.pictureBox.Width), Engine.rnd.Next(Engine.pictureBox.Height), Color.Blue);
            points = GetPoints();
        }

        public Circle(Point center)
        {
            this.center = center;
            points = GetPoints();
        }

        public int GetPoints()
        {
            int result = 0;

            for (int j = 0; j < Engine.numPoints; j++)
            {
                if (Math.Pow(Engine.points[j].x - center.x, 2) + Math.Pow(Engine.points[j].y - center.y, 2) < Math.Pow(radius, 2))
                {
                    result++;
                }
            }

            return result;
        }

        public void Draw()
        {
            Engine.graphics.FillEllipse(new SolidBrush(center.color), center.x - Engine.pointSize / 2, center.y - Engine.pointSize / 2, Engine.pointSize, Engine.pointSize);
            Engine.graphics.DrawEllipse(new Pen(center.color, 2), center.x - radius, center.y - radius, radius * 2, radius * 2);
        }
    }
}

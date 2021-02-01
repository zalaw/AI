﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cercuri
{
    public class Sol
    {
        public List<Circle> circles;

        public Sol()
        {
            circles = new List<Circle>();

            for (int i = 0; i < Engine.numCircles; i++)
            {
                circles.Add(new Circle());
            }
        }

        public Sol(List<Circle> circles)
        {
            this.circles = circles;
        }

        public int CalculateFitness()
        {
            int result = 0;

            for (int i = 0; i < Engine.numCircles; i++)
            {
                result += circles[i].points;
            }

            /*
            for (int i = 0; i < Engine.numCircles; i++)
            {
                for (int j = 0; j < Engine.numPoints; j++)
                {
                    if (Math.Pow(Engine.points[j].x - circles[i].center.x, 2) + Math.Pow(Engine.points[j].y - circles[i].center.y, 2) < Math.Pow(Circle.radius, 2))
                    {
                        result++;
                    }
                }
            }
            */

            return result;
        }

        public Sol Crossover(Sol parent)
        {
            int cut = Engine.rnd.Next(Engine.numCircles);
            List<Circle> temp = new List<Circle>();

            for (int i = 0; i < cut; i++)
            {
                temp.Add(circles[i]);
            }

            for (int i = cut; i < Engine.numCircles; i++)
            {
                temp.Add(parent.circles[i]);
            }

            return new Sol(temp);
        }

        public void Mutate()
        {
            int i = Engine.rnd.Next(Engine.numCircles);

            circles[i] = new Circle();
        }

        public void Draw()
        {
            for (int i = 0; i < Engine.numCircles; i++)
            {
                circles[i].Draw();
            }
        }
    }
}

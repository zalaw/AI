using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistantaMinima
{
    public class Sol
    {
        public int n;
        public int[] elements;

        public Sol()
        {
            n = Engine.points.Count;

            elements = new int[n];

            for (int i = 0; i < n; i++)
            {
                elements[i] = i;
            }

            for (int i = n - 1; i > 0; i--)
            {
                int j = Engine.rnd.Next(i);

                int temp = elements[j];
                elements[j] = elements[i];
                elements[i] = temp;
            }
        }

        public Sol(int[] elements)
        {
            n = Engine.points.Count;
            this.elements = elements;
        }

        public double CalculateFitness()
        {
            double result = 0;

            for (int i = 1; i < n; i++)
            {
                result += Engine.GetDistance(Engine.points[elements[i - 1]], Engine.points[elements[i]]);
            }

            return result;
        }

        public Sol Crossover(Sol parent)
        {
            int position = Engine.rnd.Next(n - 1);
            int length = Engine.rnd.Next(1, n - position);

            int[] result = new int[n];
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                bool found = false;
                for (int j = position; j < position + length; j++)
                {
                    if (elements[i] == parent.elements[j])
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    result[k] = elements[i];
                    k++;
                }
            }

            for (int i = position; i < position + length; i++)
            {
                result[k] = parent.elements[i];
                k++;
            }

            return new Sol(result);
        }

        public void Mutate()
        {
            int i = Engine.rnd.Next(n);
            int j = Engine.rnd.Next(n);

            while (i == j)
            {
                j = Engine.rnd.Next(n);
            }

            int temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }

        public string View()
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += elements[i] + " ";
            }

            result += "F = " + CalculateFitness().ToString();

            return result;
        }

        public void Draw()
        {
            for (int i = 1; i < n; i++)
            {
                Engine.graphics.DrawLine(new Pen(Color.Red, 2), Engine.points[elements[i - 1]], Engine.points[elements[i]]);
            }
        }
    }
}

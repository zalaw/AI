using System;
using System.Collections.Generic;
using System.Text;

namespace Sisteme
{
    public class Sol
    {
        public double[] elements;

        public Sol()
        {
            elements = new double[Engine.n];

            for (int i = 0; i < Engine.n; i++)
            {
                elements[i] = Engine.rnd.NextDouble() * (Engine.high - Engine.low) + Engine.low; 
            }
        }

        public Sol(double[] elements)
        {
            this.elements = elements;
        }

        public double CalculateFitness()
        {
            double result = 0;

            for (int i = 0; i < Engine.n; i++)
            {
                double s = 0;

                for (int j = 0; j < Engine.n; j++)
                {
                    s += elements[j] * Engine.A[i, j];
                }

                result += Math.Abs(s - Engine.B[i]);
            }

            return result;
        }

        public Sol Crossover(Sol parent)
        {
            int cut = Engine.rnd.Next(1, Engine.n - 1);
            double[] result = new double[Engine.n];

            for (int i = 0; i < cut; i++)
            {
                result[i] = elements[i];
            }

            for (int i = cut; i < Engine.n; i++)
            {
                result[i] = parent.elements[i];
            }

            return new Sol(result);
        }

        public void Mutate()
        {
            int i = Engine.rnd.Next(Engine.n);

            elements[i] = Engine.rnd.NextDouble() * (Engine.high - Engine.low) + Engine.low;
        }

        public string View()
        {
            string result = "";

            for (int i = 0; i < Engine.n; i++)
            {
                result += $"{elements[i]} ";
            }

            return result;
        }
    }
}

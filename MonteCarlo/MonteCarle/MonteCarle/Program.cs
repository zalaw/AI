using System;

namespace MonteCarle
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = { 'X', 'D', 's', 'M' };
            double[] weights = { 1.23, 0.1, 3, 1 };
            int[] count = new int[symbols.Length];

            for (int i = 0; i < 100000; i++)
            {
                count[MC(weights)]++;
            } 

            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine($"{symbols[i]} = {count[i]}");
            }
        }

        static private int MC(double[] weights)
        {
            Random rnd = new Random();
            double sum = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                sum += weights[i];
            }

            double x = rnd.NextDouble() * sum;
            int j = 0;

            while (x > weights[j])
            {
                x -= weights[j];
                j++;
            }

            return j;
        }
    }
}

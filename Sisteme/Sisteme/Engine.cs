using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Sisteme
{
    public static class Engine
    {
        public static Random rnd = new Random();

        public static int n; 
        public static double[,] A;
        public static double[] B;

        public static double low = -5;
        public static double high = 5;

        public static double mutationRate = 0.01;
        public static double eps = 0.1;

        public static int N = 5000;
        public static int K = 50;

        public static List<Sol> population = new List<Sol>();

        public static void Do()
        {
            Load("../../../Data.in");

            population = new List<Sol>();

            GeneratePopulation();

            while (population[0].CalculateFitness() > eps)
            {
                SortPopulation();

                Console.WriteLine($"Fitness = {population[0].CalculateFitness()}, Sol = {population[0].View()}");

                List<Sol> temp = new List<Sol>();

                for (int i = 0; i < N; i++)
                {
                    Sol parent = population[rnd.Next(K)];
                    Sol child = population[i].Crossover(parent);

                    if (rnd.NextDouble() < mutationRate)
                    {
                        child.Mutate();
                    }

                    temp.Add(child);
                }

                for (int i = 0; i < N; i++)
                {
                    population[i] = temp[i];
                }
            }

            Console.WriteLine($"Fitness = {population[0].CalculateFitness()}, Sol = {population[0].View()}");
        }

        public static void GeneratePopulation()
        {
            for (int i = 0; i < N; i++)
            {
                population.Add(new Sol());
            }
        }

        public static void SortPopulation()
        {
            population.Sort((Sol A, Sol B) => A.CalculateFitness().CompareTo(B.CalculateFitness()));
        }

        public static void Load(string file)
        {
            StreamReader sr = new StreamReader(file);

            n = int.Parse(sr.ReadLine());
            A = new double[n, n];
            B = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] line = sr.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(line[j]);
                }
                B[i] = int.Parse(line[n]);
            }
        }

        public static void View()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{A[i, j]} ");
                }
                Console.WriteLine(B[i]);
            }
        }
    }
}

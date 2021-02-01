using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace DistantaMinima
{
    public static class Engine
    {
        public static Random rnd = new Random();

        public static Bitmap bitmap;
        public static Graphics graphics;

        public static PictureBox pictureBox;
        public static ListBox listBox;

        public static double mutationRate = 0.01;
        public static int N = 1000;
        public static int K = 10;
        public static List<Point> points = new List<Point>();
        public static List<Sol> population = new List<Sol>();

        public static void Init()
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        public static void Do()
        {
            Task.Run(async () =>
            {
                GeneratePopulation();

                while (true)
                {
                    graphics.Clear(Color.White);

                    SortPopulation();
                    DrawPoints();

                    population[0].Draw();

                    pictureBox.Image = bitmap;

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

                    await Task.Delay(1);
                }
            });
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

        public static void DrawPoints()
        {
            for (int i = 0; i < points.Count; i++)
            {
                graphics.FillEllipse(new SolidBrush(Color.Black), points[i].X - 4, points[i].Y - 4, 8, 8);
            }
        }

        public static double GetDistance(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
    }
}

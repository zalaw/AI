using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cercuri
{
    public static class Engine
    {
        public static Random rnd;

        public static PictureBox pictureBox;
        public static ListBox listBox;
        public static Label maxPoints;
        public static Label xResult;
        public static Label yResult;

        public static Bitmap bitmap;
        public static Graphics graphics;

        public static int pointSize = 8;
        public static int numPoints = 550;
        public static int numCircles = 10;
        public static double mutationRate = 0.1;

        public static int N = 1000;
        public static int K = 10;

        public static List<Point> points = new List<Point>();

        public static List<Sol> population = new List<Sol>();

        public static void Init()
        {
            rnd = new Random();

            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);

            maxPoints.Text = "0";
            xResult.Text = "-1";
            yResult.Text = "-1";
        }

        public static void Do()
        {
            Task.Run(async () =>
            {
                GeneratePopulation();
                SortPopulation();

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

                    await Task.Delay(500);
                }
            });
        }

        public static void SortPopulation()
        {
            population.Sort((Sol A, Sol B) => B.CalculateFitness().CompareTo(A.CalculateFitness()));
        }

        public static void GeneratePopulation()
        {
            for (int i = 0; i < N; i++)
            {
                population.Add(new Sol());
            }
        }

        public static void GeneratePoints()
        {
            for (int i = 0; i < numPoints; i++)
            {
                int x = rnd.Next(pictureBox.Width);
                int y = rnd.Next(pictureBox.Height);

                points.Add(new Point(x, y, Color.Black));
            }

            DrawPoints();
        }

        public static void DrawPoints()
        {
            for (int i = 0; i < numPoints; i++)
            {
                points[i].Draw();
            }
        }
    }
}

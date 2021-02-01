using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WFALee
{
    public partial class Form1 : Form
    {
        static Random rnd;

        static Bitmap btm;
        static Graphics grp;

        static Coord start;
        static Coord finish;

        static int[,] maze;

        static int rows;
        static int cols;
        static int wP;
        
        static float cellHeight;
        static float cellWidth;

        static Task task;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();

            go.Enabled = false;

            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(btm);

            mazeRows.Text = "16";
            mazeCols.Text = "16";
            wallsPercentage.Text = "20";

            startRow.Text = "3";
            startCol.Text = "8";
            finishRow.Text = "12";
            finishCol.Text = "15";
        }

        private void mazeGenerate_Click(object sender, EventArgs e)
        {
            rows = int.Parse(mazeRows.Text);
            cols = int.Parse(mazeCols.Text);
            wP = int.Parse(wallsPercentage.Text);

            start = new Coord(int.Parse(startRow.Text), int.Parse(startCol.Text));
            finish = new Coord(int.Parse(finishRow.Text), int.Parse(finishCol.Text));

            cellHeight = (pictureBox1.Height - 1) / (float)rows;
            cellWidth = (pictureBox1.Width - 1) / (float)cols;

            maze = GenerateMaze(rows, cols, wP, start, finish);

            DrawGrid();

            go.Enabled = true;
            
        }

        private void Random_Click(object sender, EventArgs e)
        {
            mazeRows.Text = rnd.Next(10, 101).ToString();
            mazeCols.Text = rnd.Next(10, 101).ToString();

            wallsPercentage.Text = rnd.Next(0, 51).ToString();

            startRow.Text = rnd.Next(int.Parse(mazeRows.Text) - 1).ToString();
            startCol.Text = rnd.Next(int.Parse(mazeCols.Text) - 1).ToString();

            finishRow.Text = rnd.Next(int.Parse(mazeRows.Text) - 1).ToString();
            finishCol.Text = rnd.Next(int.Parse(mazeCols.Text) - 1).ToString();

            mazeGenerate_Click(null, null);
        }

        private void go_Click(object sender, EventArgs e)
        {
            task = Task.Run(async () =>
            {
                mazeGenerate.Enabled = false;
                Random.Enabled = false;
                go.Enabled = false;

                Queue<Coord> queue = new Queue<Coord>();

                Coord start = new Coord(int.Parse(startRow.Text), int.Parse(startCol.Text));
                Coord finish = new Coord(int.Parse(finishRow.Text), int.Parse(finishCol.Text));

                bool[,] visited = new bool[int.Parse(mazeRows.Text), int.Parse(mazeCols.Text)];
                int[,] temp = new int[int.Parse(mazeRows.Text), int.Parse(mazeCols.Text)];

                bool found = false;

                queue.Enqueue(start);

                while (queue.Count != 0 && found == false)
                {
                    await Task.Delay(1);

                    Coord element = queue.Dequeue();
                    visited[element.Row, element.Col] = true;

                    Coord N = new Coord(element.Row - 1, element.Col);
                    Coord E = new Coord(element.Row, element.Col + 1);
                    Coord S = new Coord(element.Row + 1, element.Col);
                    Coord W = new Coord(element.Row, element.Col - 1);

                    if (N.Row == finish.Row && N.Col == finish.Col)
                    {
                        temp[element.Row - 1, element.Col] = temp[element.Row, element.Col] + 1;
                        found = true;
                    }
                    else if (E.Row == finish.Row && E.Col == finish.Col)
                    {
                        temp[element.Row, element.Col + 1] = temp[element.Row, element.Col] + 1;
                        found = true;
                    }
                    else if (S.Row == finish.Row && S.Col == finish.Col)
                    {
                        temp[element.Row + 1, element.Col] = temp[element.Row, element.Col] + 1;
                        found = true;
                    }
                    else if (W.Row == finish.Row && W.Col == finish.Col)
                    {
                        temp[element.Row, element.Col - 1] = temp[element.Row, element.Col] + 1;
                        found = true;
                    }
                    else
                    {
                        if (IsInBoundary(maze, N, visited))
                        {
                            temp[element.Row - 1, element.Col] = temp[element.Row, element.Col] + 1;
                            queue.Enqueue(N);
                            visited[N.Row, N.Col] = true;
                            grp.FillRectangle(new SolidBrush(Color.Yellow), N.Col * cellWidth, N.Row * cellHeight, cellWidth, cellHeight);
                            grp.DrawRectangle(new Pen(Color.Black), N.Col * cellWidth, N.Row * cellHeight, cellWidth, cellHeight);
                        }
                        if (IsInBoundary(maze, E, visited))
                        {
                            temp[element.Row, element.Col + 1] = temp[element.Row, element.Col] + 1;
                            queue.Enqueue(E);
                            visited[E.Row, E.Col] = true;
                            grp.FillRectangle(new SolidBrush(Color.Yellow), E.Col * cellWidth, E.Row * cellHeight, cellWidth, cellHeight);
                            grp.DrawRectangle(new Pen(Color.Black), E.Col * cellWidth, E.Row * cellHeight, cellWidth, cellHeight);
                        }
                        if (IsInBoundary(maze, S, visited))
                        {
                            temp[element.Row + 1, element.Col] = temp[element.Row, element.Col] + 1;
                            queue.Enqueue(S);
                            visited[S.Row, S.Col] = true;
                            grp.FillRectangle(new SolidBrush(Color.Yellow), S.Col * cellWidth, S.Row * cellHeight, cellWidth, cellHeight);
                            grp.DrawRectangle(new Pen(Color.Black), S.Col * cellWidth, S.Row * cellHeight, cellWidth, cellHeight);
                        }
                        if (IsInBoundary(maze, W, visited))
                        {
                            temp[element.Row, element.Col - 1] = temp[element.Row, element.Col] + 1;
                            queue.Enqueue(W);
                            visited[W.Row, W.Col] = true;
                            grp.FillRectangle(new SolidBrush(Color.Yellow), W.Col * cellWidth, W.Row * cellHeight, cellWidth, cellHeight);
                            grp.DrawRectangle(new Pen(Color.Black), W.Col * cellWidth, W.Row * cellHeight, cellWidth, cellHeight);
                        }

                        pictureBox1.Image = btm;
                    }
                }

                mazeGenerate.Enabled = true;
                Random.Enabled = true;
                go.Enabled = true;


                if (found)
                {
                    MessageBox.Show("Found!");
                }
                else
                {
                    MessageBox.Show("Not found!");
                }

                
                for (int i = 0; i < temp.GetLength(0); i++)
                {
                    string line = "";
                    for (int j = 0; j < temp.GetLength(1); j++)
                    {
                        line += temp[i, j] + " ";
                    }
                    listBox1.Items.Add(line);
                }
                listBox1.Items.Add("");
                

                task.Dispose();
            });
        }

        private void DrawGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (maze[i, j] == -1) // Start
                    {
                        grp.FillRectangle(new SolidBrush(Color.Red), j * cellWidth, i * cellHeight, cellWidth, cellHeight);
                    }
                    else if (maze[i, j] == -2) // Finish
                    {
                        grp.FillRectangle(new SolidBrush(Color.Blue), j * cellWidth, i * cellHeight, cellWidth, cellHeight);
                    }
                    else if (maze[i, j] == 1) // Wall
                    {
                        grp.FillRectangle(new SolidBrush(Color.Gray), j * cellWidth, i * cellHeight, cellWidth, cellHeight);
                    }
                    else
                    {
                        grp.FillRectangle(new SolidBrush(Color.White), j * cellWidth, i * cellHeight, cellWidth, cellHeight);
                    }
                    grp.DrawRectangle(new Pen(Color.Black), j * cellWidth, i * cellHeight, cellWidth, cellHeight);
                }
            }

            pictureBox1.Image = btm;
        }

        private int[,] GenerateMaze(int rows, int cols, int wallsPercentage, Coord start, Coord finish)
        {
            Random rnd = new Random();
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == start.Row && j == start.Col)
                    {
                        result[i, j] = -1;
                    }
                    else if (i == finish.Row && j == finish.Col)
                    {
                        result[i, j] = -2;
                    }
                    else
                    {
                        if (rnd.Next(100) < wallsPercentage)
                        {
                            result[i, j] = 1;
                        }
                    }
                }
            }

            return result;
        }
        
        

        private bool IsInBoundary(int[,] maze, Coord element, bool[,] visited)
        {
            if (element.Row >= 0 && element.Row < maze.GetLength(0) && element.Col >= 0 && element.Col < maze.GetLength(1))
            {
                if (visited[element.Row, element.Col] == false && maze[element.Row, element.Col] != 1)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}

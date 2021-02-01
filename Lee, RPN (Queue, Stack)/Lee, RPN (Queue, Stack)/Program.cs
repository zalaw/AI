using System;
using System.IO;

namespace Lee__RPN__Queue__Stack_
{
    class Program
    {
        static void Main(string[] args)
        {
            Lee();
            RPN();
        }

        static private void Lee()
        {
            int[,] ma = Load();
            int n = ma.GetLength(0);

            View(ma);

            LeeAlg(ma);
        }

        static private void LeeAlg(int[,] ma)
        {
            Coord start = new Coord(1, 0);
            Coord finish = new Coord(3, 2);
            Stack<Coord> stack = new Stack<Coord>();
            bool[,] visited = new bool[ma.GetLength(0), ma.GetLength(1)];
            bool found = false;

            if (ma[start.Row, start.Col] == 0 && ma[finish.Row, finish.Col] == 0)
            {
                stack.Push(start);

                while (stack.Count != 0)
                {
                    Coord element = stack.Pop();
                    visited[element.Row, element.Col] = true;

                    Console.Write($"({element.Row}, {element.Col}) -> ");

                    if (element.Row == finish.Row && element.Col == finish.Col)
                    {
                        found = true;
                    }

                    Coord N = new Coord(element.Row - 1, element.Col);
                    Coord E = new Coord(element.Row, element.Col + 1);
                    Coord S = new Coord(element.Row + 1, element.Col);
                    Coord W = new Coord(element.Row, element.Col - 1);

                    if (isInBoundary(ma, visited, N))
                    {
                        stack.Push(N);
                    }
                    if (isInBoundary(ma, visited, E))
                    {
                        stack.Push(E);
                    }
                    if (isInBoundary(ma, visited, S))
                    {
                        stack.Push(S);
                    }
                    if (isInBoundary(ma, visited, W))
                    {
                        stack.Push(W);
                    }
                }

                if (found)
                {
                    Console.WriteLine("Found!");
                }
                else
                {
                    Console.WriteLine("Not found!");
                }
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }

        static private bool isInBoundary(int[,] ma, bool[,] visited, Coord element)
        {
            if (element.Row >= 0 && element.Row < ma.GetLength(0) && element.Col >= 0 && element.Col < ma.GetLength(1))
            {
                if (visited[element.Row, element.Col] == false && ma[element.Row, element.Col] == 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        static private int[,] Load()
        {
            StreamReader sr = new StreamReader("../../../Data.in");

            int n = int.Parse(sr.ReadLine());
            int m = int.Parse(sr.ReadLine());
            int[,] ma = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] line = sr.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    ma[i, j] = int.Parse(line[j]);
                }
            }

            return ma;
        }

        static private void View(int[,] ma)
        {
            Console.WriteLine($"Rows: {ma.GetLength(0)}\nCols: {ma.GetLength(1)}");
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    Console.Write($"{ma[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static private void RPN()
        {
            Stack<double> stack = new Stack<double>();
            string[] expression = "2 1 + 5 2 * 15 6 - 4 * - +".Split(' ');
            string operators = "+-*/^";

            for (int i = 0; i < expression.Length; i++)
            {
                int index = operators.IndexOf(expression[i]);

                if (index == -1)
                {
                    stack.Push(double.Parse(expression[i]));
                } 
                else
                {
                    double val1 = stack.Pop();
                    double val2 = stack.Pop();
                    char op = operators[index];
                    stack.Push(GetValue(op, val1, val2));
                }

            }

            Console.WriteLine($"Result: {stack.Pop()}");
        }

        static private double GetValue(char op, double val1, double val2)
        {
            switch (op)
            {
                case '+':
                    return val2 + val1;
                case '-':
                    return val2 - val1;
                case '*':
                    return val2 * val1;
                case '/':
                    return val2 / val1;
                case '^':
                    return Math.Pow(val2, val1);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

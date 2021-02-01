using System;
using System.Collections.Generic;
using System.Text;

namespace Lee__RPN__Queue__Stack_
{
    class Stack<T>
    {
        public int Count { get; private set; }
        public T[] Data { get; private set; }

        public Stack()
        {
            Count = 0;
            Data = new T[Count];
        }

        public void Push(T value)
        {
            Count++;
            T[] temp = new T[Count];

            for (int i = 0; i < Count - 1; i++)
            {
                temp[i] = Data[i];
            }

            temp[Count - 1] = value;

            Data = temp;
        }

        public T Pop()
        {
            Count--;
            T result = Data[Count];
            T[] temp = new T[Count];

            for (int i = 0; i < Count; i++)
            {
                temp[i] = Data[i];
            }

            Data = temp;

            return result;
        }

        public void View()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write($"{Data[i]} ");
            }
            Console.WriteLine();
        }
    }
}

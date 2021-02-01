using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFALee
{
    public class Stack<T>
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
            T[] temp = new T[Count + 1];

            for (int i = 0; i < Count; i++)
            {
                temp[i] = Data[i];
            }

            temp[Count] = value;
            Count++;

            Data = temp;
        }

        public T Pop()
        {
            if (Count > 0)
            {
                T result = Data[Count - 1];
                T[] temp = new T[Count - 1];

                for (int i = 0; i < Count - 1; i++)
                {
                    temp[i] = Data[i];
                }

                Count--;
                Data = temp;

                return result;
            }
            else
            {
                throw new Exception("REEE");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFALee
{
    public class Queue<T>
    {
        public int Count { get; private set; }
        public T[] Data { get; private set; }

        public Queue()
        {
            Count = 0;
            Data = new T[Count];
        }

        public void Enqueue(T value)
        {
            Count++;
            T[] temp = new T[Count];

            for (int i = 1; i < Count; i++)
            {
                temp[i] = Data[i - 1];
            }

            temp[0] = value;

            Data = temp;
        }

        public T Dequeue()
        {
            if (Count > 0)
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

            throw new Exception("REE");
        }
    }
}

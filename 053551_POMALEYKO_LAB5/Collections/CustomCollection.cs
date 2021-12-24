using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053551_POMALEYKO_LAB5
{
    public class MyCustomCollection<T> : ICustomCollection<T>
    {
        int index = 0;
        public T[] buffer = new T[5];
        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= Count)
                    throw new IndexOutOfRangeException();
                return buffer[i];
            }

            set
            {
                if (i < 0 || i >= Count)
                    throw new IndexOutOfRangeException();
                buffer[i] = value;
            }
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (Count >= buffer.Length)
                Array.Resize<T>(ref buffer, buffer.Length * 2);
            buffer[Count] = item;
            index = Count;
            Count++;

        }

        public T Current()
        {
            return buffer[index];
        }

        public void Next()
        {
            index += 1;
        }

        public void Remove(T item)
        {
            int index = -1;
            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            if (index > -1)
            {
                T[] newData = new T[buffer.Length - 1];
                for (int i = 0, j = 0; i < buffer.Length; i++)
                {
                    if (i == index) continue;
                    newData[j] = buffer[i];
                    j++;
                }
                buffer = newData;
                Count--;

            }
        }

        public void RemoveCurrent()
        {
            Remove(Current());
        }

        public void Reset()
        {
            index = 0;
        }
    }
}


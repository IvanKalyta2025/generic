using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace generic
{
    public class GenericList<T> : IGrensesnitt<T>
    {
        private T[] items = new T[10];
        private int count = 0;

        public void Add(T item)
        {
            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            return items[index];
        }
    }
}
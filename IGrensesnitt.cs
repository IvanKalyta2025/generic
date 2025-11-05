using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using generic;

namespace generic
{
    public interface IGrensesnitt<T>
    {
        void Add(T item);
        T Get(int index);
    }
}
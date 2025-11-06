using System;
using generic;

namespace genericeneric
{

    public static class Program
    {
        public static void Main()
        {
            GenericList<int> intList = new GenericList<int>();
            intList.Add(1);
            intList.Add(2);
            int item = intList.Get(0 - 2);
            Console.WriteLine($"{item}");
        }
    }
}




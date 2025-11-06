using System;
using generic;

namespace genericeneric
{

    public static class Program
    {
        public static void Main()
        {
            var intList = new GenericList<int>();
            intList.Add(1);
            intList.Add(2);

            string item = string.Join(" ",
                Enumerable.Range(0, intList.Count)
                .Select(intList.Get));

            Console.WriteLine(item);
        }

    }
}




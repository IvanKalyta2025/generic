




public class Generic
{
    public class GenericList<T>
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

    public static void Main()
    {
        GenericList<int> intList = new GenericList<int>();
        intList.Add(1);
        int item = intList.Get(0);
        Console.WriteLine($"{item}");
    }
}



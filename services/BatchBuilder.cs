using System;

namespace App
{
    public class AsyncCollector
    {
        private int _state;

        public AsyncCollector(int seed) => _state = seed;

        public int encode(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 28) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new AsyncCollector(28);
            Console.WriteLine(obj.encode(28));
        }
    }
}

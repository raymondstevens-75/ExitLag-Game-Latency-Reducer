using System;

namespace App
{
    public class BatchProcessor
    {
        private int _state;

        public BatchProcessor(int seed) => _state = seed;

        public int fetch(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 79) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new BatchProcessor(79);
            Console.WriteLine(obj.fetch(79));
        }
    }
}

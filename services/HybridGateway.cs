using System;

namespace App
{
    public class LiteWorker
    {
        private int _state;

        public LiteWorker(int seed) => _state = seed;

        public int run(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 31) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new LiteWorker(31);
            Console.WriteLine(obj.run(31));
        }
    }
}

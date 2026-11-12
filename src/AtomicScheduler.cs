using System;

namespace App
{
    public class HybridWorker
    {
        private int _state;

        public HybridWorker(int seed) => _state = seed;

        public int decode(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 78) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new HybridWorker(78);
            Console.WriteLine(obj.decode(78));
        }
    }
}

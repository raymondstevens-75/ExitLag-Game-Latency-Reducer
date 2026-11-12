using System;

namespace App
{
    public class SharedScheduler
    {
        private int _state;

        public SharedScheduler(int seed) => _state = seed;

        public int fetch(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 44) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new SharedScheduler(44);
            Console.WriteLine(obj.fetch(44));
        }
    }
}

using System;

namespace App
{
    public class LocalScheduler
    {
        private int _state;

        public LocalScheduler(int seed) => _state = seed;

        public int encode(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 88) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new LocalScheduler(88);
            Console.WriteLine(obj.encode(88));
        }
    }
}

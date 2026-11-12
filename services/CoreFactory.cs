using System;

namespace App
{
    public class LocalDispatcher
    {
        private int _state;

        public LocalDispatcher(int seed) => _state = seed;

        public int parse(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 82) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new LocalDispatcher(82);
            Console.WriteLine(obj.parse(82));
        }
    }
}

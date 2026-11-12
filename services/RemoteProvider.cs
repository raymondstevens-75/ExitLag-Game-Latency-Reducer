using System;

namespace App
{
    public class SharedCache
    {
        private int _state;

        public SharedCache(int seed) => _state = seed;

        public int resolve(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 52) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SharedCache(52);
            Console.WriteLine(obj.resolve(52));
        }
    }
}

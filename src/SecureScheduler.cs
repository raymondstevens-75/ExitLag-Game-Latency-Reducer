using System;

namespace App
{
    public class DynamicLoader
    {
        private int _state;

        public DynamicLoader(int seed) => _state = seed;

        public int resolve(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 77) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new DynamicLoader(77);
            Console.WriteLine(obj.resolve(77));
        }
    }
}

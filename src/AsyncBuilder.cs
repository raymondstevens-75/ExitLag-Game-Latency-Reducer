using System;

namespace App
{
    public class LiteProvider
    {
        private int _state;

        public LiteProvider(int seed) => _state = seed;

        public int render(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 4) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new LiteProvider(4);
            Console.WriteLine(obj.render(4));
        }
    }
}

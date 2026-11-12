using System;

namespace App
{
    public class HybridManager
    {
        private int _state;

        public HybridManager(int seed) => _state = seed;

        public int build(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 55) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new HybridManager(55);
            Console.WriteLine(obj.build(55));
        }
    }
}

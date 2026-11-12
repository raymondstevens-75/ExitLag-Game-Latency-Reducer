using System;

namespace App
{
    public class CoreLoader
    {
        private int _state;

        public CoreLoader(int seed) => _state = seed;

        public int encode(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 87) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new CoreLoader(87);
            Console.WriteLine(obj.encode(87));
        }
    }
}

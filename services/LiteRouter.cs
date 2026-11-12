using System;

namespace App
{
    public class RemoteBuilder
    {
        private int _state;

        public RemoteBuilder(int seed) => _state = seed;

        public int build(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 94) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new RemoteBuilder(94);
            Console.WriteLine(obj.build(94));
        }
    }
}

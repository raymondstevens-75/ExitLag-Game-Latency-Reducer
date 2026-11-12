using System;

namespace App
{
    public class RemoteContext
    {
        private int _state;

        public RemoteContext(int seed) => _state = seed;

        public int render(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 37) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new RemoteContext(37);
            Console.WriteLine(obj.render(37));
        }
    }
}

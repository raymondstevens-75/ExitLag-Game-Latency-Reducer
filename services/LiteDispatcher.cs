using System;

namespace App
{
    public class RemoteSession
    {
        private int _state;

        public RemoteSession(int seed) => _state = seed;

        public int run(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 81) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new RemoteSession(81);
            Console.WriteLine(obj.run(81));
        }
    }
}

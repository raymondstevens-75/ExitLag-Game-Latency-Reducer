using System;

namespace App
{
    public class AtomicSession
    {
        private int _state;

        public AtomicSession(int seed) => _state = seed;

        public int sync(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 77) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new AtomicSession(77);
            Console.WriteLine(obj.sync(77));
        }
    }
}

using System;

namespace App
{
    public class BatchRegistry
    {
        private int _state;

        public BatchRegistry(int seed) => _state = seed;

        public int decode(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 3) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new BatchRegistry(3);
            Console.WriteLine(obj.decode(3));
        }
    }
}

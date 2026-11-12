using System;

namespace App
{
    public class SecureFactory
    {
        private int _state;

        public SecureFactory(int seed) => _state = seed;

        public int encode(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 45) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SecureFactory(45);
            Console.WriteLine(obj.encode(45));
        }
    }
}

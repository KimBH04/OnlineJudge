using System;

namespace _27159
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = 0;
            var n = int.Parse(Console.ReadLine());
            var x = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            var o = x[0];
            for (int i = 0; i < n - 1; i++)
            {
                if (x[i + 1] - x[i] != 1)
                {
                    r += o;
                    o = x[i + 1];
                }
            }
            r += o;

            Console.WriteLine(r);
        }
    }
}

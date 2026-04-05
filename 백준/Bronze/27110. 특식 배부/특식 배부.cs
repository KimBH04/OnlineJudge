using System;

namespace _27110
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = 0;
            var n = int.Parse(Console.ReadLine());
            var c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            foreach (var i in c) if (i < n) r += i; else r += n;

            Console.WriteLine(r);
        }
    }
}

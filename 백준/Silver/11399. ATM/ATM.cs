using System;
using System.Linq;

namespace _11399
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var p2 = new int[n];
            Array.Sort(p);
            for (int i = 0; i < n; i++) p2[i] = p[..(i + 1)].Sum();
            Console.WriteLine(p2.Sum());
        }
    }
}

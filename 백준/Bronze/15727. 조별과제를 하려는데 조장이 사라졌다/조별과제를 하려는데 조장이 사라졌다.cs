using System;

namespace _15727
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = int.Parse(Console.ReadLine());
            var t = l / 5 + (l % 5 > 0 ? 1 : 0);
            Console.WriteLine(t);
        }
    }
}

using System;

namespace _2028
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine();
                var nlen = input.Length;
                var n = double.Parse(input);
                var c = n * n % Math.Pow(10, nlen);
                if (n == c) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
    }
}

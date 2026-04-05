using System;

namespace _26217
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 1D;
            var n = double.Parse(Console.ReadLine());

            for (var i = n - 1; i > 0; i--)
            {
                result += n / i;
            }

            Console.WriteLine(result);
        }
    }
}

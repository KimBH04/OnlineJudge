using System;

namespace _11050
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Console.WriteLine(Factorial(int.Parse(input[0])) / (Factorial(int.Parse(input[1])) * Factorial(int.Parse(input[0]) - int.Parse(input[1]))));
        }

        static int Factorial(int n)
        {
            var a = 1;

            for (int i = 1; i <= n; i++) a *= i;

            return a;
        }
    }
}

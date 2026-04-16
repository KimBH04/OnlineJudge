using System;

namespace _26082
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var A = int.Parse(input[0]);
            var B = int.Parse(input[1]);
            var C = int.Parse(input[2]);
            Console.WriteLine(B / A * 3 * C);
        }
    }
}

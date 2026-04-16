using System;

namespace _26307
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Console.WriteLine((int.Parse(input[0]) - 9) * 60 + int.Parse(input[1]));
        }
    }
}

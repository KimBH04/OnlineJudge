using System;

namespace Prob25372
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                if (input.Length >= 6 && input.Length <= 9)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }
        }
    }
}

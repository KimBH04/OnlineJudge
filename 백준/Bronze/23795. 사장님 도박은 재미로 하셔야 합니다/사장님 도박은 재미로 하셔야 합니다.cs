using System;

namespace _23795
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;

            while (true)
            {
                var input = int.Parse(Console.ReadLine());
                if (input == -1)
                {
                    Console.WriteLine(result);
                    return;
                }
                result += input;
            }
        }
    }
}

using System;

namespace _26594
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 1;
            var ZOAC = Console.ReadLine().ToCharArray();

            for (int i = 0; i < ZOAC.Length - 1; i++)
            {
                if (ZOAC[i] == ZOAC[i + 1])
                {
                    result++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}

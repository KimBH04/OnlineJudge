using System;

namespace Prob1712
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = input[2] - input[1];
            if (a < 1)
            {
                Console.WriteLine("-1");
            }
            else
            {

                Console.WriteLine(input[0] / a + 1);
            }
        }
    }
}

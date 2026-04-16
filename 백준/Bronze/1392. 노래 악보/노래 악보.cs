using System;
using System.Collections.Generic;

namespace Prob1392
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int>();
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), q = int.Parse(input[1]);
            for (int i = 1; i <= n; i++)
            {
                int second = int.Parse(Console.ReadLine());
                for (int j = 0; j < second; j++)
                    ls.Add(i);
            }
            for (int i = 0; i < q; i++)
                Console.WriteLine(ls[int.Parse(Console.ReadLine())]);
        }
    }
}

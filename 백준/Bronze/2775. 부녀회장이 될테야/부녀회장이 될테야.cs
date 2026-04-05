using System;

namespace Prob2775
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] people = new int[T];
            for (int i = 0; i < T; i++)
            {
                int k = int.Parse(Console.ReadLine()) + 1, 
                    n = int.Parse(Console.ReadLine());
                int[,] apartment = new int[k, n];
                apartment[0, 0] = 1;
                for (int j = 0; j < n; j++)
                    apartment[0, j] = j + 1;
                for (int j = 1; j < k; j++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        for (int m = 1; m <= l + 1; m++)
                            apartment[j, l] += apartment[j - 1, m - 1];
                    }
                }
                people[i] = apartment[k - 1, n - 1];
            }
            foreach (int a in people)
                Console.WriteLine(a);
        }
    }
}

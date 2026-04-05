using System;

namespace Prob1978
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = n;

            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 1)
                {
                    result--;
                    continue;
                }

                if (arr[i] == 2) continue;

                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        result--;
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}

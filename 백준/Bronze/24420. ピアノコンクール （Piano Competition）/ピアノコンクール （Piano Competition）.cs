using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            var tensuu = int.Parse(Console.ReadLine());
            var tensuura = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 1; i < tensuu; i++)
            {
                for (int j = 0; j < tensuu - i; j++)
                {
                    if (tensuura[j] > tensuura[j + 1])
                    {
                        var tenpu = tensuura[j];
                        tensuura[j] = tensuura[j + 1];
                        tensuura[j + 1] = tenpu;
                    }
                }
            }

            for (int i = 1; i < tensuu - 1; i++)
            {
                result += tensuura[i];
            }

            Console.WriteLine(result);
        }
    }
}

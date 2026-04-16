using System;

namespace _7572
{
    class Program
    {
        static int[] N = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static char[] C = "ABCDEFGHIJKL".ToCharArray();
        static string[] S = new string[60];
        static void Main(string[] args)
        {
            for (int i = 0, j = 0, y = 0; y < 60; i++, j++, y++)
            {
                i %= 10; j %= 12;
                S[y] = C[j] + N[i].ToString();
            }

            Console.WriteLine(S[(int.Parse(Console.ReadLine()) + 56) % 60]);
        }
    }
}

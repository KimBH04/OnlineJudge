using System;

namespace Prob11656
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] S = Console.ReadLine().ToCharArray();
            string[] SS = new string[S.Length];
            for (int i = 0; i < S.Length; i++)
                for (int j = i; j < S.Length; j++)
                    SS[i] += S[j];
            Array.Sort(SS);
            foreach (string a in SS)
                Console.WriteLine(a);
        }
    }
}

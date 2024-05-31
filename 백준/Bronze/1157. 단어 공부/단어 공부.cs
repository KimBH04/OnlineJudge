using System;

namespace Prob1157
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 1;
            int max = 0;
            int maxA = 0;
            int[] alphabets = new int[26];
            char[] word = Console.ReadLine().ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] < 91)
                    alphabets[word[i] - 65]++;
                else
                    alphabets[word[i] - 97]++;
            }

            for (int i = 0; i < 26; i++)
                if (alphabets[i] > maxA)
                {
                    maxA = alphabets[i];
                    max = i;
                }

            for (int i = 0; i < 26; i++)
                if (maxA != alphabets[i] || max == i)
                    continue;
                else
                {
                    Console.WriteLine('?');
                    b = 0;
                    break;
                }

            if (b != 0)
                Console.WriteLine((char)(max + 65));
        }
    }
}

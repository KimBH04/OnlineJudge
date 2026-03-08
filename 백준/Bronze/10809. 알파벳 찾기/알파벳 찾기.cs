using System;

namespace Prob10809
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] alphabets = new int[26];
            char[] word = Console.ReadLine().ToCharArray();

            for (int i = 0; i < 26; i++)
                alphabets[i] = -1;

            for (int i = 0; i < word.Length; i++)
            {
                if (alphabets[word[i] - 97] == -1)
                    alphabets[word[i] - 97] = i;
            }

            for ( int i = 0; i < 26; i++)
                Console.Write(alphabets[i] + " ");
        }
    }
}

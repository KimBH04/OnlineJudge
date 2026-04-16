using System;

namespace Prob10808
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] alphabets = new int[26] 
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            char[] words = Console.ReadLine().ToCharArray();
            for (int i = 0; i < words.Length; i++)
                alphabets[words[i] - 97]++;
            foreach (int a in alphabets)
                Console.Write(a + " ");
        }
    }
}

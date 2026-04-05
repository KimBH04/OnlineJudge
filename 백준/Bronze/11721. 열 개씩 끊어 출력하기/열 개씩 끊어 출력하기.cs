using System;

namespace Prob11721
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] words = Console.ReadLine().ToCharArray();
            for (int i = 0; i < words.Length;)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(words[i]);
                    i++;
                    if (i == words.Length)
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}

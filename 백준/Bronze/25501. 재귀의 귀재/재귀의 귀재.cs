using System;

namespace Prob25501
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                var word = Console.ReadLine().ToCharArray();

                Recursion(word, 1, 0, word.Length - 1);
            }
        }

        static int Recursion(char[] word, int i ,int j, int k)
        {
            if (j >= k)
            {
                Console.WriteLine("1 {0}", i);
                return 1;
            }
            else if (word[j] != word[k])
            {
                Console.WriteLine("0 {0}", i);
                return 0;
            }
            else
            {
                return Recursion(word, ++i, ++j, --k);
            }
        }
    }
}

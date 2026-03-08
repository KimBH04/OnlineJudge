using System;

namespace Prob25205
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordCount = int.Parse(Console.ReadLine()) - 1;
            char[] word = Console.ReadLine().ToCharArray();

            if (word[wordCount] == 'q' ||
                word[wordCount] == 'w' ||
                word[wordCount] == 'e' ||
                word[wordCount] == 'r' ||
                word[wordCount] == 't' ||
                word[wordCount] == 'a' ||
                word[wordCount] == 's' ||
                word[wordCount] == 'd' ||
                word[wordCount] == 'f' ||
                word[wordCount] == 'g' ||
                word[wordCount] == 'z' ||
                word[wordCount] == 'x' ||
                word[wordCount] == 'c' ||
                word[wordCount] == 'v' ||
                word[wordCount] == 'R' ||
                word[wordCount] == 'T')
                Console.Write(1);
            else
                Console.Write(0);
        }
    }
}

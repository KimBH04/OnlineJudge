using System;
using System.Collections.Generic;

namespace Prob1264
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vs = new List<int>();
            while (true)
            {
                int vowels = 0;
                char[] words = Console.ReadLine().ToCharArray();
                if (words.Length == 1 && words[0] == '#')
                    break;
                foreach (char a in words)
                    if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u' ||
                        a == 'A' || a == 'E' || a == 'I' || a == 'O' || a == 'U')
                        vowels++;
                vs.Add(vowels);
            }
            foreach (int a in vs)
                Console.WriteLine(a);
        }
    }
}

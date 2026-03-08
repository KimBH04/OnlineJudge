using System;

namespace Prob1152
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            int a = words.Length;

            if (words[0] == "")
                a -= 1;
            if (words[words.Length - 1] == "")
                a -= 1;

            Console.WriteLine(a);
        }
    }
}

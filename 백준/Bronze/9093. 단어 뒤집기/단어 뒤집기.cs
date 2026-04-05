using System;

namespace Prob9093
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string[] words = new string[T];
            for (int i = 0; i < T; i++)
            {
                string[] input = Console.ReadLine().Split();
                foreach (string a in input)
                {
                    char[] reverse = a.ToCharArray();
                    Array.Reverse(reverse);
                    foreach (var b in reverse)
                    {
                        words[i] += b;
                    }
                    words[i] += " ";
                }
            }
            foreach (var a in words)
                Console.WriteLine(a);
        }
    }
}

using System;

namespace Prob2675
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            string[] strings = new string[times];

            for (int i = 0; i < times; i++)
            {
                string[] input = Console.ReadLine().Split();
                int rep = int.Parse(input[0]);
                char[] alphabets = input[1].ToCharArray();

                for (int j = 0; j < alphabets.Length; j++)
                    for (int k = 0; k < rep; k++)
                    {
                        strings[i] += alphabets[j];
                    }
            }
            for (int i = 0; i < times; i++)
                Console.WriteLine(strings[i]);
        }
    }
}

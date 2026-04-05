using System;
using System.Text;

namespace _1159
{
    class Program
    {
        static void Main(string[] args)
        {
            var isDraft = true;
            var cAlphabets = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var alphabets = new int[26];
            var times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                var lastName = Console.ReadLine().ToCharArray();
                alphabets[lastName[0] - 97]++;
            }

            var index = 0;

            foreach (var item in alphabets)
            {
                if (item >= 5)
                {
                    Console.Write(cAlphabets[index]);
                    isDraft = false;
                }

                index++;
            }

            if (isDraft)
            {
                Console.Write("PREDAJA");
            }
        }
    }
}

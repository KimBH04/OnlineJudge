using System;
using System.Linq;

namespace Prob1181
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = int.Parse(Console.ReadLine());
            var words = new string[times];

            for (int i = 0; i < times; i++)
            {
                words[i] = Console.ReadLine();
            }

            Array.Sort(words);

            for (int i = 0; i < times - 1; i++)
            {
                for (int j = 0; j < times - 1; j++)
                {
                    if (words[j].Length > words[j + 1].Length)
                    {
                        var temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                    }
                }
            }

            var output = words.Distinct();
            foreach(var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}

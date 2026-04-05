using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2711
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            string[] output = new string[times];
            for (int i = 0; i < times; i++)
            {
                string[] input = Console.ReadLine().Split();
                char[] words = input[1].ToCharArray();
                words[int.Parse(input[0]) - 1] = '\\';
                foreach (char item in words)
                    if (item != '\\')
                        output[i] += item;
            }
            foreach (string item in output)
                Console.WriteLine(item);
        }
    }
}

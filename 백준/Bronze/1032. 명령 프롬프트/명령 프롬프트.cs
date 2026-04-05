using System;

namespace Prob1032
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            char[] fileName = Console.ReadLine().ToCharArray();
            for (int i = 1; i < times; i++)
            {
                char[] fileName2 = Console.ReadLine().ToCharArray();
                for (int j = 0; j < fileName.Length; j++)
                    if (fileName[j] != fileName2[j])
                        fileName[j] = '?';
            }
            foreach (var item in fileName)
                Console.Write(item);
        }
    }
}

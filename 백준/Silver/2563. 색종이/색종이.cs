using System;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = 0;

            var dohwaji = new bool[100, 100];
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    dohwaji[i, j] = false;
                }
            }

            var times = int.Parse(Console.ReadLine());

            for (int a = 0; a < times; a++)
            {
                var input = Console.ReadLine().Split();
                var x = int.Parse(input[0]);
                var y = int.Parse(input[1]);

                for (int i = x; i < x + 10; i++)
                {
                    for (int j = y; j < y + 10; j++)
                    {
                        dohwaji[i, j] = true;
                    }
                }
            }

            foreach (var item in dohwaji)
            {
                if (item)
                {
                    area++;
                }
            }

            Console.WriteLine(area);
        }   
    }
}

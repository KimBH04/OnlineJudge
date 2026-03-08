using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a];

            for (int i = 0; i < a; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b[i]; j++)
                {
                    for (int k = 0; k < b[i]; k++)
                        if (j == 0 || j == b[i] - 1 || k == 0 || k == b[i] - 1)
                            Console.Write('#');
                        else
                            Console.Write('J');

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}

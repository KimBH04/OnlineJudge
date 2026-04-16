using System;

namespace Prob2566
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[9, 9];

            var max = int.MinValue;

            var l = 0; var r = 0;

            for (int i = 0; i < 9; i++)
            {
                var input = Console.ReadLine().Split();

                for (int j = 0; j < 9; j++)
                {
                    var temp = int.Parse(input[j]);

                    if (max < temp)
                    {
                        max = temp;
                        l = i + 1; r = j + 1;
                    }
                }
            }

            Console.WriteLine("{0}\n{1} {2}", max, l, r);
        }
    }
}

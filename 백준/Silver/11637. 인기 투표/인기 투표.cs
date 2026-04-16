using System;
using System.Linq;

namespace Prob11637
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                float max = int.MinValue;
                int num = 0;
                int people = int.Parse(Console.ReadLine());
                float[] voteCast = new float[people];
                for (int j = 0; j < people; j++)
                {
                    voteCast[j] = int.Parse(Console.ReadLine());
                }
                for (int j = 0; j < people; j++)
                {
                    if (max < voteCast[j])
                    {
                        max = voteCast[j];
                        num = j + 1;
                    }
                }
                Array.Sort(voteCast);
                if (voteCast[^1] == voteCast[^2])
                {
                    Console.WriteLine("no winner");
                }
                else if (max > voteCast.Sum() / 2)
                {
                    Console.WriteLine($"majority winner {num}");
                }
                else
                {
                    Console.WriteLine($"minority winner {num}");
                }
            }
        }
    }
}

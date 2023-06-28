using System;

namespace Prob1002
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = int.Parse(Console.ReadLine());

            for (int i = 0; i <times; i++)
            {
                var input = Console.ReadLine().Split();

                var x1 = int.Parse(input[0]);
                var y1 = int.Parse(input[1]);
                var r1 = int.Parse(input[2]);
                var x2 = int.Parse(input[3]);
                var y2 = int.Parse(input[4]);
                var r2 = int.Parse(input[5]);
                
                if (r1 == 0)
                {
                    Console.WriteLine(1);
                    continue;
                }

                var distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

                if (distance == 0 && r1 == r2)
                {
                    Console.WriteLine(-1);
                }
                else if (Math.Abs(r1 - r2) == distance || r1 + r2 == distance)
                {
                    Console.WriteLine(1);
                }
                else if (Math.Abs(r1 - r2) < distance && distance < (r1 + r2))
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}

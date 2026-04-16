using System;

namespace bakjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (input[0] == 0 && input[1] == 0 && input[2] == 0)
                    break;

                for (int i = 1; i < 3; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (input[j] > input[j + 1])
                        {
                            var temp = input[j];
                            input[j] = input[j + 1];
                            input[j + 1] = temp;
                        }
                    }
                }

                var x = input[0];
                var y = input[1];
                var r = input[2];

                var isRightTriagle = Math.Sqrt(x * x + y * y) == (double)r;

                if (isRightTriagle)
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            }
        }
    }
}

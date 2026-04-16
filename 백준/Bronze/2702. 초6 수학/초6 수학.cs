using System;

namespace _2702
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                if (num[0] < num[1])
                {
                    var temp = num[0];
                    num[0] = num[1];
                    num[1] = temp;
                }

                var a = GCD(num[0], num[1]);

                Console.WriteLine(num[0] * num[1] / a + " " + a);
            }
        }

        static int GCD(int a, int b)
        {
            if (a % b == 0)  return b;
            return GCD(b, a % b);
        }
    }
}

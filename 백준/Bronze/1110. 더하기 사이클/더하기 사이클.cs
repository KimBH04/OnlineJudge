using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int d = a;

            for(int i = 0; ; i++)
            {
                int b = d % 10;
                int c = (d - b) / 10;

                //Console.WriteLine("{0} {1}", b , c);

                d = c + b;
                d = b * 10 + d % 10;

                //Console.WriteLine(d);

                if (d == a)
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }
    }
}

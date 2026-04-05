using System;

namespace _26264
{
    class Program
    {
        static void Main(string[] args)
        {
            var idx = 0;

            var b = 0;
            var s = 0;

            var n = int.Parse(Console.ReadLine());
            var q = Console.ReadLine().ToCharArray();

            for (int i = 0; i < n; i++)
            {
                if (q[idx] == 'b')
                {
                    b++;
                    idx += 7;
                }
                else
                {
                    s++;
                    idx += 8;
                }
            }

            if (b > s)
            {
                Console.WriteLine("bigdata?");
            }
            else if (s > b)
            {
                Console.WriteLine("security!");   
            }
            else
            {
                Console.WriteLine("bigdata? security!");
            }
        }
    }
}
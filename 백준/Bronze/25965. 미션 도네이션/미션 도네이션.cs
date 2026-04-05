using System;

namespace _25965
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var r = 0L;
                var m = int.Parse(Console.ReadLine());

                var don = new long[m, 3];
                var input = new long[0];

                for (int j = 0; j < m; j++)
                { 
                    input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

                    don[j, 0] = input[0];
                    don[j, 1] = input[1];
                    don[j, 2] = input[2];
                }

                input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

                for (int j = 0; j < m; j++)
                {
                    var k = don[j, 0] * input[0];
                    var d = don[j, 1] * input[1];
                    var a = don[j, 2] * input[2];

                    if (k - d + a > 0)
                        r += k - d + a;
                }

                Console.WriteLine(r);
            } 
        }
    }
}

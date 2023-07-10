using System;

namespace _13140
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int h = 1; h < 10; h++)
            {
                for (int e = 0; e < 10; e++)
                {
                    if (e == h)
                        continue;

                    for (int l = 0; l < 10; l++)
                    {
                        if (l == h || l == e)
                            continue;

                        for (int o = 0; o < 10; o++)
                        {
                            if (o == h || o == e || o == l)
                                continue;

                            for (int w = 1; w < 10; w++)
                            {
                                if (w == h || w == e || w == l || w == o)
                                    continue;

                                for (int r = 0; r < 10; r++)
                                {
                                    if (r == h || r == e || r == l || r == o || r == w)
                                        continue;

                                    for (int d = 0; d < 10; d++)
                                    {
                                        if (d == h || d == e || d == l || d == o || d == w || d == r)
                                            continue;

                                        var hello = int.Parse("" + h + e + l + l + o);
                                        var world = int.Parse("" + w + o + r + l + d);

                                        if (hello + world == n)
                                        {
                                            Console.WriteLine("  " + hello);
                                            Console.WriteLine("+ " + world);
                                            Console.WriteLine("-------");

                                            if (n.ToString().Length == 5) Console.WriteLine("  " + n);
                                            else Console.WriteLine(" " + n);

                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("No Answer");
        }
    }
}

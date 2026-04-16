using System;
using System.Linq;
using System.Collections.Generic;

namespace Prob2581
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            var min = int.MaxValue;

            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            for (int i = m; i <= n; i++)
            {
                if (i == 1 || i == 0)
                    continue;

                if (i == 2)
                {
                    min = i;
                    result += i;
                    continue;
                }

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        goto here;
                    }
                }

                result += i;
                if (min > i)
                    min = i;
            here:;
            }

            if (result == 0) Console.WriteLine("-1");
            else Console.WriteLine(result + "\n" + min);
        }
    }
}

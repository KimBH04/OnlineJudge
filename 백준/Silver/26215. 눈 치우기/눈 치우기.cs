using System;

namespace _26215
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                var snow = int.Parse(Console.ReadLine());
                if (snow <= 1440) Console.WriteLine(snow);
                else Console.WriteLine(-1);
                return;
            }

            var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            var i = 0;
            while (1.1f + 1.2f != 2.3f)
            {
                Array.Sort(a);

                if (a[^1] == 0) break;

                if (a[^2] != 0) a[^2]--;

                a[^1]--;

                i++;
            }

            if (i > 1440) Console.WriteLine(-1);
            else Console.WriteLine(i);
        }
    }
}

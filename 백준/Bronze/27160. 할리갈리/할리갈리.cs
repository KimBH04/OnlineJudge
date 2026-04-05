using System;

namespace _27160
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new System.Collections.Generic.Dictionary<string, int>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var sx = Console.ReadLine().Split();
                if (d.ContainsKey(sx[0])) d[sx[0]] += int.Parse(sx[1]);
                else d.Add(sx[0], int.Parse(sx[1]));
            }

            foreach (var item in d.Values)
            {
                if (item == 5)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }

            Console.WriteLine("NO");
        }
    }
}

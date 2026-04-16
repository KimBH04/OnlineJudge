using System;

namespace _27111
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = 0;
            var d = new System.Collections.Generic.Dictionary<int, bool>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var I = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                if (d.ContainsKey(I[0]))
                {
                    if (I[1] == 1)
                    {
                        r++;
                    }
                    else
                    {
                        d.Remove(I[0]);
                    }
                }
                else
                {
                    if (I[1] == 1)
                    {
                        d.Add(I[0], false);
                    }
                    else
                    {
                        r++;
                    }
                }
            }

            Console.WriteLine(r + d.Count);
        }
    }
}